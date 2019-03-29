#Region "LICENSE"
'
' Copyright (c) Microncode.com
' 
' This source is subject to the Microsoft Public License. 
' See https://opensource.org/licenses/ms-pl.html.
' All other rights reserved. 
' 
' THIS CODE And INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
' EITHER EXPRESSED Or IMPLIED, INCLUDING BUT Not LIMITED TO THE IMPLIED 
' WARRANTIES OF MERCHANTABILITY And/Or FITNESS FOR A PARTICULAR PURPOSE. 
'
#End Region

Imports System.IO
Imports System.Threading

Public Class frmAudioConverter
    Private Sub AudioConverter1_ConvertAborted() Handles AudioConverter1.ConvertAborted

    End Sub

    ''' <summary>
    ''' When the operation has done.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioConverter1_ConvertDone(sender As Object, e As EventArgs) Handles AudioConverter1.ConvertDone

        'Set the ID3 tags
        If (cboDestinationFormat.Text IsNot "WAV") AndAlso (cboDestinationFormat.Text IsNot "ACM") Then

            'Set the ID3 tags of the destination file:
            AudioConverter1.TagTitle = txtTagTitle.Text
            AudioConverter1.TagAlbum = txtTagAlbum.Text
            AudioConverter1.TagTrack = UInteger.Parse(txtTagTrackNum.Text)
            AudioConverter1.TagComment = txtTagComment.Text
            AudioConverter1.TagYear = txtTagYear.Text
            AudioConverter1.TagCopyright = txtTagCopyright.Text
            AudioConverter1.SetID3Tags(lblDestinationFile.Text)

        End If

        lblCurrentProgress.Text = "Done."
        cmdConvert.Enabled = True

    End Sub

    ''' <summary>
    ''' On error.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioConverter1_ConvertError(sender As Object, e As CSAudioConverter.MessageArgs) Handles AudioConverter1.ConvertError

        Console.WriteLine("Error: " + e.String)
        lblCurrentProgress.Text = "Error: " + e.String

        'Enable the control
        cmdConvert.Enabled = True

    End Sub

    ''' <summary>
    ''' On progress.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioConverter1_ConvertProgress(sender As Object, e As CSAudioConverter.PercentArgs) Handles AudioConverter1.ConvertProgress

        Dim sFileName As String = Path.GetFileName(AudioConverter1.SourceFiles(e.Track).File)
        lblCurrentProgress.Text = "Processing " & AudioConverter1.SourceFiles(e.Track).File
        prgCurrentProgress.Value = e.Number

    End Sub

    ''' <summary>
    ''' When start the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AudioConverter1_ConvertStart(sender As Object, e As EventArgs) Handles AudioConverter1.ConvertStart

        Console.WriteLine("Start.")

    End Sub

    ''' <summary>
    ''' Form_Load event. Load the audio properties from the AudioConverter control to the form controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AudioConverter1.UserName = "Your email"
        AudioConverter1.UserKey = "Your registration key"

#Region "LoadAudioProperties"

        'Formats:
        cboDestinationFormat.DataSource = AudioConverter1.GetFormats()
        cboDestinationFormat.Text = "MP3"

        'Bitrate
        cboBitrate.DataSource = AudioConverter1.GetBitrates()
        cboBitrate.Text = "192"

        'Samplerate
        cboSamplerate.DataSource = AudioConverter1.GetSamplerates()
        cboSamplerate.Text = "44100"

        'Bit depth
        cboBits.DataSource = AudioConverter1.GetBits()
        cboBits.Text = "16"

        'Channels
        cboChannels.DataSource = AudioConverter1.GetChannels()
        cboChannels.Text = "2"

        'Decoder Mode
        cboDecodeMode.DataSource = AudioConverter1.GetDecoderModes()
        cboDecodeMode.Text = "LocalCodecs"

        'Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth and channels:
        cboACMTags.DataSource = AudioConverter1.GetACMTags(CSAudioConverter.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16)
        cboACMTags.Text = "PCM"

#End Region

        'Set the current year of the ID3 tag
        txtTagYear.Text = DateTime.Now.Year.ToString()

