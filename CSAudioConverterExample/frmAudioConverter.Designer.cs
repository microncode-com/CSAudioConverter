namespace CSAudioConverterExample
{
    partial class frmAudioConverter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioConverter));
            this.prgCurrentProgress = new System.Windows.Forms.ProgressBar();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdResume = new System.Windows.Forms.Button();
            this.cmdPause = new System.Windows.Forms.Button();
            this.lblDecodeMode = new System.Windows.Forms.Label();
            this.cboDecodeMode = new System.Windows.Forms.ComboBox();
            this.lblDestinationFormat = new System.Windows.Forms.Label();
            this.cboDestinationFormat = new System.Windows.Forms.ComboBox();
            this.cboChannels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBits = new System.Windows.Forms.Label();
            this.cboBits = new System.Windows.Forms.ComboBox();
            this.lblSamplerate = new System.Windows.Forms.Label();
            this.cboSamplerate = new System.Windows.Forms.ComboBox();
            this.lblBitrate = new System.Windows.Forms.Label();
            this.cboBitrate = new System.Windows.Forms.ComboBox();
            this.txtSourceMediaFile1 = new System.Windows.Forms.TextBox();
            this.lblSourceMediaFile1 = new System.Windows.Forms.Label();
            this.lblFrom1 = new System.Windows.Forms.Label();
            this.lblTo1 = new System.Windows.Forms.Label();
            this.lblTo2 = new System.Windows.Forms.Label();
            this.lblFrom2 = new System.Windows.Forms.Label();
            this.lblSourceMediaFile2 = new System.Windows.Forms.Label();
            this.txtSourceMediaFile2 = new System.Windows.Forms.TextBox();
            this.lblCurrentProgress = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdSelectMediaFile1 = new System.Windows.Forms.Button();
            this.cmdSelectMediaFile2 = new System.Windows.Forms.Button();
            this.cmdOpenFileLocation = new System.Windows.Forms.Button();
            this.cmdPlayWithDefaultPlayer = new System.Windows.Forms.Button();
            this.cmdCheckLicense = new System.Windows.Forms.Button();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.timeTo2 = new System.Windows.Forms.DateTimePicker();
            this.timeFrom2 = new System.Windows.Forms.DateTimePicker();
            this.timeTo1 = new System.Windows.Forms.DateTimePicker();
            this.timeFrom1 = new System.Windows.Forms.DateTimePicker();
            this.grpDestination = new System.Windows.Forms.GroupBox();
            this.grpID3Tags = new System.Windows.Forms.GroupBox();
            this.lblTagComment = new System.Windows.Forms.Label();
            this.txtTagTitle = new System.Windows.Forms.TextBox();
            this.lblTagTrackNum = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.txtTagTrackNum = new System.Windows.Forms.TextBox();
            this.txtTagYear = new System.Windows.Forms.TextBox();
            this.lblTagCopyright = new System.Windows.Forms.Label();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.txtTagCopyright = new System.Windows.Forms.TextBox();
            this.txtTagComment = new System.Windows.Forms.TextBox();
            this.lblTagAlbum = new System.Windows.Forms.Label();
            this.txtTagAlbum = new System.Windows.Forms.TextBox();
            this.grpProgress = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboACMFormats = new System.Windows.Forms.ComboBox();
            this.lblACMFormats = new System.Windows.Forms.Label();
            this.cboACMTags = new System.Windows.Forms.ComboBox();
            this.lblACMTag = new System.Windows.Forms.Label();
            this.pnlACM = new System.Windows.Forms.Panel();
            this.lblDestinationFile = new System.Windows.Forms.Label();
            this.grpDestinationFile = new System.Windows.Forms.GroupBox();
            this.cmdID3Tags = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.audioConverter1 = new CSAudioConverter.AudioConverter();
            this.grpSource.SuspendLayout();
            this.grpDestination.SuspendLayout();
            this.grpID3Tags.SuspendLayout();
            this.grpProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlACM.SuspendLayout();
            this.grpDestinationFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // prgCurrentProgress
            // 
            this.prgCurrentProgress.Location = new System.Drawing.Point(20, 43);
            this.prgCurrentProgress.Name = "prgCurrentProgress";
            this.prgCurrentProgress.Size = new System.Drawing.Size(750, 23);
            this.prgCurrentProgress.TabIndex = 6;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(352, 618);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(92, 23);
            this.cmdCancel.TabIndex = 26;
            this.cmdCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.cmdCancel, "Cancel the progress.");
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdConvert
            // 
            this.cmdConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdConvert.Location = new System.Drawing.Point(17, 618);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(167, 23);
            this.cmdConvert.TabIndex = 22;
            this.cmdConvert.Text = "Convert / Join";
            this.toolTip1.SetToolTip(this.cmdConvert, "Convert and join.");
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // cmdResume
            // 
            this.cmdResume.Location = new System.Drawing.Point(271, 618);
            this.cmdResume.Name = "cmdResume";
            this.cmdResume.Size = new System.Drawing.Size(75, 23);
            this.cmdResume.TabIndex = 25;
            this.cmdResume.Text = "Resume";
            this.toolTip1.SetToolTip(this.cmdResume, "Resume the progress.");
            this.cmdResume.UseVisualStyleBackColor = true;
            this.cmdResume.Click += new System.EventHandler(this.cmdResume_Click);
            // 
            // cmdPause
            // 
            this.cmdPause.Location = new System.Drawing.Point(190, 618);
            this.cmdPause.Name = "cmdPause";
            this.cmdPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPause.TabIndex = 24;
            this.cmdPause.Text = "Pause";
            this.toolTip1.SetToolTip(this.cmdPause, "Pause the entry progress.");
            this.cmdPause.UseVisualStyleBackColor = true;
            this.cmdPause.Click += new System.EventHandler(this.cmdPause_Click);
            // 
            // lblDecodeMode
            // 
            this.lblDecodeMode.AutoSize = true;
            this.lblDecodeMode.Location = new System.Drawing.Point(211, 28);
            this.lblDecodeMode.Name = "lblDecodeMode";
            this.lblDecodeMode.Size = new System.Drawing.Size(78, 13);
            this.lblDecodeMode.TabIndex = 41;
            this.lblDecodeMode.Text = "Decoder Mode";
            // 
            // cboDecodeMode
            // 
            this.cboDecodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDecodeMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDecodeMode.FormattingEnabled = true;
            this.cboDecodeMode.Location = new System.Drawing.Point(214, 44);
            this.cboDecodeMode.Name = "cboDecodeMode";
            this.cboDecodeMode.Size = new System.Drawing.Size(188, 21);
            this.cboDecodeMode.TabIndex = 9;
            // 
            // lblDestinationFormat
            // 
            this.lblDestinationFormat.AutoSize = true;
            this.lblDestinationFormat.Location = new System.Drawing.Point(17, 28);
            this.lblDestinationFormat.Name = "lblDestinationFormat";
            this.lblDestinationFormat.Size = new System.Drawing.Size(95, 13);
            this.lblDestinationFormat.TabIndex = 39;
            this.lblDestinationFormat.Text = "Destination Format";
            // 
            // cboDestinationFormat
            // 
            this.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestinationFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDestinationFormat.FormattingEnabled = true;
            this.cboDestinationFormat.Location = new System.Drawing.Point(20, 44);
            this.cboDestinationFormat.Name = "cboDestinationFormat";
            this.cboDestinationFormat.Size = new System.Drawing.Size(188, 21);
            this.cboDestinationFormat.TabIndex = 8;
            this.cboDestinationFormat.SelectedIndexChanged += new System.EventHandler(this.cboDetinationFormat_SelectedIndexChanged);
            // 
            // cboChannels
            // 
            this.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChannels.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboChannels.FormattingEnabled = true;
            this.cboChannels.Location = new System.Drawing.Point(214, 99);
            this.cboChannels.Name = "cboChannels";
            this.cboChannels.Size = new System.Drawing.Size(91, 21);
            this.cboChannels.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Channels";
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Location = new System.Drawing.Point(308, 82);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(49, 13);
            this.lblBits.TabIndex = 35;
            this.lblBits.Text = "Bit depth";
            // 
            // cboBits
            // 
            this.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBits.FormattingEnabled = true;
            this.cboBits.Location = new System.Drawing.Point(311, 98);
            this.cboBits.Name = "cboBits";
            this.cboBits.Size = new System.Drawing.Size(91, 21);
            this.cboBits.TabIndex = 13;
            // 
            // lblSamplerate
            // 
            this.lblSamplerate.AutoSize = true;
            this.lblSamplerate.Location = new System.Drawing.Point(114, 83);
            this.lblSamplerate.Name = "lblSamplerate";
            this.lblSamplerate.Size = new System.Drawing.Size(60, 13);
            this.lblSamplerate.TabIndex = 33;
            this.lblSamplerate.Text = "Samplerate";
            // 
            // cboSamplerate
            // 
            this.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSamplerate.FormattingEnabled = true;
            this.cboSamplerate.Location = new System.Drawing.Point(117, 99);
            this.cboSamplerate.Name = "cboSamplerate";
            this.cboSamplerate.Size = new System.Drawing.Size(91, 21);
            this.cboSamplerate.TabIndex = 11;
            // 
            // lblBitrate
            // 
            this.lblBitrate.AutoSize = true;
            this.lblBitrate.Location = new System.Drawing.Point(17, 83);
            this.lblBitrate.Name = "lblBitrate";
            this.lblBitrate.Size = new System.Drawing.Size(37, 13);
            this.lblBitrate.TabIndex = 31;
            this.lblBitrate.Text = "Bitrate";
            // 
            // cboBitrate
            // 
            this.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitrate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBitrate.FormattingEnabled = true;
            this.cboBitrate.Location = new System.Drawing.Point(20, 99);
            this.cboBitrate.Name = "cboBitrate";
            this.cboBitrate.Size = new System.Drawing.Size(91, 21);
            this.cboBitrate.TabIndex = 10;
            // 
            // txtSourceMediaFile1
            // 
            this.txtSourceMediaFile1.Location = new System.Drawing.Point(20, 39);
            this.txtSourceMediaFile1.Multiline = true;
            this.txtSourceMediaFile1.Name = "txtSourceMediaFile1";
            this.txtSourceMediaFile1.Size = new System.Drawing.Size(421, 50);
            this.txtSourceMediaFile1.TabIndex = 0;
            // 
            // lblSourceMediaFile1
            // 
            this.lblSourceMediaFile1.AutoSize = true;
            this.lblSourceMediaFile1.Location = new System.Drawing.Point(17, 23);
            this.lblSourceMediaFile1.Name = "lblSourceMediaFile1";
            this.lblSourceMediaFile1.Size = new System.Drawing.Size(101, 13);
            this.lblSourceMediaFile1.TabIndex = 44;
            this.lblSourceMediaFile1.Text = "Source Media File 1";
            // 
            // lblFrom1
            // 
            this.lblFrom1.AutoSize = true;
            this.lblFrom1.Location = new System.Drawing.Point(544, 23);
            this.lblFrom1.Name = "lblFrom1";
            this.lblFrom1.Size = new System.Drawing.Size(30, 13);
            this.lblFrom1.TabIndex = 47;
            this.lblFrom1.Text = "From";
            // 
            // lblTo1
            // 
            this.lblTo1.AutoSize = true;
            this.lblTo1.Location = new System.Drawing.Point(660, 23);
            this.lblTo1.Name = "lblTo1";
            this.lblTo1.Size = new System.Drawing.Size(20, 13);
            this.lblTo1.TabIndex = 48;
            this.lblTo1.Text = "To";
            // 
            // lblTo2
            // 
            this.lblTo2.AutoSize = true;
            this.lblTo2.Location = new System.Drawing.Point(660, 106);
            this.lblTo2.Name = "lblTo2";
            this.lblTo2.Size = new System.Drawing.Size(20, 13);
            this.lblTo2.TabIndex = 54;
            this.lblTo2.Text = "To";
            // 
            // lblFrom2
            // 
            this.lblFrom2.AutoSize = true;
            this.lblFrom2.Location = new System.Drawing.Point(544, 106);
            this.lblFrom2.Name = "lblFrom2";
            this.lblFrom2.Size = new System.Drawing.Size(30, 13);
            this.lblFrom2.TabIndex = 53;
            this.lblFrom2.Text = "From";
            // 
            // lblSourceMediaFile2
            // 
            this.lblSourceMediaFile2.AutoSize = true;
            this.lblSourceMediaFile2.Location = new System.Drawing.Point(17, 106);
            this.lblSourceMediaFile2.Name = "lblSourceMediaFile2";
            this.lblSourceMediaFile2.Size = new System.Drawing.Size(141, 13);
            this.lblSourceMediaFile2.TabIndex = 50;
            this.lblSourceMediaFile2.Text = "Source Media File 2 (for join)";
            // 
            // txtSourceMediaFile2
            // 
            this.txtSourceMediaFile2.Location = new System.Drawing.Point(20, 122);
            this.txtSourceMediaFile2.Multiline = true;
            this.txtSourceMediaFile2.Name = "txtSourceMediaFile2";
            this.txtSourceMediaFile2.Size = new System.Drawing.Size(421, 50);
            this.txtSourceMediaFile2.TabIndex = 4;
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Location = new System.Drawing.Point(17, 27);
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentProgress.TabIndex = 55;
            this.lblCurrentProgress.Text = "Ready.";
            // 
            // cmdSelectMediaFile1
            // 
            this.cmdSelectMediaFile1.Location = new System.Drawing.Point(447, 39);
            this.cmdSelectMediaFile1.Name = "cmdSelectMediaFile1";
            this.cmdSelectMediaFile1.Size = new System.Drawing.Size(75, 20);
            this.cmdSelectMediaFile1.TabIndex = 1;
            this.cmdSelectMediaFile1.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectMediaFile1, "Select the source mdia file 1.");
            this.cmdSelectMediaFile1.UseVisualStyleBackColor = true;
            this.cmdSelectMediaFile1.Click += new System.EventHandler(this.cmdSelectMediaFile1_Click);
            // 
            // cmdSelectMediaFile2
            // 
            this.cmdSelectMediaFile2.Location = new System.Drawing.Point(447, 121);
            this.cmdSelectMediaFile2.Name = "cmdSelectMediaFile2";
            this.cmdSelectMediaFile2.Size = new System.Drawing.Size(75, 21);
            this.cmdSelectMediaFile2.TabIndex = 5;
            this.cmdSelectMediaFile2.Text = "...";
            this.toolTip1.SetToolTip(this.cmdSelectMediaFile2, "Select the source mdia file 2.");
            this.cmdSelectMediaFile2.UseVisualStyleBackColor = true;
            this.cmdSelectMediaFile2.Click += new System.EventHandler(this.cmdSelectMediaFile2_Click);
            // 
            // cmdOpenFileLocation
            // 
            this.cmdOpenFileLocation.Location = new System.Drawing.Point(625, 24);
            this.cmdOpenFileLocation.Name = "cmdOpenFileLocation";
            this.cmdOpenFileLocation.Size = new System.Drawing.Size(145, 23);
            this.cmdOpenFileLocation.TabIndex = 21;
            this.cmdOpenFileLocation.Text = "Open file Location";
            this.toolTip1.SetToolTip(this.cmdOpenFileLocation, "Open file Location.");
            this.cmdOpenFileLocation.UseVisualStyleBackColor = true;
            this.cmdOpenFileLocation.Click += new System.EventHandler(this.cmdOpenFileLocation_Click);
            // 
            // cmdPlayWithDefaultPlayer
            // 
            this.cmdPlayWithDefaultPlayer.Location = new System.Drawing.Point(545, 24);
            this.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer";
            this.cmdPlayWithDefaultPlayer.Size = new System.Drawing.Size(74, 23);
            this.cmdPlayWithDefaultPlayer.TabIndex = 20;
            this.cmdPlayWithDefaultPlayer.Text = "Play";
            this.toolTip1.SetToolTip(this.cmdPlayWithDefaultPlayer, "Playe with the default system player.");
            this.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = true;
            this.cmdPlayWithDefaultPlayer.Click += new System.EventHandler(this.cmdPlayWithDefaultPlayer_Click);
            // 
            // cmdCheckLicense
            // 
            this.cmdCheckLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdCheckLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdCheckLicense.Image")));
            this.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCheckLicense.Location = new System.Drawing.Point(642, 618);
            this.cmdCheckLicense.Name = "cmdCheckLicense";
            this.cmdCheckLicense.Size = new System.Drawing.Size(168, 23);
            this.cmdCheckLicense.TabIndex = 77;
            this.cmdCheckLicense.Text = "Order a license online";
            this.toolTip1.SetToolTip(this.cmdCheckLicense, "Order a license online");
            this.cmdCheckLicense.UseVisualStyleBackColor = true;
            this.cmdCheckLicense.Click += new System.EventHandler(this.cmdCheckLicense_Click);
            // 
            // grpSource
            // 
            this.grpSource.BackColor = System.Drawing.SystemColors.Control;
            this.grpSource.Controls.Add(this.timeTo2);
            this.grpSource.Controls.Add(this.timeFrom2);
            this.grpSource.Controls.Add(this.timeTo1);
            this.grpSource.Controls.Add(this.timeFrom1);
            this.grpSource.Controls.Add(this.txtSourceMediaFile2);
            this.grpSource.Controls.Add(this.cmdSelectMediaFile2);
            this.grpSource.Controls.Add(this.txtSourceMediaFile1);
            this.grpSource.Controls.Add(this.cmdSelectMediaFile1);
            this.grpSource.Controls.Add(this.lblSourceMediaFile1);
            this.grpSource.Controls.Add(this.lblFrom1);
            this.grpSource.Controls.Add(this.lblTo1);
            this.grpSource.Controls.Add(this.lblTo2);
            this.grpSource.Controls.Add(this.lblSourceMediaFile2);
            this.grpSource.Controls.Add(this.lblFrom2);
            this.grpSource.Location = new System.Drawing.Point(17, 75);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(793, 191);
            this.grpSource.TabIndex = 61;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source";
            // 
            // timeTo2
            // 
            this.timeTo2.CustomFormat = "HH:mm:ss";
            this.timeTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo2.Location = new System.Drawing.Point(663, 122);
            this.timeTo2.Name = "timeTo2";
            this.timeTo2.ShowUpDown = true;
            this.timeTo2.Size = new System.Drawing.Size(109, 20);
            this.timeTo2.TabIndex = 7;
            this.timeTo2.Value = new System.DateTime(2018, 12, 29, 0, 0, 0, 0);
            // 
            // timeFrom2
            // 
            this.timeFrom2.CustomFormat = "HH:mm:ss";
            this.timeFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom2.Location = new System.Drawing.Point(547, 122);
            this.timeFrom2.Name = "timeFrom2";
            this.timeFrom2.ShowUpDown = true;
            this.timeFrom2.Size = new System.Drawing.Size(109, 20);
            this.timeFrom2.TabIndex = 6;
            this.timeFrom2.Value = new System.DateTime(2018, 12, 29, 0, 0, 0, 0);
            // 
            // timeTo1
            // 
            this.timeTo1.CustomFormat = "HH:mm:ss";
            this.timeTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo1.Location = new System.Drawing.Point(663, 39);
            this.timeTo1.Name = "timeTo1";
            this.timeTo1.ShowUpDown = true;
            this.timeTo1.Size = new System.Drawing.Size(109, 20);
            this.timeTo1.TabIndex = 3;
            this.timeTo1.Value = new System.DateTime(2018, 12, 29, 0, 0, 0, 0);
            // 
            // timeFrom1
            // 
            this.timeFrom1.CustomFormat = "HH:mm:ss";
            this.timeFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom1.Location = new System.Drawing.Point(547, 39);
            this.timeFrom1.Name = "timeFrom1";
            this.timeFrom1.ShowUpDown = true;
            this.timeFrom1.Size = new System.Drawing.Size(109, 20);
            this.timeFrom1.TabIndex = 2;
            this.timeFrom1.Value = new System.DateTime(2018, 12, 29, 0, 0, 0, 0);
            // 
            // grpDestination
            // 
            this.grpDestination.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestination.Controls.Add(this.cboChannels);
            this.grpDestination.Controls.Add(this.cboBitrate);
            this.grpDestination.Controls.Add(this.lblBitrate);
            this.grpDestination.Controls.Add(this.cboSamplerate);
            this.grpDestination.Controls.Add(this.lblSamplerate);
            this.grpDestination.Controls.Add(this.cboBits);
            this.grpDestination.Controls.Add(this.lblDecodeMode);
            this.grpDestination.Controls.Add(this.lblBits);
            this.grpDestination.Controls.Add(this.cboDecodeMode);
            this.grpDestination.Controls.Add(this.label1);
            this.grpDestination.Controls.Add(this.lblDestinationFormat);
            this.grpDestination.Controls.Add(this.cboDestinationFormat);
            this.grpDestination.Location = new System.Drawing.Point(17, 272);
            this.grpDestination.Name = "grpDestination";
            this.grpDestination.Size = new System.Drawing.Size(441, 140);
            this.grpDestination.TabIndex = 62;
            this.grpDestination.TabStop = false;
            this.grpDestination.Text = "Destination";
            // 
            // grpID3Tags
            // 
            this.grpID3Tags.BackColor = System.Drawing.SystemColors.Control;
            this.grpID3Tags.Controls.Add(this.lblTagComment);
            this.grpID3Tags.Controls.Add(this.txtTagTitle);
            this.grpID3Tags.Controls.Add(this.lblTagTrackNum);
            this.grpID3Tags.Controls.Add(this.lblTagTitle);
            this.grpID3Tags.Controls.Add(this.txtTagTrackNum);
            this.grpID3Tags.Controls.Add(this.txtTagYear);
            this.grpID3Tags.Controls.Add(this.lblTagCopyright);
            this.grpID3Tags.Controls.Add(this.lblTagYear);
            this.grpID3Tags.Controls.Add(this.txtTagCopyright);
            this.grpID3Tags.Controls.Add(this.txtTagComment);
            this.grpID3Tags.Controls.Add(this.lblTagAlbum);
            this.grpID3Tags.Controls.Add(this.txtTagAlbum);
            this.grpID3Tags.Location = new System.Drawing.Point(464, 272);
            this.grpID3Tags.Name = "grpID3Tags";
            this.grpID3Tags.Size = new System.Drawing.Size(346, 140);
            this.grpID3Tags.TabIndex = 63;
            this.grpID3Tags.TabStop = false;
            this.grpID3Tags.Text = "ID3 Tags";
            // 
            // lblTagComment
            // 
            this.lblTagComment.AutoSize = true;
            this.lblTagComment.Location = new System.Drawing.Point(14, 82);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(51, 13);
            this.lblTagComment.TabIndex = 76;
            this.lblTagComment.Text = "Comment";
            // 
            // txtTagTitle
            // 
            this.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagTitle.Location = new System.Drawing.Point(17, 44);
            this.txtTagTitle.Name = "txtTagTitle";
            this.txtTagTitle.Size = new System.Drawing.Size(98, 20);
            this.txtTagTitle.TabIndex = 14;
            this.txtTagTitle.Text = "CSAudioConverter";
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(222, 28);
            this.lblTagTrackNum.Name = "lblTagTrackNum";
            this.lblTagTrackNum.Size = new System.Drawing.Size(42, 13);
            this.lblTagTrackNum.TabIndex = 75;
            this.lblTagTrackNum.Text = "Track#";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(14, 28);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTagTitle.TabIndex = 66;
            this.lblTagTitle.Text = "Title";
            // 
            // txtTagTrackNum
            // 
            this.txtTagTrackNum.Location = new System.Drawing.Point(225, 44);
            this.txtTagTrackNum.Name = "txtTagTrackNum";
            this.txtTagTrackNum.Size = new System.Drawing.Size(98, 20);
            this.txtTagTrackNum.TabIndex = 16;
            this.txtTagTrackNum.Text = "1";
            // 
            // txtTagYear
            // 
            this.txtTagYear.Location = new System.Drawing.Point(121, 98);
            this.txtTagYear.Name = "txtTagYear";
            this.txtTagYear.Size = new System.Drawing.Size(98, 20);
            this.txtTagYear.TabIndex = 18;
            // 
            // lblTagCopyright
            // 
            this.lblTagCopyright.AutoSize = true;
            this.lblTagCopyright.Location = new System.Drawing.Point(222, 82);
            this.lblTagCopyright.Name = "lblTagCopyright";
            this.lblTagCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblTagCopyright.TabIndex = 73;
            this.lblTagCopyright.Text = "Copyright";
            // 
            // lblTagYear
            // 
            this.lblTagYear.AutoSize = true;
            this.lblTagYear.Location = new System.Drawing.Point(118, 82);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(29, 13);
            this.lblTagYear.TabIndex = 68;
            this.lblTagYear.Text = "Year";
            // 
            // txtTagCopyright
            // 
            this.txtTagCopyright.Location = new System.Drawing.Point(225, 98);
            this.txtTagCopyright.Name = "txtTagCopyright";
            this.txtTagCopyright.Size = new System.Drawing.Size(98, 20);
            this.txtTagCopyright.TabIndex = 19;
            // 
            // txtTagComment
            // 
            this.txtTagComment.Location = new System.Drawing.Point(19, 98);
            this.txtTagComment.Name = "txtTagComment";
            this.txtTagComment.Size = new System.Drawing.Size(96, 20);
            this.txtTagComment.TabIndex = 17;
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(118, 28);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblTagAlbum.TabIndex = 71;
            this.lblTagAlbum.Text = "Album";
            // 
            // txtTagAlbum
            // 
            this.txtTagAlbum.Location = new System.Drawing.Point(121, 44);
            this.txtTagAlbum.Name = "txtTagAlbum";
            this.txtTagAlbum.Size = new System.Drawing.Size(98, 20);
            this.txtTagAlbum.TabIndex = 15;
            // 
            // grpProgress
            // 
            this.grpProgress.BackColor = System.Drawing.SystemColors.Control;
            this.grpProgress.Controls.Add(this.prgCurrentProgress);
            this.grpProgress.Controls.Add(this.lblCurrentProgress);
            this.grpProgress.Location = new System.Drawing.Point(17, 418);
            this.grpProgress.Name = "grpProgress";
            this.grpProgress.Size = new System.Drawing.Size(793, 89);
            this.grpProgress.TabIndex = 64;
            this.grpProgress.TabStop = false;
            this.grpProgress.Text = "Progress";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 45);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "CSAudioConverter |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = ".NET component to convert, join and cut many types of audio files.";
            // 
            // cboACMFormats
            // 
            this.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMFormats.FormattingEnabled = true;
            this.cboACMFormats.Location = new System.Drawing.Point(197, 29);
            this.cboACMFormats.Name = "cboACMFormats";
            this.cboACMFormats.Size = new System.Drawing.Size(188, 21);
            this.cboACMFormats.TabIndex = 72;
            // 
            // lblACMFormats
            // 
            this.lblACMFormats.AutoSize = true;
            this.lblACMFormats.Location = new System.Drawing.Point(197, 13);
            this.lblACMFormats.Name = "lblACMFormats";
            this.lblACMFormats.Size = new System.Drawing.Size(73, 13);
            this.lblACMFormats.TabIndex = 71;
            this.lblACMFormats.Text = "ACM Formats:";
            // 
            // cboACMTags
            // 
            this.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboACMTags.FormattingEnabled = true;
            this.cboACMTags.Location = new System.Drawing.Point(3, 29);
            this.cboACMTags.Name = "cboACMTags";
            this.cboACMTags.Size = new System.Drawing.Size(188, 21);
            this.cboACMTags.TabIndex = 70;
            this.cboACMTags.SelectedIndexChanged += new System.EventHandler(this.cboACMTags_SelectedIndexChanged);
            // 
            // lblACMTag
            // 
            this.lblACMTag.AutoSize = true;
            this.lblACMTag.Location = new System.Drawing.Point(3, 13);
            this.lblACMTag.Name = "lblACMTag";
            this.lblACMTag.Size = new System.Drawing.Size(60, 13);
            this.lblACMTag.TabIndex = 69;
            this.lblACMTag.Text = "ACM Tags:";
            // 
            // pnlACM
            // 
            this.pnlACM.Controls.Add(this.cboACMFormats);
            this.pnlACM.Controls.Add(this.cboACMTags);
            this.pnlACM.Controls.Add(this.lblACMTag);
            this.pnlACM.Controls.Add(this.lblACMFormats);
            this.pnlACM.Location = new System.Drawing.Point(369, 418);
            this.pnlACM.Name = "pnlACM";
            this.pnlACM.Size = new System.Drawing.Size(398, 64);
            this.pnlACM.TabIndex = 73;
            // 
            // lblDestinationFile
            // 
            this.lblDestinationFile.Location = new System.Drawing.Point(27, 24);
            this.lblDestinationFile.Name = "lblDestinationFile";
            this.lblDestinationFile.Size = new System.Drawing.Size(512, 29);
            this.lblDestinationFile.TabIndex = 74;
            this.lblDestinationFile.Text = "C:\\";
            // 
            // grpDestinationFile
            // 
            this.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control;
            this.grpDestinationFile.Controls.Add(this.cmdPlayWithDefaultPlayer);
            this.grpDestinationFile.Controls.Add(this.cmdOpenFileLocation);
            this.grpDestinationFile.Controls.Add(this.lblDestinationFile);
            this.grpDestinationFile.Location = new System.Drawing.Point(17, 513);
            this.grpDestinationFile.Name = "grpDestinationFile";
            this.grpDestinationFile.Size = new System.Drawing.Size(793, 71);
            this.grpDestinationFile.TabIndex = 75;
            this.grpDestinationFile.TabStop = false;
            this.grpDestinationFile.Text = "Destination File";
            // 
            // cmdID3Tags
            // 
            this.cmdID3Tags.Location = new System.Drawing.Point(491, 618);
            this.cmdID3Tags.Name = "cmdID3Tags";
            this.cmdID3Tags.Size = new System.Drawing.Size(145, 23);
            this.cmdID3Tags.TabIndex = 27;
            this.cmdID3Tags.Text = "ID3 Tags Editor";
            this.cmdID3Tags.UseVisualStyleBackColor = true;
            this.cmdID3Tags.Click += new System.EventHandler(this.cmdID3Tags_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-21, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(957, 45);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // audioConverter1
            // 
            this.audioConverter1.BitrateVal = 0;
            this.audioConverter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioConverter1.DestinatioFile = "";
            this.audioConverter1.Location = new System.Drawing.Point(735, 31);
            this.audioConverter1.Name = "audioConverter1";
            this.audioConverter1.RatingStars = 0F;
            this.audioConverter1.SamplerateVal = 0;
            this.audioConverter1.Size = new System.Drawing.Size(52, 52);
            this.audioConverter1.TabIndex = 7;
            this.audioConverter1.TagAlbum = null;
            this.audioConverter1.TagArtists = ((System.Collections.Generic.List<string>)(resources.GetObject("audioConverter1.TagArtists")));
            this.audioConverter1.TagComment = null;
            this.audioConverter1.TagComposers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioConverter1.TagComposers")));
            this.audioConverter1.TagCopyright = null;
            this.audioConverter1.TagGenres = ((System.Collections.Generic.List<string>)(resources.GetObject("audioConverter1.TagGenres")));
            this.audioConverter1.TagLyrics = null;
            this.audioConverter1.TagPerformers = ((System.Collections.Generic.List<string>)(resources.GetObject("audioConverter1.TagPerformers")));
            this.audioConverter1.TagRating = ((short)(0));
            this.audioConverter1.TagTitle = null;
            this.audioConverter1.TagTrack = ((uint)(0u));
            this.audioConverter1.TagYear = null;
            this.audioConverter1.UserKey = "";
            this.audioConverter1.UserName = "";
            this.audioConverter1.ConvertProgress += new CSAudioConverter.AudioConverter.ConvertProgressEventHandler(this.audioConverter1_ConvertProgress);
            this.audioConverter1.ConvertError += new CSAudioConverter.AudioConverter.ConvertErrorEventHandler(this.audioConverter1_ConvertError);
            this.audioConverter1.ConvertStart += new CSAudioConverter.AudioConverter.ConvertStartEventHandler(this.audioConverter1_ConvertStart);
            this.audioConverter1.ConvertDone += new CSAudioConverter.AudioConverter.ConvertDoneEventHandler(this.audioConverter1_ConvertDone);
            // 
            // frmAudioConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(839, 662);
            this.Controls.Add(this.cmdCheckLicense);
            this.Controls.Add(this.cmdID3Tags);
            this.Controls.Add(this.grpDestinationFile);
            this.Controls.Add(this.pnlACM);
            this.Controls.Add(this.audioConverter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpDestination);
            this.Controls.Add(this.grpProgress);
            this.Controls.Add(this.grpID3Tags);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.cmdPause);
            this.Controls.Add(this.cmdResume);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioConverter - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioConverter_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioConverter_Load);
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpDestination.ResumeLayout(false);
            this.grpDestination.PerformLayout();
            this.grpID3Tags.ResumeLayout(false);
            this.grpID3Tags.PerformLayout();
            this.grpProgress.ResumeLayout(false);
            this.grpProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlACM.ResumeLayout(false);
            this.pnlACM.PerformLayout();
            this.grpDestinationFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgCurrentProgress;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdConvert;
        private CSAudioConverter.AudioConverter audioConverter1;
        private System.Windows.Forms.Button cmdResume;
        private System.Windows.Forms.Button cmdPause;
        private System.Windows.Forms.Label lblDecodeMode;
        private System.Windows.Forms.ComboBox cboDecodeMode;
        private System.Windows.Forms.Label lblDestinationFormat;
        private System.Windows.Forms.ComboBox cboDestinationFormat;
        private System.Windows.Forms.ComboBox cboChannels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ComboBox cboBits;
        private System.Windows.Forms.Label lblSamplerate;
        private System.Windows.Forms.ComboBox cboSamplerate;
        private System.Windows.Forms.Label lblBitrate;
        private System.Windows.Forms.ComboBox cboBitrate;
        private System.Windows.Forms.TextBox txtSourceMediaFile1;
        private System.Windows.Forms.Label lblSourceMediaFile1;
        private System.Windows.Forms.Label lblFrom1;
        private System.Windows.Forms.Label lblTo1;
        private System.Windows.Forms.Label lblTo2;
        private System.Windows.Forms.Label lblFrom2;
        private System.Windows.Forms.Label lblSourceMediaFile2;
        private System.Windows.Forms.TextBox txtSourceMediaFile2;
        private System.Windows.Forms.Label lblCurrentProgress;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdSelectMediaFile1;
        private System.Windows.Forms.Button cmdSelectMediaFile2;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.GroupBox grpDestination;
        private System.Windows.Forms.GroupBox grpID3Tags;
        private System.Windows.Forms.GroupBox grpProgress;
        private System.Windows.Forms.Label lblTagTrackNum;
        private System.Windows.Forms.TextBox txtTagTrackNum;
        private System.Windows.Forms.Label lblTagCopyright;
        private System.Windows.Forms.TextBox txtTagCopyright;
        private System.Windows.Forms.Label lblTagAlbum;
        private System.Windows.Forms.TextBox txtTagAlbum;
        private System.Windows.Forms.TextBox txtTagComment;
        private System.Windows.Forms.Label lblTagYear;
        private System.Windows.Forms.TextBox txtTagYear;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.TextBox txtTagTitle;
        private System.Windows.Forms.Label lblTagComment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeFrom1;
        private System.Windows.Forms.DateTimePicker timeTo1;
        private System.Windows.Forms.DateTimePicker timeTo2;
        private System.Windows.Forms.DateTimePicker timeFrom2;
        internal System.Windows.Forms.ComboBox cboACMFormats;
        internal System.Windows.Forms.Label lblACMFormats;
        internal System.Windows.Forms.ComboBox cboACMTags;
        internal System.Windows.Forms.Label lblACMTag;
        private System.Windows.Forms.Panel pnlACM;
        private System.Windows.Forms.Label lblDestinationFile;
        private System.Windows.Forms.GroupBox grpDestinationFile;
        private System.Windows.Forms.Button cmdPlayWithDefaultPlayer;
        private System.Windows.Forms.Button cmdOpenFileLocation;
        private System.Windows.Forms.Button cmdID3Tags;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cmdCheckLicense;
    }
}

