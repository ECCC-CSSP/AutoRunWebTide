/* PROGRAM: tidecor
   VERSION: 2.5
   DATE :   December, 2010
   Author : Jason Chaffey


   Version 1.0 
 *******************************************************************************
 * This program for tide correction of hydrographic data is derived from
 * interp2d.c - Modifications and additions made by Patrick Roussel May 21,1999
 *****************************************************************************  

   Version 2.0   
   The FORTRAN components of Ver1.0 were translated to c for portability.
   Original FORTRAN written by M. Foreman at IOS.
   RAYBOUND bug fixed.
   Jason Chaffey              December 15, 2000
  

   Version 2.1   
   Added configuration file (tidecor2.?.cfg) so that the following are not
   hard-wired into the program:
       - mesh filenames (.nod and .ele);
       - the number of constituents to be used; and
       - for each constituent:
             - name of constituent; and
             - filename for data of that constituent.
   Jason Chaffey              January 15, 2001
  

   Version 2.2   
   Added support for complex input data (.v2c files)
   Jason Chaffey              March 23, 2001
  

   Version 2.3   
  
 * Tested against Pawlawicz's T_Tide and 
 * Foreman's tide4_r2  - Shawn Oakey
 *
  

   Version 2.4   
  
 * Debugging (float - double and int - long int conflicts) done
 * Switched to Manhattan distance vs "real" distance in closestnode
 *          - speed increase consideration
 * Thanks to Herman Varma for the above
 * Jason Chaffey              August 7, 2003
 *
  

   Version 2.42   
  
 * Bug in Manhattan distance calculation fixed. Returned to using it
 * for optimization.
 * Added fix for elements that cross International Dateline or
 * Greenwich Meridian in raybound.
 * Jason Chaffey              January 14, 2004
 *
  
   Version 2.5   
  
 * Fixed some problems with raybound for elements that cross International
 * Dateline or Greenwich Meridian in raybound. Problems became evident in the
 * global data set.
 * Jason Chaffey              June 16, 2008
 *
  
   Version 2.5.1   
  
 * Fixed a bug in raybound where triangle nodes were number 1-3 instead of
 * 0-2.
 * Jason Chaffey              November 29, 2010
 *
  
  
 * Windows Version produced by Charles LeBlanc (Environment Canada Atlantic)
 * 
 * Charles LeBlanc              August 20, 2011
 *
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ICSharpCode.SharpZipLib.Zip;
using System.Xml;

namespace AutoRunWebTide
{
    public partial class AutoRunWebTide : Form
    {
        #region Global Variables
        TidesAndCurrents tnc = new TidesAndCurrents(DateTime.Now, DateTime.Now.AddDays(7), -64.833849, 47.833140, 60, @"C:\CSSP\WebTide\data\nwatl\", true);

        public class DataFilePath
        {
            public DataFilePath()
            {

            }
            public string Name { get; set; }
            public string Path { get; set; }
        }
        List<DataFilePath> DataFilePathList;
        bool NeedToReload = true;
        #endregion Global Variables

        #region Constructors
        public AutoRunWebTide()
        {
            InitializeComponent();
            tnc.TidesAndCurrentsMessageEvent += new TidesAndCurrents.TidesAndCurrentsMessageEventHandler(tnc_TidesAndCurrentsMessageEvent);
            tnc.TidesAndCurrentStatusEvent += new TidesAndCurrents.TidesAndCurrentsStatusEventHandler(tnc_TidesAndCurrentStatusEvent);
            tnc.TidesAndCurrentErrorEvent += new TidesAndCurrents.TidesAndCurrentsErrorEventHandler(tnc_TidesAndCurrentErrorEvent);
        }
        #endregion Constructors

        #region Functions
        private bool CreateKML()
        {
            if (NeedToReload)
            {
                tnc.DataPath = (string)comboBoxFileLocation.SelectedValue;

                if (!tnc.LoadBase())
                    return false;
            }

            int LoopNumber = 0;
            int Count = 50000;
            while (true)
            {
                StringBuilder sbKML = new StringBuilder();
                WriteKMLTop(comboBoxFileLocation.SelectedValue + comboBoxFileLocation.Text + "_" + LoopNumber.ToString() + ".kml", sbKML);
                WriteKMLElement(sbKML, LoopNumber*Count, Count);
                WriteKMLBottom(sbKML);

                SaveInKMZFileStream(comboBoxFileLocation.SelectedValue + comboBoxFileLocation.Text + "_" + LoopNumber.ToString() + ".kmz", comboBoxFileLocation.SelectedValue + comboBoxFileLocation.Text + "_" + LoopNumber.ToString() + ".kml", sbKML);

                richTextBoxResults.Clear();

                MemoryStream ms = FileToMemoryStream(comboBoxFileLocation.SelectedValue + comboBoxFileLocation.Text + "_" + LoopNumber.ToString() + ".kmz");
                MemoryStream msUnzipped = KMZToKML(ms);
                msUnzipped.Position = 0;
                StreamReader sr = new StreamReader(msUnzipped);
                string TheFileTxt = sr.ReadToEnd();
                richTextBoxResults.AppendText(TheFileTxt);
                sr.Close();
                msUnzipped.Close();
                ms.Close();

                LoopNumber += 1;
                if (LoopNumber * Count > tnc.ElementList.Count)
                {
                    break;
                }
            }

            return true;
        }
        private MemoryStream FileToMemoryStream(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            MemoryStream myMemoryStream = new MemoryStream();
            if (!fi.Exists)
            {
                richTextBoxStatus.AppendText("File: \r\n\r\n[" + fileName + "] \r\n\r\ndoes not exist ... \r\n");
                return null;
            }
            richTextBoxStatus.AppendText("Reading file: \r\n\r\n [" + fileName + "] ... \r\n\r\n");
            FileStream myFileStream = fi.OpenRead();
            myFileStream.CopyTo(myMemoryStream);
            myFileStream.Flush();
            myMemoryStream.Position = 0;
            return myMemoryStream;
        }
        private MemoryStream KMZToKML(MemoryStream ms)
        {
            MemoryStream msUnzipped = new MemoryStream();
            try
            {
                using (ZipInputStream ZipStream = new ZipInputStream(ms))
                {
                    ZipEntry theEntry;
                    while ((theEntry = ZipStream.GetNextEntry()) != null) // should only have one for our KMZ files
                    {
                        if (theEntry.IsFile)
                        {
                            if (theEntry.Name != "")
                            {
                                int size = 2048;
                                byte[] data = new byte[2048];
                                while (true)
                                {
                                    size = ZipStream.Read(data, 0, data.Length);
                                    if (size > 0)
                                        msUnzipped.Write(data, 0, size);
                                    else
                                        break;
                                }
                            }
                        }
                    }
                    ZipStream.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return msUnzipped;
        }
        private void SaveInKMZFileStream(string KMZFileName, string KMLFileName, StringBuilder sbKML)
        {
            FileInfo fi = new FileInfo(KMZFileName);
            FileStream fs = fi.Create();
            ZipOutputStream zos = new ZipOutputStream(fs, sbKML.Length);
            byte[] zipByte = System.Text.Encoding.UTF8.GetBytes(sbKML.ToString());

            ZipEntry ze = new ZipEntry(KMLFileName);
            ze.DateTime = DateTime.Now;
            ze.Size = zipByte.Length;
            zos.PutNextEntry(ze);
            zos.SetLevel(3);
            zos.IsStreamOwner = true;
            zos.Write(zipByte, 0, sbKML.Length);
            zos.CloseEntry();
            zos.Flush();
            zos.Close();
            fs.Close();
        }
        private bool SaveMemoryInputToFile(string FileName)
        {
            FileInfo fiLocTimeFile = new FileInfo(FileName);

            StreamWriter sw = fiLocTimeFile.CreateText();

            foreach (TidesAndCurrents.InputAndResult IAR in tnc.InputAndResultList)
            {
                sw.WriteLine(string.Format("{0:F6} {1:F6} {2:yyyy MM dd HH mm ss}", IAR.Longitude, IAR.Latitude, IAR.Date));
            }

            sw.Close();

            return true;
        }
        private bool SaveResultToFile(string FileName)
        {
            FileInfo fiTideCorFile = new FileInfo(FileName);

            StreamWriter sw = fiTideCorFile.CreateText();

            // Loop through the memory input list
            foreach (TidesAndCurrents.InputAndResult IAR in tnc.InputAndResultList)
            {
                /* Ouput the tidal correction */
                if (tnc.WLTrueCurFalse)
                {
                    sw.WriteLine(string.Format("{0:F4} {1:F8} {2:F8} {3:yyyy} {3:MM} {3:dd} {3:HH} {3:mm} {3:ss}", IAR.Reslt, IAR.Longitude, IAR.Latitude, IAR.Date));
                }
                else
                {
                    sw.WriteLine(string.Format("{0:F4} {1:F4} {2:F8} {3:F8} {4:yyyy} {4:MM} {4:dd} {4:HH} {4:mm} {4:ss}", IAR.Reslt, IAR.Reslt2, IAR.Longitude, IAR.Latitude, IAR.Date));
                }

            }
            sw.Close();

            return true;
        }
        private void SetApplicationParams()
        {
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now.AddDays(7);

            // searching for files
            DirectoryInfo di = new DirectoryInfo(@"C:\CSSP\WebTide\data\");

            if (!di.Exists)
            {
                richTextBoxStatus.AppendText("The Application is searching for webtide appliation and data path.\r\n");
                richTextBoxStatus.AppendText(@"Searched in C:\CSSP\WebTide\data\" + "\r\n");
            }

            List<DirectoryInfo> dirs = di.GetDirectories().ToList<DirectoryInfo>();

            foreach (DirectoryInfo tdi in dirs)
            {
                if (!tdi.Name.StartsWith("."))
                {
                    switch (tdi.Name)
                    {
                        case "arctic9":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Artic", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "brador":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Bras d'Or Lake", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "flood":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Upper Fundy", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "h3o":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Halifax Harbour", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "HRglobal":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Global", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "hudson":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Hudson Bay", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "ne_pac4":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Northeast Pacific ", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "nwatl":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Northwest Atlantic", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "QuatsinoModel14":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Quatsino Sound", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "sshelf":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Scotia - Fundy - Maine", Path = tdi.FullName + "\\" });
                            }
                            break;
                        case "vigf8":
                            {
                                DataFilePathList.Add(new DataFilePath() { Name = "Vancouver Island", Path = tdi.FullName + "\\" });
                            }
                            break;
                        default:
                            break;
                    }
                    richTextBoxStatus.AppendText(string.Format("{0}\r\n", tdi.FullName));
                }
            }

            comboBoxFileLocation.ValueMember = "Path";
            comboBoxFileLocation.DisplayMember = "Name";
            comboBoxFileLocation.DataSource = DataFilePathList.OrderBy(n => n.Name).ToList();
            if (comboBoxFileLocation.Items.Count > 0)
            {
                comboBoxFileLocation.SelectedIndex = 0;
            }
            else
            {
                richTextBoxStatus.AppendText("Could not find any data for webtide.\r\n");
            }
        }
        private bool Start(bool NeedToReload)
        {
            tnc.StartDate = dateTimePickerStartDate.Value;
            tnc.EndDate = dateTimePickerEndDate.Value;
            tnc.Longitude = double.Parse(textBoxLongitude.Text);
            tnc.Latitude = double.Parse(textBoxLatitude.Text);
            tnc.Steps = double.Parse(textBoxSteps.Text);
            tnc.DataPath = (string)comboBoxFileLocation.SelectedValue;
            tnc.WLTrueCurFalse = radioButtonElevation.Checked;

            richTextBoxStatus.Text = "";
            richTextBoxStatus.AppendText("Starting TidesAndCurrents ...\r\n\r\n");
            richTextBoxStatus.AppendText("Parameters:\r\n");
            richTextBoxStatus.AppendText(string.Format("Start Date: {0: yyyy/MM/dd HH:mm:ss}\r\n", tnc.StartDate));
            richTextBoxStatus.AppendText(string.Format("End Date: {0: yyyy/MM/dd HH:mm:ss}\r\n", tnc.EndDate));
            richTextBoxStatus.AppendText(string.Format("Longitude: {0}\r\n", tnc.Longitude));
            richTextBoxStatus.AppendText(string.Format("Latitude: {0}\r\n", tnc.Latitude));
            richTextBoxStatus.AppendText(string.Format("Steps: {0}\r\n", tnc.Steps));
            richTextBoxStatus.AppendText(string.Format("Data Path: {0}\r\n", tnc.DataPath));
            richTextBoxStatus.AppendText(string.Format("Calculation for: {0}\r\n\r\n", (tnc.WLTrueCurFalse ? "Water Level" : "Currents")));

            if (!tnc.RunMain(NeedToReload))
                return false;

            if (checkBoxCreateInputFile.Checked)
            {
                if (!SaveMemoryInputToFile(textBoxCreateInputFilePath.Text))
                    return false;
            }

            if (checkBoxSaveResultsToFile.Checked)
            {
                if (!SaveResultToFile(textBoxSaveResultFilePath.Text))
                    return false;
            }

            this.NeedToReload = false;

            return true;
        }
        public void WriteKMLBottom(StringBuilder sbKML)
        {
            sbKML.AppendLine(@"</Document>");
            sbKML.AppendLine(@"</kml>");
        }
        public void WriteKMLTop(string DocName, StringBuilder sbKML)
        {
            sbKML.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
            sbKML.AppendLine(@"<kml xmlns=""http://www.opengis.net/kml/2.2"" xmlns:gx=""http://www.google.com/kml/ext/2.2"" xmlns:kml=""http://www.opengis.net/kml/2.2"" xmlns:atom=""http://www.w3.org/2005/Atom"">");
            sbKML.AppendLine(@"<Document>");
            sbKML.AppendLine(string.Format(@"<name>{0}</name>", DocName));
        }
        public void WriteKMLElement(StringBuilder sbKML, int StartElement, int Count)
        {
            sbKML.AppendLine(@"<Style id=""_line"">");
            sbKML.AppendLine("<LineStyle>");
            sbKML.AppendLine(@"<color>ff555555</color>");
            sbKML.AppendLine(@"<width>1</width>");
            sbKML.AppendLine("</LineStyle>");
            sbKML.AppendLine(@"</Style>");


            sbKML.AppendLine(@"<Folder><name>Mesh</name>");
            sbKML.AppendLine(@"<visibility>1</visibility>");
            int CurrentElement = 0;
            foreach (TidesAndCurrents.Element elem in tnc.ElementList)
            {
                CurrentElement += 1;
                if (CurrentElement >= StartElement && CurrentElement < (StartElement + Count))
                {
                    StringBuilder sbCoord = new StringBuilder();
                    string LastPart = "";
                    foreach (TidesAndCurrents.Node node in elem.NodeList)
                    {
                        if (LastPart == "")
                            LastPart = string.Format(@"{0},{1},0 ", node.x, node.y);

                        sbCoord.Append(string.Format(@"{0},{1},0 ", node.x, node.y));
                    }
                    sbCoord.Append(LastPart);

                    // Inserting the Placemark
                    sbKML.AppendLine(@"<Placemark>");
                    sbKML.AppendLine(@"<styleUrl>#_line</styleUrl>");
                    sbKML.AppendLine(@"<visibility>1</visibility>");
                    sbKML.AppendLine(@"<LineString>");
                    sbKML.AppendLine(@"<coordinates>");
                    sbKML.AppendLine(sbCoord.ToString());
                    sbKML.AppendLine(@"</coordinates>");
                    sbKML.AppendLine(@"</LineString>");
                    sbKML.AppendLine(@"</Placemark>");
                }
                if (CurrentElement >= (StartElement + Count))
                {
                    break;
                }
            }

            sbKML.AppendLine(@"</Folder>");
        }
        #endregion Functions

        #region Events
        private void AutoRunWebTide_Load(object sender, EventArgs e)
        {
            DataFilePathList = new List<DataFilePath>();
            SetApplicationParams();
        }
        private void butCancel_Click(object sender, EventArgs e)
        {
            tnc.Cancel = true;
            butStart.Enabled = true;
            panelParameters.Enabled = true;
            butCancel.Enabled = false;
        }
        private void butCreateKML_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            richTextBoxResults.Text = "";

            richTextBoxStatus.AppendText(string.Format("Creating file [{0}]\r\n\r\n", comboBoxFileLocation.SelectedValue + "element.kmz"));
            if (!CreateKML())
            {
                richTextBoxStatus.AppendText("Error while generating KMZ file.\r\n");
            }
            else
            {
                richTextBoxStatus.AppendText("Successfully completed.\r\n");
            }
        }
        private void butStart_Click(object sender, EventArgs e)
        {
            richTextBoxStatus.Text = "";
            richTextBoxResults.Text = "Working ...";
            lblStatusTxt.ForeColor = Color.Black;
            
            panelParameters.Enabled = false;
            butCancel.Enabled = true;
            butStart.Enabled = false;
            tnc.Cancel = false;

            if (Start(NeedToReload))
            {
                if (checkBoxShowResultInRTB.Checked)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.AppendLine(string.Format("Longitude\t{0:F8}\tLatitude\t{1:F8}", tnc.InputAndResultList[0].Longitude, tnc.InputAndResultList[0].Latitude));
                    sb.AppendLine();
                    if (tnc.WLTrueCurFalse)
                    {
                        sb.AppendLine("Date\tWater Level");
                    }
                    else
                    {
                        sb.AppendLine("Date\tU Velocity\tV Velocity");
                    }
                    foreach (TidesAndCurrents.InputAndResult mi in tnc.InputAndResultList)
                    {
                        if (tnc.WLTrueCurFalse)
                        {
                            sb.AppendLine(string.Format("{0:yyyy/MM/dd HH:mm:ss}\t{3:F4}", mi.Date, mi.Longitude, mi.Latitude, mi.Reslt));
                        }
                        else
                        {
                            sb.AppendLine(string.Format("{0:yyyy/MM/dd HH:mm:ss}\t{3:F4}\t{4:F4}", mi.Date, mi.Longitude, mi.Latitude, mi.Reslt, mi.Reslt2));
                        }
                    }

                    richTextBoxResults.Text = sb.ToString();

                }
            }
            panelParameters.Enabled = true;
            butCancel.Enabled = false;
            butStart.Enabled = true;
            tnc.Cancel = false;
            return;
        }
        private void checkBoxCreateInputFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCreateInputFile.Checked)
                textBoxCreateInputFilePath.Enabled = true;
            else
                textBoxCreateInputFilePath.Enabled = false;
        }
        private void checkBoxSaveResultsToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSaveResultsToFile.Checked)
                textBoxSaveResultFilePath.Enabled = true;
            else
                textBoxCreateInputFilePath.Enabled = false;
        }
        private void comboBoxFileLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeedToReload = true;

            if (comboBoxFileLocation.SelectedIndex >= 0)
            {
                textBoxCreateInputFilePath.Text = comboBoxFileLocation.SelectedValue + "Input.txt";
                textBoxSaveResultFilePath.Text = comboBoxFileLocation.SelectedValue + "Output.txt";
            }
            else
            {
                textBoxCreateInputFilePath.Text = "";
                textBoxSaveResultFilePath.Text = "";
            }
        }
        private void radioButtonCurrent_CheckedChanged(object sender, EventArgs e)
        {
            NeedToReload = true;

            if (radioButtonCurrent.Checked)
            {
                tnc.WLTrueCurFalse = false;
            }
        }
        private void radioButtonElevation_CheckedChanged(object sender, EventArgs e)
        {
            NeedToReload = true;

            if (radioButtonElevation.Checked)
            {
                tnc.WLTrueCurFalse = true;
            }
        }
        private void tnc_TidesAndCurrentErrorEvent(object sender, TidesAndCurrents.ErrorEventArgs e)
        {
            Application.DoEvents();
            lblStatusTxt.Text = e.Error;
            lblStatusTxt.ForeColor = Color.Red;
            richTextBoxStatus.AppendText(e.Error + "\r\n");
        }
        private void tnc_TidesAndCurrentsMessageEvent(object sender, TidesAndCurrents.MessageEventArgs e)
        {
            Application.DoEvents();
            richTextBoxStatus.AppendText(e.Message + "\r\n");
        }
        private void tnc_TidesAndCurrentStatusEvent(object sender, TidesAndCurrents.StatusEventArgs e)
        {
            Application.DoEvents();
            lblStatusTxt.Text = e.Status;
        }
        #endregion Events

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\CSSP\WebTide\data\vigf8\vigf8.nod");
            FileInfo fi2 = new FileInfo(@"C:\CSSP\vigf82.nod");

            StreamReader sr = fi.OpenText();
            StreamWriter sw = fi2.CreateText();

            while (!sr.EndOfStream)
            {
                int ID;
                float x;
                float y;
                string TheLine = sr.ReadLine();
                string[] vars = TheLine.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (vars.Count() == 3)
                {
                    ID = int.Parse(vars[0]);
                    x = float.Parse(vars[1]) - 360;
                    y = float.Parse(vars[2]);

                    sw.WriteLine(ID.ToString() + " " + x.ToString() + " " + y.ToString());
                }
                else
                {
                    int sef = 34;
                }
            }

            sr.Close();
            sw.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XmlReader reader = XmlReader.Create(new StringReader(richTextBoxGoogleEarthPoint.Text));
                while (reader.Read())
                {
                    if (reader.Name == "coordinates")
                    {
                        string AllCoordinates = reader.ReadElementContentAsString().Trim();

                        string[] xyzArray = AllCoordinates.Split(" ".ToCharArray()[0]);
                        foreach (string xyz in xyzArray)
                        {
                            string[] xyzStr = xyz.Split(",".ToCharArray()[0]);
                            if (xyzStr.Count() != 3)
                            {
                                return;
                            }
                            textBoxLongitude.Text = float.Parse(xyzStr[0]).ToString();
                            textBoxLatitude.Text = float.Parse(xyzStr[1]).ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Google Earth file could not be parsed correctly. Make sure you have a single pushpin." + ex.Message);
            }

        }

    }
}