#Region "AllFFmpegFormatsCodecs"

        'Display all the supported FFMpeg formats, codecs and extensions in the console:
        Dim Formats As List(Of CSAudioConverter.FFMpegFormat) = AudioConverter1.GetFFMpegFormats(Of List(Of CSAudioConverter.FFMpegFormat))()

        For Each sFormat In Formats
            Console.WriteLine("Format Name:")
            Console.WriteLine(sFormat.Name)
            Console.WriteLine("Format Name Long:")
            Console.WriteLine(sFormat.NameLong)

            For Each extension In sFormat.Extensions
                Console.WriteLine(" * " & extension)
            Next

            For Each codec In sFormat.Codecs
                Console.WriteLine(" - " & codec)
            Next
        Next

#End Region

    End Sub

    ''' <summary>
    ''' Set the destination file. This example use the default music folder of Windows.
    ''' </summary>
    Private Sub SetDestinationFileName()

        'Get the default music directory of Windows:
        Dim sDestinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\out." & cboDestinationFormat.Text.ToLower()

        'If the destination is ACM add the .WAV ext.
        If cboDestinationFormat.Text = "ACM" Then sDestinationFile = sDestinationFile & ".wav"

        'Set the lblDestinationFile:
        lblDestinationFile.Text = sDestinationFile

        'Set the destination file of the control:
        lblDestinationFile.Text = sDestinationFile

    End Sub

    ''' <summary>
    ''' Convert, join and cut the source audio file(s).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click

        'Check if already running:
        If AudioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
            MessageBox.Show("Already running.")
            Return
        End If

        'Check if there is source multimedia file to process:
        If txtSourceMediaFile1.Text = "" Then
            MessageBox.Show("Please select the SourceMediaFile1 to convert")
            Return
        End If

#Region "DecodeModeExplain"
        'Set the mode of the decoder, this can be the LocalCodecs which 
        'will use the codecs that installed On the system, Or FFMpeg 
        'which will use the FFMpeg libraries. If you decide to use the 
        'FFMpeg libraries, please make sure the FFMpeg folder with dll 
        'files is existed under the output directory of the project:
#End Region

        AudioConverter1.DecodeMode = CType([Enum].Parse(GetType(CSAudioConverter.DecodeMode), cboDecodeMode.Text), CSAudioConverter.DecodeMode)

        'Set the destination path and properties:
        SetDestinationFileName()

        'Set the destination file:
        AudioConverter1.DestinatioFile = lblDestinationFile.Text

        '[Optional Default is MP3]
        'Set the destination audio format, this can be AAC, APE, MP2, MP3, OGG, PCM WAV, ACM WAV And WMA
        AudioConverter1.Format = CType([Enum].Parse(GetType(CSAudioConverter.Format), cboDestinationFormat.Text), CSAudioConverter.Format)

#Region "MoreOptionalProperties"

        'If the destination format is ACM (WAV) set the ACM tag and format.
        If cboDestinationFormat.Text = "ACM" Then

            'Set the ACM tag and format:

            '[Optional: Default is WAV]
            AudioConverter1.ACMTag = cboACMTags.Text

            '[Optional: Default is 44100, 16, Stereo]
            AudioConverter1.ACMFormat = cboACMFormats.Text
        End If

        '[Optional: Default is 192]
        'Set the bitrate of the destination
        AudioConverter1.Bitrate = CType([Enum].Parse(GetType(CSAudioConverter.Bitrate), cboBitrate.Text), CSAudioConverter.Bitrate)
        'Or set by value
        'audioConverter1.BitrateVal = 192

        '[Optional: Default is 44100]
        'Set the sample rate of the destination (from 8000 to 48000)
        AudioConverter1.Samplerate = CType([Enum].Parse(GetType(CSAudioConverter.Samplerate), cboSamplerate.Text), CSAudioConverter.Samplerate)
        'Or set by value
        'audioConverter1.SamplerateVal = 48000

        '[Optional: Default is 16]
        'Set the bit-depth of the destination file (8, 16, 24, 32)
        AudioConverter1.Bits = CType([Enum].Parse(GetType(CSAudioConverter.Bits), cboBits.Text), CSAudioConverter.Bits)

        '[Optional: Default is 2]
        'Set the number of the channels of the destination file (1 Or 2)
        AudioConverter1.Channels = CType([Enum].Parse(GetType(CSAudioConverter.Channels), cboChannels.Text), CSAudioConverter.Channels)

#End Region

        'Add one Or more source multimedia files to the SourceFiles list. 
        'If you will add more then one source multimedia file to the list, 
        'the control will join them all into one multimedia file

        'First clear the SourceFiles list:
        AudioConverter1.SourceFiles.Clear()

        'Set the time length to converter:
        Dim from_time As TimeSpan = New TimeSpan(timeFrom1.Value.Hour, timeFrom1.Value.Minute, timeFrom1.Value.Second)
        Dim to_time As TimeSpan = New TimeSpan(timeTo1.Value.Hour, timeTo1.Value.Minute, timeTo1.Value.Second)

        'Add the file to the SourceFiles list:
        Dim sourceFile As Options.Core.SourceFile = New Options.Core.SourceFile(txtSourceMediaFile1.Text, from_time, to_time)

#Region "ExamplesOfAddingFiles"
        'If you want to convert all the file you can add source file without the from_time And the to_time
        'audioConverter1.SourceFiles.Add(New Options.Core.SourceFile(txtSourceMediaFile1.Text));

        'This will also convert all the file
        'audioConverter1.SourceFiles.Add(New Options.Core.SourceFile(txtSourceMediaFile1.Text, 0, 0));

        'This will convert from the from_time to the end of the file
        'audioConverter1.SourceFiles.Add(New Options.Core.SourceFile(txtSourceMediaFile1.Text, from_time, 0));
#End Region

        AudioConverter1.SourceFiles.Add(sourceFile)

        'Add the second multimedia file (for joining):
        If txtSourceMediaFile2.Text IsNot "" Then

            'Set the time length to converter of the second multimedia file:

            from_time = New TimeSpan(timeFrom2.Value.Hour, timeFrom2.Value.Minute, timeFrom2.Value.Second)
            to_time = New TimeSpan(timeTo2.Value.Hour, timeTo2.Value.Minute, timeTo2.Value.Second)

            'Add the second file to the SourceFiles list:
            AudioConverter1.SourceFiles.Add(New Options.Core.SourceFile(txtSourceMediaFile2.Text, from_time, to_time))

        End If

        'Add more multimedia files to join as adding the second multimedia file...

        'Run the process:
        AudioConverter1.Convert()

        'Disable the buttons controls until the process has ended:
        cmdConvert.Enabled = False

    End Sub

    ''' <summary>
    ''' Cancel the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        'Cancel
        AudioConverter1.Cancel()

    End Sub

    ''' <summary>
    ''' Pause the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click

        If AudioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
            AudioConverter1.Pause()
        End If

    End Sub

    ''' <summary>
    ''' Resume the operation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click

        If AudioConverter1.OperationState = CSAudioConverter.OperationState.Paused Then
            AudioConverter1.[Resume]()
        End If

    End Sub

    Private Function GetDateTime(ByVal fileProperties As Options.Core.FileProperties) As DateTime
        Dim dt As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        Dim ts As TimeSpan = New TimeSpan(1, fileProperties.Length.Hours, fileProperties.Length.Minutes, fileProperties.Length.Seconds, 0)
        dt = dt + ts
        Return dt
    End Function

    ''' <summary>
    ''' Select the first and the default multimedia file.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSelectMediaFile1_Click(sender As Object, e As EventArgs) Handles cmdSelectMediaFile1.Click

        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'Set the txtSourceMediaFile1:
            txtSourceMediaFile1.Text = openFileDialog1.FileName

#Region "DecodeModeExplain"
            'Set the mode of the decoder, this can be the LocalCodecs which 
            'will use the codecs that installed On the system, Or FFMpeg 
            'which will use the FFMpeg libraries. If you decide to use the 
            'FFMpeg libraries, please make sure the FFMpeg folder with dll 
            'files is existed under the output directory of the project:
#End Region
            AudioConverter1.DecodeMode = CType([Enum].Parse(GetType(CSAudioConverter.DecodeMode), cboDecodeMode.Text), CSAudioConverter.DecodeMode)

            'Open the first source multimedia file and get general file properties
            If Not AudioConverter1.Open(txtSourceMediaFile1.Text) Then
                MessageBox.Show("The source multimedia file is not supported.")
                txtSourceMediaFile1.Text = ""
                Return
            End If

            'Print the source multimedia properties to the console:
            Console.WriteLine(vbLf & "SampleRate: " & AudioConverter1.FileProperties.WaveFormat.SampleRate & vbLf & "BitsPerSample: " & AudioConverter1.FileProperties.WaveFormat.BytesPerSecond & vbLf & "Channels: " & AudioConverter1.FileProperties.WaveFormat.Channels)

            'The time length of the source multimedia file:
            Console.WriteLine(vbLf & "Time length: " & AudioConverter1.FileProperties.Length.ToString() & vbLf & "Total seconds: " & AudioConverter1.FileProperties.Length.TotalSeconds)

            'From 00:00:00
            timeFrom1.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

            'To the time-length of the source file:
            timeTo1.Value = GetDateTime(AudioConverter1.FileProperties)

            'Get the ID3 tags of the source multimedia files:
            txtTagTitle.Text = AudioConverter1.TagTitle
            txtTagAlbum.Text = AudioConverter1.TagAlbum
            txtTagTrackNum.Text = AudioConverter1.TagTrack.ToString()
            txtTagComment.Text = AudioConverter1.TagComment
            txtTagYear.Text = AudioConverter1.TagYear
            txtTagCopyright.Text = AudioConverter1.TagCopyright

        End If

    End Sub

    ''' <summary>
    ''' Select the second multimedia file (for joining).
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSelectMediaFile2_Click(sender As Object, e As EventArgs) Handles cmdSelectMediaFile2.Click

        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'Set the txtSourceMediaFile2:
            txtSourceMediaFile2.Text = openFileDialog1.FileName

            'Get general file properties
            If Not AudioConverter1.Open(txtSourceMediaFile2.Text) Then
                MessageBox.Show("The source multimedia file is not supported.")
                Return
            End If

            'Print the source multimedia properties to the console:
            Console.WriteLine(vbLf & "SampleRate: " & AudioConverter1.FileProperties.WaveFormat.SampleRate & vbLf & "BitsPerSample: " & AudioConverter1.FileProperties.WaveFormat.BitsPerSample & vbLf & "Channels: " & AudioConverter1.FileProperties.WaveFormat.Channels)

            'The time length of the source multimedia file:
            Console.WriteLine(vbLf & "Time length: " & AudioConverter1.FileProperties.Length.ToString() & vbLf & "Total seconds: " & AudioConverter1.FileProperties.Length.TotalSeconds)

            'From 00:00:00
            timeFrom2.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

            'To the time-length of the source file:
            timeTo2.Value = GetDateTime(AudioConverter1.FileProperties)
        End If

    End Sub

    ''' <summary>
    ''' Get ACM formats according to the selected tag.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboACMTags_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboACMTags.SelectedIndexChanged

        cboACMFormats.DataSource = AudioConverter1.GetACMFormats(cboACMTags.Text)
        cboACMFormats.SelectedIndex = 0

    End Sub

    ''' <summary>
    ''' When selecting the ACM WAV format, display the ACM Tags and Formats.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cboDestinationFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestinationFormat.SelectedIndexChanged

        'Set the destination:
        SetDestinationFileName()

        lblBits.Visible = False
        cboBits.Visible = False
        pnlACM.Visible = False

        If cboDestinationFormat.Text = "ACM" Then
            'Display the ACM settings
            pnlACM.Visible = True
            pnlACM.Left = 30
            pnlACM.Top = 340
        End If

        If cboDestinationFormat.Text = "WAV" Then
            'Display the bit-depth combo box
            lblBits.Visible = True
            cboBits.Visible = True
        End If

    End Sub

    Private Sub cmdPlayWithDefaultPlayer_Click(sender As Object, e As EventArgs) Handles cmdPlayWithDefaultPlayer.Click
        If lblDestinationFile.Text = "" Then Return
        Process.Start(lblDestinationFile.Text)
    End Sub

    Private Sub cmdOpenFileLocation_Click(sender As Object, e As EventArgs) Handles cmdOpenFileLocation.Click
        Dim argument As String = "/select, """ & lblDestinationFile.Text & """"
        Process.Start("explorer.exe", argument)
    End Sub

    Private Sub cmdCheckLicense_Click(sender As Object, e As EventArgs) Handles cmdCheckLicense.Click

        If AudioConverter1.CheckLicense() Then MessageBox.Show("Registration is OK")

    End Sub

    ''' <summary>
    ''' Safe exit.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmAudioConverter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If AudioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
            AudioConverter1.Cancel()

            While AudioConverter1.OperationState <> CSAudioConverter.OperationState.Ready
                Application.DoEvents()
                Thread.Sleep(100)
            End While
        End If

    End Sub
End Class
