<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAudioConverter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAudioConverter))
        Me.timeTo1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdID3Tags = New System.Windows.Forms.Button()
        Me.timeFrom1 = New System.Windows.Forms.DateTimePicker()
        Me.grpDestination = New System.Windows.Forms.GroupBox()
        Me.cboChannels = New System.Windows.Forms.ComboBox()
        Me.cboBitrate = New System.Windows.Forms.ComboBox()
        Me.lblBitrate = New System.Windows.Forms.Label()
        Me.cboSamplerate = New System.Windows.Forms.ComboBox()
        Me.lblSamplerate = New System.Windows.Forms.Label()
        Me.cboBits = New System.Windows.Forms.ComboBox()
        Me.lblDecodeMode = New System.Windows.Forms.Label()
        Me.lblBits = New System.Windows.Forms.Label()
        Me.cboDecodeMode = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblDestinationFormat = New System.Windows.Forms.Label()
        Me.cboDestinationFormat = New System.Windows.Forms.ComboBox()
        Me.grpID3Tags = New System.Windows.Forms.GroupBox()
        Me.lblTagComment = New System.Windows.Forms.Label()
        Me.txtTagTitle = New System.Windows.Forms.TextBox()
        Me.lblTagTrackNum = New System.Windows.Forms.Label()
        Me.lblTagTitle = New System.Windows.Forms.Label()
        Me.txtTagTrackNum = New System.Windows.Forms.TextBox()
        Me.txtTagYear = New System.Windows.Forms.TextBox()
        Me.lblTagCopyright = New System.Windows.Forms.Label()
        Me.lblTagYear = New System.Windows.Forms.Label()
        Me.txtTagCopyright = New System.Windows.Forms.TextBox()
        Me.txtTagComment = New System.Windows.Forms.TextBox()
        Me.lblTagAlbum = New System.Windows.Forms.Label()
        Me.txtTagAlbum = New System.Windows.Forms.TextBox()
        Me.cmdCheckLicense = New System.Windows.Forms.Button()
        Me.grpDestinationFile = New System.Windows.Forms.GroupBox()
        Me.cmdPlayWithDefaultPlayer = New System.Windows.Forms.Button()
        Me.cmdOpenFileLocation = New System.Windows.Forms.Button()
        Me.lblDestinationFile = New System.Windows.Forms.Label()
        Me.cboACMTags = New System.Windows.Forms.ComboBox()
        Me.lblACMTag = New System.Windows.Forms.Label()
        Me.pnlACM = New System.Windows.Forms.Panel()
        Me.cboACMFormats = New System.Windows.Forms.ComboBox()
        Me.lblACMFormats = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpSource = New System.Windows.Forms.GroupBox()
        Me.timeTo2 = New System.Windows.Forms.DateTimePicker()
        Me.timeFrom2 = New System.Windows.Forms.DateTimePicker()
        Me.txtSourceMediaFile2 = New System.Windows.Forms.TextBox()
        Me.cmdSelectMediaFile2 = New System.Windows.Forms.Button()
        Me.txtSourceMediaFile1 = New System.Windows.Forms.TextBox()
        Me.cmdSelectMediaFile1 = New System.Windows.Forms.Button()
        Me.lblSourceMediaFile1 = New System.Windows.Forms.Label()
        Me.lblFrom1 = New System.Windows.Forms.Label()
        Me.lblTo1 = New System.Windows.Forms.Label()
        Me.lblTo2 = New System.Windows.Forms.Label()
        Me.lblSourceMediaFile2 = New System.Windows.Forms.Label()
        Me.lblFrom2 = New System.Windows.Forms.Label()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.grpProgress = New System.Windows.Forms.GroupBox()
        Me.prgCurrentProgress = New System.Windows.Forms.ProgressBar()
        Me.lblCurrentProgress = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AudioConverter1 = New CSAudioConverter.AudioConverter()
        Me.grpDestination.SuspendLayout()
        Me.grpID3Tags.SuspendLayout()
        Me.grpDestinationFile.SuspendLayout()
        Me.pnlACM.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSource.SuspendLayout()
        Me.grpProgress.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeTo1
        '
        Me.timeTo1.CustomFormat = "HH:mm:ss"
        Me.timeTo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeTo1.Location = New System.Drawing.Point(663, 39)
        Me.timeTo1.Name = "timeTo1"
        Me.timeTo1.ShowUpDown = True
        Me.timeTo1.Size = New System.Drawing.Size(109, 20)
        Me.timeTo1.TabIndex = 3
        Me.timeTo1.Value = New Date(2018, 12, 29, 0, 0, 0, 0)
        '
        'cmdID3Tags
        '
        Me.cmdID3Tags.Location = New System.Drawing.Point(491, 618)
        Me.cmdID3Tags.Name = "cmdID3Tags"
        Me.cmdID3Tags.Size = New System.Drawing.Size(145, 23)
        Me.cmdID3Tags.TabIndex = 82
        Me.cmdID3Tags.Text = "ID3 Tags Editor"
        Me.cmdID3Tags.UseVisualStyleBackColor = True
        '
        'timeFrom1
        '
        Me.timeFrom1.CustomFormat = "HH:mm:ss"
        Me.timeFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeFrom1.Location = New System.Drawing.Point(547, 39)
        Me.timeFrom1.Name = "timeFrom1"
        Me.timeFrom1.ShowUpDown = True
        Me.timeFrom1.Size = New System.Drawing.Size(109, 20)
        Me.timeFrom1.TabIndex = 2
        Me.timeFrom1.Value = New Date(2018, 12, 29, 0, 0, 0, 0)
        '
        'grpDestination
        '
        Me.grpDestination.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestination.Controls.Add(Me.cboChannels)
        Me.grpDestination.Controls.Add(Me.cboBitrate)
        Me.grpDestination.Controls.Add(Me.lblBitrate)
        Me.grpDestination.Controls.Add(Me.cboSamplerate)
        Me.grpDestination.Controls.Add(Me.lblSamplerate)
        Me.grpDestination.Controls.Add(Me.cboBits)
        Me.grpDestination.Controls.Add(Me.lblDecodeMode)
        Me.grpDestination.Controls.Add(Me.lblBits)
        Me.grpDestination.Controls.Add(Me.cboDecodeMode)
        Me.grpDestination.Controls.Add(Me.label1)
        Me.grpDestination.Controls.Add(Me.lblDestinationFormat)
        Me.grpDestination.Controls.Add(Me.cboDestinationFormat)
        Me.grpDestination.Location = New System.Drawing.Point(17, 272)
        Me.grpDestination.Name = "grpDestination"
        Me.grpDestination.Size = New System.Drawing.Size(441, 140)
        Me.grpDestination.TabIndex = 84
        Me.grpDestination.TabStop = False
        Me.grpDestination.Text = "Destination"
        '
        'cboChannels
        '
        Me.cboChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChannels.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboChannels.FormattingEnabled = True
        Me.cboChannels.Location = New System.Drawing.Point(214, 99)
        Me.cboChannels.Name = "cboChannels"
        Me.cboChannels.Size = New System.Drawing.Size(91, 21)
        Me.cboChannels.TabIndex = 12
        '
        'cboBitrate
        '
        Me.cboBitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBitrate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboBitrate.FormattingEnabled = True
        Me.cboBitrate.Location = New System.Drawing.Point(20, 99)
        Me.cboBitrate.Name = "cboBitrate"
        Me.cboBitrate.Size = New System.Drawing.Size(91, 21)
        Me.cboBitrate.TabIndex = 10
        '
        'lblBitrate
        '
        Me.lblBitrate.AutoSize = True
        Me.lblBitrate.Location = New System.Drawing.Point(17, 83)
        Me.lblBitrate.Name = "lblBitrate"
        Me.lblBitrate.Size = New System.Drawing.Size(37, 13)
        Me.lblBitrate.TabIndex = 31
        Me.lblBitrate.Text = "Bitrate"
        '
        'cboSamplerate
        '
        Me.cboSamplerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSamplerate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSamplerate.FormattingEnabled = True
        Me.cboSamplerate.Location = New System.Drawing.Point(117, 99)
        Me.cboSamplerate.Name = "cboSamplerate"
        Me.cboSamplerate.Size = New System.Drawing.Size(91, 21)
        Me.cboSamplerate.TabIndex = 11
        '
        'lblSamplerate
        '
        Me.lblSamplerate.AutoSize = True
        Me.lblSamplerate.Location = New System.Drawing.Point(114, 83)
        Me.lblSamplerate.Name = "lblSamplerate"
        Me.lblSamplerate.Size = New System.Drawing.Size(60, 13)
        Me.lblSamplerate.TabIndex = 33
        Me.lblSamplerate.Text = "Samplerate"
        '
        'cboBits
        '
        Me.cboBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBits.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboBits.FormattingEnabled = True
        Me.cboBits.Location = New System.Drawing.Point(311, 98)
        Me.cboBits.Name = "cboBits"
        Me.cboBits.Size = New System.Drawing.Size(91, 21)
        Me.cboBits.TabIndex = 13
        '
        'lblDecodeMode
        '
        Me.lblDecodeMode.AutoSize = True
        Me.lblDecodeMode.Location = New System.Drawing.Point(211, 28)
        Me.lblDecodeMode.Name = "lblDecodeMode"
        Me.lblDecodeMode.Size = New System.Drawing.Size(78, 13)
        Me.lblDecodeMode.TabIndex = 41
        Me.lblDecodeMode.Text = "Decoder Mode"
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(308, 82)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(49, 13)
        Me.lblBits.TabIndex = 35
        Me.lblBits.Text = "Bit depth"
        '
        'cboDecodeMode
        '
        Me.cboDecodeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecodeMode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDecodeMode.FormattingEnabled = True
        Me.cboDecodeMode.Location = New System.Drawing.Point(214, 44)
        Me.cboDecodeMode.Name = "cboDecodeMode"
        Me.cboDecodeMode.Size = New System.Drawing.Size(188, 21)
        Me.cboDecodeMode.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(211, 83)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Channels"
        '
        'lblDestinationFormat
        '
        Me.lblDestinationFormat.AutoSize = True
        Me.lblDestinationFormat.Location = New System.Drawing.Point(17, 28)
        Me.lblDestinationFormat.Name = "lblDestinationFormat"
        Me.lblDestinationFormat.Size = New System.Drawing.Size(95, 13)
        Me.lblDestinationFormat.TabIndex = 39
        Me.lblDestinationFormat.Text = "Destination Format"
        '
        'cboDestinationFormat
        '
        Me.cboDestinationFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDestinationFormat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboDestinationFormat.FormattingEnabled = True
        Me.cboDestinationFormat.Location = New System.Drawing.Point(20, 44)
        Me.cboDestinationFormat.Name = "cboDestinationFormat"
        Me.cboDestinationFormat.Size = New System.Drawing.Size(188, 21)
        Me.cboDestinationFormat.TabIndex = 8
        '
        'grpID3Tags
        '
        Me.grpID3Tags.BackColor = System.Drawing.SystemColors.Control
        Me.grpID3Tags.Controls.Add(Me.lblTagComment)
        Me.grpID3Tags.Controls.Add(Me.txtTagTitle)
        Me.grpID3Tags.Controls.Add(Me.lblTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.lblTagTitle)
        Me.grpID3Tags.Controls.Add(Me.txtTagTrackNum)
        Me.grpID3Tags.Controls.Add(Me.txtTagYear)
        Me.grpID3Tags.Controls.Add(Me.lblTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.lblTagYear)
        Me.grpID3Tags.Controls.Add(Me.txtTagCopyright)
        Me.grpID3Tags.Controls.Add(Me.txtTagComment)
        Me.grpID3Tags.Controls.Add(Me.lblTagAlbum)
        Me.grpID3Tags.Controls.Add(Me.txtTagAlbum)
        Me.grpID3Tags.Location = New System.Drawing.Point(464, 272)
        Me.grpID3Tags.Name = "grpID3Tags"
        Me.grpID3Tags.Size = New System.Drawing.Size(346, 140)
        Me.grpID3Tags.TabIndex = 85
        Me.grpID3Tags.TabStop = False
        Me.grpID3Tags.Text = "ID3 Tags"
        '
        'lblTagComment
        '
        Me.lblTagComment.AutoSize = True
        Me.lblTagComment.Location = New System.Drawing.Point(14, 82)
        Me.lblTagComment.Name = "lblTagComment"
        Me.lblTagComment.Size = New System.Drawing.Size(51, 13)
        Me.lblTagComment.TabIndex = 76
        Me.lblTagComment.Text = "Comment"
        '
        'txtTagTitle
        '
        Me.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTagTitle.Location = New System.Drawing.Point(17, 44)
        Me.txtTagTitle.Name = "txtTagTitle"
        Me.txtTagTitle.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTitle.TabIndex = 14
        Me.txtTagTitle.Text = "CSAudioConverter"
        '
        'lblTagTrackNum
        '
        Me.lblTagTrackNum.AutoSize = True
        Me.lblTagTrackNum.Location = New System.Drawing.Point(222, 28)
        Me.lblTagTrackNum.Name = "lblTagTrackNum"
        Me.lblTagTrackNum.Size = New System.Drawing.Size(42, 13)
        Me.lblTagTrackNum.TabIndex = 75
        Me.lblTagTrackNum.Text = "Track#"
        '
        'lblTagTitle
        '
        Me.lblTagTitle.AutoSize = True
        Me.lblTagTitle.Location = New System.Drawing.Point(14, 28)
        Me.lblTagTitle.Name = "lblTagTitle"
        Me.lblTagTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTagTitle.TabIndex = 66
        Me.lblTagTitle.Text = "Title"
        '
        'txtTagTrackNum
        '
        Me.txtTagTrackNum.Location = New System.Drawing.Point(225, 44)
        Me.txtTagTrackNum.Name = "txtTagTrackNum"
        Me.txtTagTrackNum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagTrackNum.TabIndex = 16
        Me.txtTagTrackNum.Text = "1"
        '
        'txtTagYear
        '
        Me.txtTagYear.Location = New System.Drawing.Point(121, 98)
        Me.txtTagYear.Name = "txtTagYear"
        Me.txtTagYear.Size = New System.Drawing.Size(98, 20)
        Me.txtTagYear.TabIndex = 18
        '
        'lblTagCopyright
        '
        Me.lblTagCopyright.AutoSize = True
        Me.lblTagCopyright.Location = New System.Drawing.Point(222, 82)
        Me.lblTagCopyright.Name = "lblTagCopyright"
        Me.lblTagCopyright.Size = New System.Drawing.Size(51, 13)
        Me.lblTagCopyright.TabIndex = 73
        Me.lblTagCopyright.Text = "Copyright"
        '
        'lblTagYear
        '
        Me.lblTagYear.AutoSize = True
        Me.lblTagYear.Location = New System.Drawing.Point(118, 82)
        Me.lblTagYear.Name = "lblTagYear"
        Me.lblTagYear.Size = New System.Drawing.Size(29, 13)
        Me.lblTagYear.TabIndex = 68
        Me.lblTagYear.Text = "Year"
        '
        'txtTagCopyright
        '
        Me.txtTagCopyright.Location = New System.Drawing.Point(225, 98)
        Me.txtTagCopyright.Name = "txtTagCopyright"
        Me.txtTagCopyright.Size = New System.Drawing.Size(98, 20)
        Me.txtTagCopyright.TabIndex = 19
        '
        'txtTagComment
        '
        Me.txtTagComment.Location = New System.Drawing.Point(19, 98)
        Me.txtTagComment.Name = "txtTagComment"
        Me.txtTagComment.Size = New System.Drawing.Size(96, 20)
        Me.txtTagComment.TabIndex = 17
        '
        'lblTagAlbum
        '
        Me.lblTagAlbum.AutoSize = True
        Me.lblTagAlbum.Location = New System.Drawing.Point(118, 28)
        Me.lblTagAlbum.Name = "lblTagAlbum"
        Me.lblTagAlbum.Size = New System.Drawing.Size(36, 13)
        Me.lblTagAlbum.TabIndex = 71
        Me.lblTagAlbum.Text = "Album"
        '
        'txtTagAlbum
        '
        Me.txtTagAlbum.Location = New System.Drawing.Point(121, 44)
        Me.txtTagAlbum.Name = "txtTagAlbum"
        Me.txtTagAlbum.Size = New System.Drawing.Size(98, 20)
        Me.txtTagAlbum.TabIndex = 15
        '
        'cmdCheckLicense
        '
        Me.cmdCheckLicense.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdCheckLicense.Image = CType(resources.GetObject("cmdCheckLicense.Image"), System.Drawing.Image)
        Me.cmdCheckLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCheckLicense.Location = New System.Drawing.Point(642, 618)
        Me.cmdCheckLicense.Name = "cmdCheckLicense"
        Me.cmdCheckLicense.Size = New System.Drawing.Size(168, 23)
        Me.cmdCheckLicense.TabIndex = 93
        Me.cmdCheckLicense.Text = "Order a license online"
        Me.toolTip1.SetToolTip(Me.cmdCheckLicense, "Order a license online")
        Me.cmdCheckLicense.UseVisualStyleBackColor = True
        '
        'grpDestinationFile
        '
        Me.grpDestinationFile.BackColor = System.Drawing.SystemColors.Control
        Me.grpDestinationFile.Controls.Add(Me.cmdPlayWithDefaultPlayer)
        Me.grpDestinationFile.Controls.Add(Me.cmdOpenFileLocation)
        Me.grpDestinationFile.Controls.Add(Me.lblDestinationFile)
        Me.grpDestinationFile.Location = New System.Drawing.Point(17, 513)
        Me.grpDestinationFile.Name = "grpDestinationFile"
        Me.grpDestinationFile.Size = New System.Drawing.Size(793, 71)
        Me.grpDestinationFile.TabIndex = 91
        Me.grpDestinationFile.TabStop = False
        Me.grpDestinationFile.Text = "Destination File"
        '
        'cmdPlayWithDefaultPlayer
        '
        Me.cmdPlayWithDefaultPlayer.Location = New System.Drawing.Point(545, 24)
        Me.cmdPlayWithDefaultPlayer.Name = "cmdPlayWithDefaultPlayer"
        Me.cmdPlayWithDefaultPlayer.Size = New System.Drawing.Size(74, 23)
        Me.cmdPlayWithDefaultPlayer.TabIndex = 20
        Me.cmdPlayWithDefaultPlayer.Text = "Play"
        Me.toolTip1.SetToolTip(Me.cmdPlayWithDefaultPlayer, "Playe with the default system player.")
        Me.cmdPlayWithDefaultPlayer.UseVisualStyleBackColor = True
        '
        'cmdOpenFileLocation
        '
        Me.cmdOpenFileLocation.Location = New System.Drawing.Point(625, 24)
        Me.cmdOpenFileLocation.Name = "cmdOpenFileLocation"
        Me.cmdOpenFileLocation.Size = New System.Drawing.Size(145, 23)
        Me.cmdOpenFileLocation.TabIndex = 21
        Me.cmdOpenFileLocation.Text = "Open file Location"
        Me.toolTip1.SetToolTip(Me.cmdOpenFileLocation, "Open file Location.")
        Me.cmdOpenFileLocation.UseVisualStyleBackColor = True
        '
        'lblDestinationFile
        '
        Me.lblDestinationFile.Location = New System.Drawing.Point(27, 24)
        Me.lblDestinationFile.Name = "lblDestinationFile"
        Me.lblDestinationFile.Size = New System.Drawing.Size(512, 29)
        Me.lblDestinationFile.TabIndex = 74
        Me.lblDestinationFile.Text = "C:\"
        '
        'cboACMTags
        '
        Me.cboACMTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMTags.FormattingEnabled = True
        Me.cboACMTags.Location = New System.Drawing.Point(3, 29)
        Me.cboACMTags.Name = "cboACMTags"
        Me.cboACMTags.Size = New System.Drawing.Size(188, 21)
        Me.cboACMTags.TabIndex = 70
        '
        'lblACMTag
        '
        Me.lblACMTag.AutoSize = True
        Me.lblACMTag.Location = New System.Drawing.Point(3, 13)
        Me.lblACMTag.Name = "lblACMTag"
        Me.lblACMTag.Size = New System.Drawing.Size(60, 13)
        Me.lblACMTag.TabIndex = 69
        Me.lblACMTag.Text = "ACM Tags:"
        '
        'pnlACM
        '
        Me.pnlACM.Controls.Add(Me.cboACMFormats)
        Me.pnlACM.Controls.Add(Me.cboACMTags)
        Me.pnlACM.Controls.Add(Me.lblACMTag)
        Me.pnlACM.Controls.Add(Me.lblACMFormats)
        Me.pnlACM.Location = New System.Drawing.Point(394, 418)
        Me.pnlACM.Name = "pnlACM"
        Me.pnlACM.Size = New System.Drawing.Size(398, 64)
        Me.pnlACM.TabIndex = 90
        '
        'cboACMFormats
        '
        Me.cboACMFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboACMFormats.FormattingEnabled = True
        Me.cboACMFormats.Location = New System.Drawing.Point(197, 29)
        Me.cboACMFormats.Name = "cboACMFormats"
        Me.cboACMFormats.Size = New System.Drawing.Size(188, 21)
        Me.cboACMFormats.TabIndex = 72
        '
        'lblACMFormats
        '
        Me.lblACMFormats.AutoSize = True
        Me.lblACMFormats.Location = New System.Drawing.Point(197, 13)
        Me.lblACMFormats.Name = "lblACMFormats"
        Me.lblACMFormats.Size = New System.Drawing.Size(73, 13)
        Me.lblACMFormats.TabIndex = 71
        Me.lblACMFormats.Text = "ACM Formats:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(237, 16)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(462, 16)
        Me.label3.TabIndex = 89
        Me.label3.Text = ".NET component to convert, join and cut many types of audio files."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(12, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(219, 25)
        Me.label2.TabIndex = 88
        Me.label2.Text = "CSAudioConverter |"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pictureBox1.Location = New System.Drawing.Point(-31, -1)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox1.TabIndex = 87
        Me.pictureBox1.TabStop = False
        '
        'grpSource
        '
        Me.grpSource.BackColor = System.Drawing.SystemColors.Control
        Me.grpSource.Controls.Add(Me.timeTo2)
        Me.grpSource.Controls.Add(Me.timeFrom2)
        Me.grpSource.Controls.Add(Me.timeTo1)
        Me.grpSource.Controls.Add(Me.timeFrom1)
        Me.grpSource.Controls.Add(Me.txtSourceMediaFile2)
        Me.grpSource.Controls.Add(Me.cmdSelectMediaFile2)
        Me.grpSource.Controls.Add(Me.txtSourceMediaFile1)
        Me.grpSource.Controls.Add(Me.cmdSelectMediaFile1)
        Me.grpSource.Controls.Add(Me.lblSourceMediaFile1)
        Me.grpSource.Controls.Add(Me.lblFrom1)
        Me.grpSource.Controls.Add(Me.lblTo1)
        Me.grpSource.Controls.Add(Me.lblTo2)
        Me.grpSource.Controls.Add(Me.lblSourceMediaFile2)
        Me.grpSource.Controls.Add(Me.lblFrom2)
        Me.grpSource.Location = New System.Drawing.Point(17, 75)
        Me.grpSource.Name = "grpSource"
        Me.grpSource.Size = New System.Drawing.Size(793, 191)
        Me.grpSource.TabIndex = 83
        Me.grpSource.TabStop = False
        Me.grpSource.Text = "Source"
        '
        'timeTo2
        '
        Me.timeTo2.CustomFormat = "HH:mm:ss"
        Me.timeTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeTo2.Location = New System.Drawing.Point(663, 122)
        Me.timeTo2.Name = "timeTo2"
        Me.timeTo2.ShowUpDown = True
        Me.timeTo2.Size = New System.Drawing.Size(109, 20)
        Me.timeTo2.TabIndex = 7
        Me.timeTo2.Value = New Date(2018, 12, 29, 0, 0, 0, 0)
        '
        'timeFrom2
        '
        Me.timeFrom2.CustomFormat = "HH:mm:ss"
        Me.timeFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.timeFrom2.Location = New System.Drawing.Point(547, 122)
        Me.timeFrom2.Name = "timeFrom2"
        Me.timeFrom2.ShowUpDown = True
        Me.timeFrom2.Size = New System.Drawing.Size(109, 20)
        Me.timeFrom2.TabIndex = 6
        Me.timeFrom2.Value = New Date(2018, 12, 29, 0, 0, 0, 0)
        '
        'txtSourceMediaFile2
        '
        Me.txtSourceMediaFile2.Location = New System.Drawing.Point(20, 122)
        Me.txtSourceMediaFile2.Multiline = True
        Me.txtSourceMediaFile2.Name = "txtSourceMediaFile2"
        Me.txtSourceMediaFile2.Size = New System.Drawing.Size(421, 50)
        Me.txtSourceMediaFile2.TabIndex = 4
        '
        'cmdSelectMediaFile2
        '
        Me.cmdSelectMediaFile2.Location = New System.Drawing.Point(447, 121)
        Me.cmdSelectMediaFile2.Name = "cmdSelectMediaFile2"
        Me.cmdSelectMediaFile2.Size = New System.Drawing.Size(75, 21)
        Me.cmdSelectMediaFile2.TabIndex = 5
        Me.cmdSelectMediaFile2.Text = "..."
        Me.toolTip1.SetToolTip(Me.cmdSelectMediaFile2, "Select the source mdia file 2.")
        Me.cmdSelectMediaFile2.UseVisualStyleBackColor = True
        '
        'txtSourceMediaFile1
        '
        Me.txtSourceMediaFile1.Location = New System.Drawing.Point(20, 39)
        Me.txtSourceMediaFile1.Multiline = True
        Me.txtSourceMediaFile1.Name = "txtSourceMediaFile1"
        Me.txtSourceMediaFile1.Size = New System.Drawing.Size(421, 50)
        Me.txtSourceMediaFile1.TabIndex = 0
        '
        'cmdSelectMediaFile1
        '
        Me.cmdSelectMediaFile1.Location = New System.Drawing.Point(447, 39)
        Me.cmdSelectMediaFile1.Name = "cmdSelectMediaFile1"
        Me.cmdSelectMediaFile1.Size = New System.Drawing.Size(75, 20)
        Me.cmdSelectMediaFile1.TabIndex = 1
        Me.cmdSelectMediaFile1.Text = "..."
        Me.toolTip1.SetToolTip(Me.cmdSelectMediaFile1, "Select the source mdia file 1.")
        Me.cmdSelectMediaFile1.UseVisualStyleBackColor = True
        '
        'lblSourceMediaFile1
        '
        Me.lblSourceMediaFile1.AutoSize = True
        Me.lblSourceMediaFile1.Location = New System.Drawing.Point(17, 23)
        Me.lblSourceMediaFile1.Name = "lblSourceMediaFile1"
        Me.lblSourceMediaFile1.Size = New System.Drawing.Size(101, 13)
        Me.lblSourceMediaFile1.TabIndex = 44
        Me.lblSourceMediaFile1.Text = "Source Media File 1"
        '
        'lblFrom1
        '
        Me.lblFrom1.AutoSize = True
        Me.lblFrom1.Location = New System.Drawing.Point(544, 23)
        Me.lblFrom1.Name = "lblFrom1"
        Me.lblFrom1.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom1.TabIndex = 47
        Me.lblFrom1.Text = "From"
        '
        'lblTo1
        '
        Me.lblTo1.AutoSize = True
        Me.lblTo1.Location = New System.Drawing.Point(660, 23)
        Me.lblTo1.Name = "lblTo1"
        Me.lblTo1.Size = New System.Drawing.Size(20, 13)
        Me.lblTo1.TabIndex = 48
        Me.lblTo1.Text = "To"
        '
        'lblTo2
        '
        Me.lblTo2.AutoSize = True
        Me.lblTo2.Location = New System.Drawing.Point(660, 106)
        Me.lblTo2.Name = "lblTo2"
        Me.lblTo2.Size = New System.Drawing.Size(20, 13)
        Me.lblTo2.TabIndex = 54
        Me.lblTo2.Text = "To"
        '
        'lblSourceMediaFile2
        '
        Me.lblSourceMediaFile2.AutoSize = True
        Me.lblSourceMediaFile2.Location = New System.Drawing.Point(17, 106)
        Me.lblSourceMediaFile2.Name = "lblSourceMediaFile2"
        Me.lblSourceMediaFile2.Size = New System.Drawing.Size(141, 13)
        Me.lblSourceMediaFile2.TabIndex = 50
        Me.lblSourceMediaFile2.Text = "Source Media File 2 (for join)"
        '
        'lblFrom2
        '
        Me.lblFrom2.AutoSize = True
        Me.lblFrom2.Location = New System.Drawing.Point(544, 106)
        Me.lblFrom2.Name = "lblFrom2"
        Me.lblFrom2.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom2.TabIndex = 53
        Me.lblFrom2.Text = "From"
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(190, 618)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 23)
        Me.cmdPause.TabIndex = 79
        Me.cmdPause.Text = "Pause"
        Me.toolTip1.SetToolTip(Me.cmdPause, "Pause the entry progress.")
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(271, 618)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(75, 23)
        Me.cmdResume.TabIndex = 80
        Me.cmdResume.Text = "Resume"
        Me.toolTip1.SetToolTip(Me.cmdResume, "Resume the progress.")
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(352, 618)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(92, 23)
        Me.cmdCancel.TabIndex = 81
        Me.cmdCancel.Text = "Cancel"
        Me.toolTip1.SetToolTip(Me.cmdCancel, "Cancel the progress.")
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdConvert
        '
        Me.cmdConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdConvert.Location = New System.Drawing.Point(17, 618)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(167, 23)
        Me.cmdConvert.TabIndex = 78
        Me.cmdConvert.Text = "Convert / Join"
        Me.toolTip1.SetToolTip(Me.cmdConvert, "Convert and join.")
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'grpProgress
        '
        Me.grpProgress.BackColor = System.Drawing.SystemColors.Control
        Me.grpProgress.Controls.Add(Me.prgCurrentProgress)
        Me.grpProgress.Controls.Add(Me.lblCurrentProgress)
        Me.grpProgress.Location = New System.Drawing.Point(17, 418)
        Me.grpProgress.Name = "grpProgress"
        Me.grpProgress.Size = New System.Drawing.Size(793, 89)
        Me.grpProgress.TabIndex = 86
        Me.grpProgress.TabStop = False
        Me.grpProgress.Text = "Progress"
        '
        'prgCurrentProgress
        '
        Me.prgCurrentProgress.Location = New System.Drawing.Point(20, 43)
        Me.prgCurrentProgress.Name = "prgCurrentProgress"
        Me.prgCurrentProgress.Size = New System.Drawing.Size(750, 23)
        Me.prgCurrentProgress.TabIndex = 6
        '
        'lblCurrentProgress
        '
        Me.lblCurrentProgress.AutoSize = True
        Me.lblCurrentProgress.Location = New System.Drawing.Point(17, 27)
        Me.lblCurrentProgress.Name = "lblCurrentProgress"
        Me.lblCurrentProgress.Size = New System.Drawing.Size(41, 13)
        Me.lblCurrentProgress.TabIndex = 55
        Me.lblCurrentProgress.Text = "Ready."
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pictureBox2.Location = New System.Drawing.Point(-21, 7)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(957, 45)
        Me.pictureBox2.TabIndex = 92
        Me.pictureBox2.TabStop = False
        '
        'AudioConverter1
        '
        Me.AudioConverter1.BitrateVal = 0
        Me.AudioConverter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AudioConverter1.DestinatioFile = Nothing
        Me.AudioConverter1.Location = New System.Drawing.Point(740, 21)
        Me.AudioConverter1.Name = "AudioConverter1"
        Me.AudioConverter1.RatingStars = 0!
        Me.AudioConverter1.SamplerateVal = 0
        Me.AudioConverter1.Size = New System.Drawing.Size(52, 52)
        Me.AudioConverter1.TabIndex = 94
        Me.AudioConverter1.TagAlbum = Nothing
        Me.AudioConverter1.TagArtists = CType(resources.GetObject("AudioConverter1.TagArtists"), System.Collections.Generic.List(Of String))
        Me.AudioConverter1.TagComment = Nothing
        Me.AudioConverter1.TagComposers = CType(resources.GetObject("AudioConverter1.TagComposers"), System.Collections.Generic.List(Of String))
        Me.AudioConverter1.TagCopyright = Nothing
        Me.AudioConverter1.TagGenres = CType(resources.GetObject("AudioConverter1.TagGenres"), System.Collections.Generic.List(Of String))
        Me.AudioConverter1.TagLyrics = Nothing
        Me.AudioConverter1.TagPerformers = CType(resources.GetObject("AudioConverter1.TagPerformers"), System.Collections.Generic.List(Of String))
        Me.AudioConverter1.TagRating = CType(0, Short)
        Me.AudioConverter1.TagTitle = Nothing
        Me.AudioConverter1.TagTrack = CType(0UI, UInteger)
        Me.AudioConverter1.TagYear = Nothing
        Me.AudioConverter1.UserKey = "Your registration key"
        Me.AudioConverter1.UserName = "Your email"
        '
        'frmAudioConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 662)
        Me.Controls.Add(Me.pnlACM)
        Me.Controls.Add(Me.AudioConverter1)
        Me.Controls.Add(Me.cmdID3Tags)
        Me.Controls.Add(Me.grpDestination)
        Me.Controls.Add(Me.grpID3Tags)
        Me.Controls.Add(Me.cmdCheckLicense)
        Me.Controls.Add(Me.grpDestinationFile)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.grpSource)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.grpProgress)
        Me.Controls.Add(Me.pictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAudioConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSAudioConverter - VB Full Example"
        Me.grpDestination.ResumeLayout(False)
        Me.grpDestination.PerformLayout()
        Me.grpID3Tags.ResumeLayout(False)
        Me.grpID3Tags.PerformLayout()
        Me.grpDestinationFile.ResumeLayout(False)
        Me.pnlACM.ResumeLayout(False)
        Me.pnlACM.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSource.ResumeLayout(False)
        Me.grpSource.PerformLayout()
        Me.grpProgress.ResumeLayout(False)
        Me.grpProgress.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents timeTo1 As DateTimePicker
    Private WithEvents cmdID3Tags As Button
    Private WithEvents timeFrom1 As DateTimePicker
    Private WithEvents grpDestination As GroupBox
    Private WithEvents cboChannels As ComboBox
    Private WithEvents cboBitrate As ComboBox
    Private WithEvents lblBitrate As Label
    Private WithEvents cboSamplerate As ComboBox
    Private WithEvents lblSamplerate As Label
    Private WithEvents cboBits As ComboBox
    Private WithEvents lblDecodeMode As Label
    Private WithEvents lblBits As Label
    Private WithEvents cboDecodeMode As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents lblDestinationFormat As Label
    Private WithEvents cboDestinationFormat As ComboBox
    Private WithEvents grpID3Tags As GroupBox
    Private WithEvents lblTagComment As Label
    Private WithEvents txtTagTitle As TextBox
    Private WithEvents lblTagTrackNum As Label
    Private WithEvents lblTagTitle As Label
    Private WithEvents txtTagTrackNum As TextBox
    Private WithEvents txtTagYear As TextBox
    Private WithEvents lblTagCopyright As Label
    Private WithEvents lblTagYear As Label
    Private WithEvents txtTagCopyright As TextBox
    Private WithEvents txtTagComment As TextBox
    Private WithEvents lblTagAlbum As Label
    Private WithEvents txtTagAlbum As TextBox
    Private WithEvents cmdCheckLicense As Button
    Private WithEvents toolTip1 As ToolTip
    Private WithEvents grpDestinationFile As GroupBox
    Private WithEvents cmdPlayWithDefaultPlayer As Button
    Private WithEvents cmdOpenFileLocation As Button
    Private WithEvents lblDestinationFile As Label
    Friend WithEvents cboACMTags As ComboBox
    Friend WithEvents lblACMTag As Label
    Private WithEvents pnlACM As Panel
    Friend WithEvents cboACMFormats As ComboBox
    Friend WithEvents lblACMFormats As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents grpSource As GroupBox
    Private WithEvents timeTo2 As DateTimePicker
    Private WithEvents timeFrom2 As DateTimePicker
    Private WithEvents txtSourceMediaFile2 As TextBox
    Private WithEvents cmdSelectMediaFile2 As Button
    Private WithEvents txtSourceMediaFile1 As TextBox
    Private WithEvents cmdSelectMediaFile1 As Button
    Private WithEvents lblSourceMediaFile1 As Label
    Private WithEvents lblFrom1 As Label
    Private WithEvents lblTo1 As Label
    Private WithEvents lblTo2 As Label
    Private WithEvents lblSourceMediaFile2 As Label
    Private WithEvents lblFrom2 As Label
    Private WithEvents cmdPause As Button
    Private WithEvents cmdResume As Button
    Private WithEvents cmdCancel As Button
    Private WithEvents cmdConvert As Button
    Private WithEvents grpProgress As GroupBox
    Private WithEvents prgCurrentProgress As ProgressBar
    Private WithEvents lblCurrentProgress As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents AudioConverter1 As CSAudioConverter.AudioConverter
End Class
