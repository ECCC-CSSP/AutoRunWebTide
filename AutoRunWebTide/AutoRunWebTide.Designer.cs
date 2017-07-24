namespace AutoRunWebTide
{
    partial class AutoRunWebTide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.lblGet = new System.Windows.Forms.Label();
            this.butCreateKML = new System.Windows.Forms.Button();
            this.radioButtonElevation = new System.Windows.Forms.RadioButton();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.radioButtonCurrent = new System.Windows.Forms.RadioButton();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.textBoxSaveResultFilePath = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxCreateInputFilePath = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.checkBoxShowResultInRTB = new System.Windows.Forms.CheckBox();
            this.lblStepsInMinutes = new System.Windows.Forms.Label();
            this.checkBoxSaveResultsToFile = new System.Windows.Forms.CheckBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.checkBoxCreateInputFile = new System.Windows.Forms.CheckBox();
            this.comboBoxFileLocation = new System.Windows.Forms.ComboBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelFullStatusTxt = new System.Windows.Forms.Panel();
            this.lblStatusTxt = new System.Windows.Forms.Label();
            this.panelLeftStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.panelCumulativeStatus = new System.Windows.Forms.Panel();
            this.lblCumulativeStatus = new System.Windows.Forms.Label();
            this.richTextBoxResults = new System.Windows.Forms.RichTextBox();
            this.panelResults = new System.Windows.Forms.Panel();
            this.lblResults = new System.Windows.Forms.Label();
            this.richTextBoxGoogleEarthPoint = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelParameters.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelFullStatusTxt.SuspendLayout();
            this.panelLeftStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelCumulativeStatus.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelParameters);
            this.splitContainer1.Panel1.Controls.Add(this.panelStatus);
            this.splitContainer1.Panel1.Controls.Add(this.butCancel);
            this.splitContainer1.Panel1.Controls.Add(this.butStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(983, 659);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 6;
            // 
            // panelParameters
            // 
            this.panelParameters.Controls.Add(this.label2);
            this.panelParameters.Controls.Add(this.button2);
            this.panelParameters.Controls.Add(this.label1);
            this.panelParameters.Controls.Add(this.richTextBoxGoogleEarthPoint);
            this.panelParameters.Controls.Add(this.button1);
            this.panelParameters.Controls.Add(this.lblDataPath);
            this.panelParameters.Controls.Add(this.lblGet);
            this.panelParameters.Controls.Add(this.butCreateKML);
            this.panelParameters.Controls.Add(this.radioButtonElevation);
            this.panelParameters.Controls.Add(this.textBoxLatitude);
            this.panelParameters.Controls.Add(this.radioButtonCurrent);
            this.panelParameters.Controls.Add(this.lblLatitude);
            this.panelParameters.Controls.Add(this.textBoxSaveResultFilePath);
            this.panelParameters.Controls.Add(this.textBoxLongitude);
            this.panelParameters.Controls.Add(this.textBoxCreateInputFilePath);
            this.panelParameters.Controls.Add(this.lblLongitude);
            this.panelParameters.Controls.Add(this.dateTimePickerEndDate);
            this.panelParameters.Controls.Add(this.textBoxSteps);
            this.panelParameters.Controls.Add(this.dateTimePickerStartDate);
            this.panelParameters.Controls.Add(this.lblStartDate);
            this.panelParameters.Controls.Add(this.lblEndDate);
            this.panelParameters.Controls.Add(this.checkBoxShowResultInRTB);
            this.panelParameters.Controls.Add(this.lblStepsInMinutes);
            this.panelParameters.Controls.Add(this.checkBoxSaveResultsToFile);
            this.panelParameters.Controls.Add(this.lblMinutes);
            this.panelParameters.Controls.Add(this.checkBoxCreateInputFile);
            this.panelParameters.Controls.Add(this.comboBoxFileLocation);
            this.panelParameters.Location = new System.Drawing.Point(109, 9);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(871, 182);
            this.panelParameters.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(702, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Fix Vancouver Island Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Location = new System.Drawing.Point(18, 14);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(58, 13);
            this.lblDataPath.TabIndex = 2;
            this.lblDataPath.Text = "Data Path:";
            // 
            // lblGet
            // 
            this.lblGet.AutoSize = true;
            this.lblGet.Location = new System.Drawing.Point(47, 147);
            this.lblGet.Name = "lblGet";
            this.lblGet.Size = new System.Drawing.Size(27, 13);
            this.lblGet.TabIndex = 16;
            this.lblGet.Text = "Get:";
            // 
            // butCreateKML
            // 
            this.butCreateKML.Location = new System.Drawing.Point(770, 69);
            this.butCreateKML.Name = "butCreateKML";
            this.butCreateKML.Size = new System.Drawing.Size(90, 25);
            this.butCreateKML.TabIndex = 0;
            this.butCreateKML.Text = "Create KML";
            this.butCreateKML.UseVisualStyleBackColor = true;
            this.butCreateKML.Click += new System.EventHandler(this.butCreateKML_Click);
            // 
            // radioButtonElevation
            // 
            this.radioButtonElevation.AutoSize = true;
            this.radioButtonElevation.Checked = true;
            this.radioButtonElevation.Location = new System.Drawing.Point(77, 145);
            this.radioButtonElevation.Name = "radioButtonElevation";
            this.radioButtonElevation.Size = new System.Drawing.Size(69, 17);
            this.radioButtonElevation.TabIndex = 6;
            this.radioButtonElevation.TabStop = true;
            this.radioButtonElevation.Text = "Elevation";
            this.radioButtonElevation.UseVisualStyleBackColor = true;
            this.radioButtonElevation.CheckedChanged += new System.EventHandler(this.radioButtonElevation_CheckedChanged);
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(77, 37);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(67, 20);
            this.textBoxLatitude.TabIndex = 3;
            this.textBoxLatitude.Text = "47.833140";
            // 
            // radioButtonCurrent
            // 
            this.radioButtonCurrent.AutoSize = true;
            this.radioButtonCurrent.Location = new System.Drawing.Point(152, 145);
            this.radioButtonCurrent.Name = "radioButtonCurrent";
            this.radioButtonCurrent.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCurrent.TabIndex = 6;
            this.radioButtonCurrent.Text = "Current";
            this.radioButtonCurrent.UseVisualStyleBackColor = true;
            this.radioButtonCurrent.CheckedChanged += new System.EventHandler(this.radioButtonCurrent_CheckedChanged);
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(26, 40);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(48, 13);
            this.lblLatitude.TabIndex = 4;
            this.lblLatitude.Text = "Latitude:";
            // 
            // textBoxSaveResultFilePath
            // 
            this.textBoxSaveResultFilePath.Enabled = false;
            this.textBoxSaveResultFilePath.Location = new System.Drawing.Point(455, 37);
            this.textBoxSaveResultFilePath.Name = "textBoxSaveResultFilePath";
            this.textBoxSaveResultFilePath.Size = new System.Drawing.Size(405, 20);
            this.textBoxSaveResultFilePath.TabIndex = 15;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(214, 37);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(72, 20);
            this.textBoxLongitude.TabIndex = 3;
            this.textBoxLongitude.Text = "-64.833849";
            // 
            // textBoxCreateInputFilePath
            // 
            this.textBoxCreateInputFilePath.Enabled = false;
            this.textBoxCreateInputFilePath.Location = new System.Drawing.Point(455, 12);
            this.textBoxCreateInputFilePath.Name = "textBoxCreateInputFilePath";
            this.textBoxCreateInputFilePath.Size = new System.Drawing.Size(405, 20);
            this.textBoxCreateInputFilePath.TabIndex = 15;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(151, 40);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblLongitude.TabIndex = 4;
            this.lblLongitude.Text = "Longitude:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(77, 93);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerEndDate.TabIndex = 14;
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(77, 119);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(48, 20);
            this.textBoxSteps.TabIndex = 3;
            this.textBoxSteps.Text = "60";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(77, 67);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerStartDate.TabIndex = 13;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(16, 73);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(19, 99);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // checkBoxShowResultInRTB
            // 
            this.checkBoxShowResultInRTB.AutoSize = true;
            this.checkBoxShowResultInRTB.Checked = true;
            this.checkBoxShowResultInRTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowResultInRTB.Location = new System.Drawing.Point(332, 69);
            this.checkBoxShowResultInRTB.Name = "checkBoxShowResultInRTB";
            this.checkBoxShowResultInRTB.Size = new System.Drawing.Size(205, 17);
            this.checkBoxShowResultInRTB.TabIndex = 11;
            this.checkBoxShowResultInRTB.Text = "Show Result in Results Rich Text Box";
            this.checkBoxShowResultInRTB.UseVisualStyleBackColor = true;
            // 
            // lblStepsInMinutes
            // 
            this.lblStepsInMinutes.AutoSize = true;
            this.lblStepsInMinutes.Location = new System.Drawing.Point(37, 122);
            this.lblStepsInMinutes.Name = "lblStepsInMinutes";
            this.lblStepsInMinutes.Size = new System.Drawing.Size(37, 13);
            this.lblStepsInMinutes.TabIndex = 5;
            this.lblStepsInMinutes.Text = "Every:";
            // 
            // checkBoxSaveResultsToFile
            // 
            this.checkBoxSaveResultsToFile.AutoSize = true;
            this.checkBoxSaveResultsToFile.Location = new System.Drawing.Point(332, 40);
            this.checkBoxSaveResultsToFile.Name = "checkBoxSaveResultsToFile";
            this.checkBoxSaveResultsToFile.Size = new System.Drawing.Size(119, 17);
            this.checkBoxSaveResultsToFile.TabIndex = 11;
            this.checkBoxSaveResultsToFile.Text = "Save Result To File";
            this.checkBoxSaveResultsToFile.UseVisualStyleBackColor = true;
            this.checkBoxSaveResultsToFile.CheckedChanged += new System.EventHandler(this.checkBoxSaveResultsToFile_CheckedChanged);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(137, 122);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 5;
            this.lblMinutes.Text = "Minutes";
            // 
            // checkBoxCreateInputFile
            // 
            this.checkBoxCreateInputFile.AutoSize = true;
            this.checkBoxCreateInputFile.Location = new System.Drawing.Point(332, 13);
            this.checkBoxCreateInputFile.Name = "checkBoxCreateInputFile";
            this.checkBoxCreateInputFile.Size = new System.Drawing.Size(103, 17);
            this.checkBoxCreateInputFile.TabIndex = 11;
            this.checkBoxCreateInputFile.Text = "Create Input File";
            this.checkBoxCreateInputFile.UseVisualStyleBackColor = true;
            this.checkBoxCreateInputFile.CheckedChanged += new System.EventHandler(this.checkBoxCreateInputFile_CheckedChanged);
            // 
            // comboBoxFileLocation
            // 
            this.comboBoxFileLocation.FormattingEnabled = true;
            this.comboBoxFileLocation.Location = new System.Drawing.Point(77, 9);
            this.comboBoxFileLocation.Name = "comboBoxFileLocation";
            this.comboBoxFileLocation.Size = new System.Drawing.Size(235, 21);
            this.comboBoxFileLocation.TabIndex = 8;
            this.comboBoxFileLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileLocation_SelectedIndexChanged);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.panelFullStatusTxt);
            this.panelStatus.Controls.Add(this.panelLeftStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 190);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(983, 21);
            this.panelStatus.TabIndex = 12;
            // 
            // panelFullStatusTxt
            // 
            this.panelFullStatusTxt.Controls.Add(this.lblStatusTxt);
            this.panelFullStatusTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFullStatusTxt.Location = new System.Drawing.Point(61, 0);
            this.panelFullStatusTxt.Name = "panelFullStatusTxt";
            this.panelFullStatusTxt.Size = new System.Drawing.Size(922, 21);
            this.panelFullStatusTxt.TabIndex = 12;
            // 
            // lblStatusTxt
            // 
            this.lblStatusTxt.Location = new System.Drawing.Point(2, 4);
            this.lblStatusTxt.Name = "lblStatusTxt";
            this.lblStatusTxt.Size = new System.Drawing.Size(600, 13);
            this.lblStatusTxt.TabIndex = 10;
            // 
            // panelLeftStatus
            // 
            this.panelLeftStatus.Controls.Add(this.lblStatus);
            this.panelLeftStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftStatus.Location = new System.Drawing.Point(0, 0);
            this.panelLeftStatus.Name = "panelLeftStatus";
            this.panelLeftStatus.Size = new System.Drawing.Size(61, 21);
            this.panelLeftStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // butCancel
            // 
            this.butCancel.Enabled = false;
            this.butCancel.Location = new System.Drawing.Point(13, 39);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(90, 25);
            this.butCancel.TabIndex = 0;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(13, 9);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(90, 25);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.richTextBoxStatus);
            this.splitContainer2.Panel1.Controls.Add(this.panelCumulativeStatus);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBoxResults);
            this.splitContainer2.Panel2.Controls.Add(this.panelResults);
            this.splitContainer2.Size = new System.Drawing.Size(983, 444);
            this.splitContainer2.SplitterDistance = 472;
            this.splitContainer2.TabIndex = 5;
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxStatus.Location = new System.Drawing.Point(0, 21);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(468, 419);
            this.richTextBoxStatus.TabIndex = 4;
            this.richTextBoxStatus.Text = "";
            // 
            // panelCumulativeStatus
            // 
            this.panelCumulativeStatus.Controls.Add(this.lblCumulativeStatus);
            this.panelCumulativeStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCumulativeStatus.Location = new System.Drawing.Point(0, 0);
            this.panelCumulativeStatus.Name = "panelCumulativeStatus";
            this.panelCumulativeStatus.Size = new System.Drawing.Size(468, 21);
            this.panelCumulativeStatus.TabIndex = 1;
            // 
            // lblCumulativeStatus
            // 
            this.lblCumulativeStatus.AutoSize = true;
            this.lblCumulativeStatus.Location = new System.Drawing.Point(6, 4);
            this.lblCumulativeStatus.Name = "lblCumulativeStatus";
            this.lblCumulativeStatus.Size = new System.Drawing.Size(95, 13);
            this.lblCumulativeStatus.TabIndex = 0;
            this.lblCumulativeStatus.Text = "Cumulative Status:";
            // 
            // richTextBoxResults
            // 
            this.richTextBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResults.Location = new System.Drawing.Point(0, 21);
            this.richTextBoxResults.Name = "richTextBoxResults";
            this.richTextBoxResults.Size = new System.Drawing.Size(503, 419);
            this.richTextBoxResults.TabIndex = 0;
            this.richTextBoxResults.Text = "";
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.lblResults);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResults.Location = new System.Drawing.Point(0, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(503, 21);
            this.panelResults.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(9, 4);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(45, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results:";
            // 
            // richTextBoxGoogleEarthPoint
            // 
            this.richTextBoxGoogleEarthPoint.Location = new System.Drawing.Point(332, 132);
            this.richTextBoxGoogleEarthPoint.Name = "richTextBoxGoogleEarthPoint";
            this.richTextBoxGoogleEarthPoint.Size = new System.Drawing.Size(245, 47);
            this.richTextBoxGoogleEarthPoint.TabIndex = 18;
            this.richTextBoxGoogleEarthPoint.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copy Google Earth Point in the box below and then";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Get Coordinate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Copy (ctrl + c) Paste (ctrl + v)";
            // 
            // AutoRunWebTide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 659);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AutoRunWebTide";
            this.Text = "AutoRunWebTide Application";
            this.Load += new System.EventHandler(this.AutoRunWebTide_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelFullStatusTxt.ResumeLayout(false);
            this.panelLeftStatus.ResumeLayout(false);
            this.panelLeftStatus.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelCumulativeStatus.ResumeLayout(false);
            this.panelCumulativeStatus.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxFileLocation;
        private System.Windows.Forms.RadioButton radioButtonElevation;
        private System.Windows.Forms.RadioButton radioButtonCurrent;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblStepsInMinutes;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.Label lblDataPath;
        private System.Windows.Forms.Button butCreateKML;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Label lblStatusTxt;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkBoxCreateInputFile;
        private System.Windows.Forms.CheckBox checkBoxSaveResultsToFile;
        private System.Windows.Forms.CheckBox checkBoxShowResultInRTB;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panelCumulativeStatus;
        private System.Windows.Forms.Label lblCumulativeStatus;
        private System.Windows.Forms.RichTextBox richTextBoxResults;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox textBoxSaveResultFilePath;
        private System.Windows.Forms.TextBox textBoxCreateInputFilePath;
        private System.Windows.Forms.Label lblGet;
        private System.Windows.Forms.Panel panelFullStatusTxt;
        private System.Windows.Forms.Panel panelLeftStatus;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxGoogleEarthPoint;
        private System.Windows.Forms.Label label2;
    }
}

