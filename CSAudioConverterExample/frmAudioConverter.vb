Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Xml.Serialization

Namespace CSAudioConverterExample
    Public Partial Class frmAudioConverter
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub audioConverter1_ConvertDone(ByVal sender As Object, ByVal e As EventArgs)
            If (cboDestinationFormat.Text IsNot "WAV") AndAlso (cboDestinationFormat.Text IsNot "ACM") Then
                audioConverter1.TagTitle = txtTagTitle.Text
                audioConverter1.TagAlbum = txtTagAlbum.Text
                audioConverter1.TagTrack = UInteger.Parse(txtTagTrackNum.Text)
                audioConverter1.TagComment = txtTagComment.Text
                audioConverter1.TagYear = txtTagYear.Text
                audioConverter1.TagCopyright = txtTagCopyright.Text
                audioConverter1.SetID3Tags(lblDestinationFile.Text)
            End If

            lblCurrentProgress.Text = "Done."
            cmdConvert.Enabled = True
        End Sub

        Private Sub audioConverter1_ConvertStart(ByVal sender As Object, ByVal e As EventArgs)
            Console.WriteLine("Start.")
        End Sub

        Private Sub audioConverter1_ConvertProgress(ByVal sender As Object, ByVal e As CSAudioConverter.PercentArgs)
            Dim sFileName As String = Path.GetFileName(audioConverter1.SourceFiles(e.Track).File)
            lblCurrentProgress.Text = "Processing " & audioConverter1.SourceFiles(e.Track).File
            prgCurrentProgress.Value = e.Number
        End Sub

        Private Sub audioConverter1_ConvertError(ByVal sender As Object, ByVal e As CSAudioConverter.MessageArgs)
            Console.WriteLine("Error: " & e.String)
            cmdConvert.Enabled = True
        End Sub

        Private Sub frmAudioConverter_Load(ByVal sender As Object, ByVal e As EventArgs)
            audioConverter1.UserName = "Your email"
            audioConverter1.UserKey = "Your registration key"
            cboDestinationFormat.DataSource = audioConverter1.GetFormats()
            cboDestinationFormat.Text = "MP3"
            cboBitrate.DataSource = audioConverter1.GetBitrates()
            cboBitrate.Text = "192"
            cboSamplerate.DataSource = audioConverter1.GetSamplerates()
            cboSamplerate.Text = "44100"
            cboBits.DataSource = audioConverter1.GetBits()
            cboBits.Text = "16"
            cboChannels.DataSource = audioConverter1.GetChannels()
            cboChannels.Text = "2"
            cboDecodeMode.DataSource = audioConverter1.GetDecoderModes()
            cboDecodeMode.Text = "LocalCodecs"
            cboACMTags.DataSource = audioConverter1.GetACMTags(CSAudioConverter.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16)
            cboACMTags.Text = "PCM"
            txtTagYear.Text = DateTime.Now.Year.ToString()
            Dim Formats As List(Of CSAudioConverter.FFMpegFormat) = audioConverter1.GetFFMpegFormats(Of List(Of CSAudioConverter.FFMpegFormat))()

            For Each format In Formats
                Console.WriteLine("Format Name:")
                Console.WriteLine(format.Name)
                Console.WriteLine("Format Name Long:")
                Console.WriteLine(format.NameLong)

                For Each extension In format.Extensions
                    Console.WriteLine(" * " & extension)
                Next

                For Each codec In format.Codecs
                    Console.WriteLine(" - " & codec)
                Next
            Next
        End Sub

        Private Sub SetDestinationFileName()
            Dim sDestinationFile As String = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\out." & cboDestinationFormat.Text.ToLower()
            If cboDestinationFormat.Text Is "ACM" Then sDestinationFile = sDestinationFile & ".wav"
            lblDestinationFile.Text = sDestinationFile
            lblDestinationFile.Text = sDestinationFile
        End Sub

        Private Sub cmdConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
                MessageBox.Show("Already running.")
                Return
            End If

            If txtSourceMediaFile1.Text Is "" Then
                MessageBox.Show("Please select the SourceMediaFile1 to convert")
                Return
            End If

            audioConverter1.DecodeMode = CType([Enum].Parse(GetType(CSAudioConverter.DecodeMode), cboDecodeMode.Text), CSAudioConverter.DecodeMode)
            SetDestinationFileName()
            audioConverter1.DestinatioFile = lblDestinationFile.Text
            audioConverter1.Format = CType([Enum].Parse(GetType(CSAudioConverter.Format), cboDestinationFormat.Text), CSAudioConverter.Format)

            If cboDestinationFormat.Text Is "ACM" Then
                audioConverter1.ACMTag = cboACMTags.Text
                audioConverter1.ACMFormat = cboACMFormats.Text
            End If

            audioConverter1.Bitrate = CType([Enum].Parse(GetType(CSAudioConverter.Bitrate), cboBitrate.Text), CSAudioConverter.Bitrate)
            audioConverter1.Samplerate = CType([Enum].Parse(GetType(CSAudioConverter.Samplerate), cboSamplerate.Text), CSAudioConverter.Samplerate)
            audioConverter1.Bits = CType([Enum].Parse(GetType(CSAudioConverter.Bits), cboBits.Text), CSAudioConverter.Bits)
            audioConverter1.Channels = CType([Enum].Parse(GetType(CSAudioConverter.Channels), cboChannels.Text), CSAudioConverter.Channels)
            audioConverter1.SourceFiles.Clear()
            Dim from_time As TimeSpan = New TimeSpan(timeFrom1.Value.Hour, timeFrom1.Value.Minute, timeFrom1.Value.Second)
            Dim to_time As TimeSpan = New TimeSpan(timeTo1.Value.Hour, timeTo1.Value.Minute, timeTo1.Value.Second)
            Dim sourceFile As Options.Core.SourceFile = New Options.Core.SourceFile(txtSourceMediaFile1.Text, from_time, to_time)
            audioConverter1.SourceFiles.Add(sourceFile)

            If txtSourceMediaFile2.Text IsNot "" Then
                from_time = New TimeSpan(timeFrom2.Value.Hour, timeFrom2.Value.Minute, timeFrom2.Value.Second)
                to_time = New TimeSpan(timeTo2.Value.Hour, timeTo2.Value.Minute, timeTo2.Value.Second)
                audioConverter1.SourceFiles.Add(New Options.Core.SourceFile(txtSourceMediaFile2.Text, from_time, to_time))
            End If

            audioConverter1.Convert()
            cmdConvert.Enabled = False
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            audioConverter1.Cancel()
        End Sub

        Private Sub cmdPause_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
                audioConverter1.Pause()
            End If
        End Sub

        Private Sub cmdResume_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioConverter1.OperationState = CSAudioConverter.OperationState.Paused Then
                audioConverter1.[Resume]()
            End If
        End Sub

        Private Function GetDateTime(ByVal fileProperties As Options.Core.FileProperties) As DateTime
            Dim dt As DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
            Dim ts As TimeSpan = New TimeSpan(1, fileProperties.Length.Hours, fileProperties.Length.Minutes, fileProperties.Length.Seconds, 0)
            dt = dt + ts
            Return dt
        End Function

        Private Sub cmdSelectMediaFile1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtSourceMediaFile1.Text = openFileDialog1.FileName
                audioConverter1.DecodeMode = CType([Enum].Parse(GetType(CSAudioConverter.DecodeMode), cboDecodeMode.Text), CSAudioConverter.DecodeMode)

                If Not audioConverter1.Open(txtSourceMediaFile1.Text) Then
                    MessageBox.Show("The source multimedia file is not supported.")
                    txtSourceMediaFile1.Text = ""
                    Return
                End If

                Console.WriteLine(vbLf & "SampleRate: " & audioConverter1.FileProperties.WaveFormat.SampleRate & vbLf & "BitsPerSample: " & audioConverter1.FileProperties.WaveFormat.BytesPerSecond & vbLf & "Channels: " & audioConverter1.FileProperties.WaveFormat.Channels)
                Console.WriteLine(vbLf & "Time length: " & audioConverter1.FileProperties.Length & vbLf & "Total seconds: " & audioConverter1.FileProperties.Length.TotalSeconds)
                timeFrom1.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                timeTo1.Value = GetDateTime(audioConverter1.FileProperties)
                txtTagTitle.Text = audioConverter1.TagTitle
                txtTagAlbum.Text = audioConverter1.TagAlbum
                txtTagTrackNum.Text = audioConverter1.TagTrack.ToString()
                txtTagComment.Text = audioConverter1.TagComment
                txtTagYear.Text = audioConverter1.TagYear
                txtTagCopyright.Text = audioConverter1.TagCopyright
            End If
        End Sub

        Private Sub cmdSelectMediaFile2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog()

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtSourceMediaFile2.Text = openFileDialog1.FileName

                If Not audioConverter1.Open(txtSourceMediaFile2.Text) Then
                    MessageBox.Show("The source multimedia file is not supported.")
                    Return
                End If

                Console.WriteLine(vbLf & "SampleRate: " & audioConverter1.FileProperties.WaveFormat.SampleRate & vbLf & "BitsPerSample: " & audioConverter1.FileProperties.WaveFormat.BitsPerSample & vbLf & "Channels: " & audioConverter1.FileProperties.WaveFormat.Channels)
                Console.WriteLine(vbLf & "Time length: " & audioConverter1.FileProperties.Length & vbLf & "Total seconds: " & audioConverter1.FileProperties.Length.TotalSeconds)
                timeFrom2.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
                timeTo2.Value = GetDateTime(audioConverter1.FileProperties)
            End If
        End Sub

        Private Sub cboACMTags_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            cboACMFormats.DataSource = audioConverter1.GetACMFormats(cboACMTags.Text)
            cboACMFormats.SelectedIndex = 0
        End Sub

        Private Sub cboDetinationFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            SetDestinationFileName()
            lblBits.Visible = False
            cboBits.Visible = False
            pnlACM.Visible = False

            If cboDestinationFormat.Text Is "ACM" Then
                pnlACM.Visible = True
                pnlACM.Left = 34
                pnlACM.Top = 360
            End If

            If cboDestinationFormat.Text Is "WAV" Then
                lblBits.Visible = True
                cboBits.Visible = True
            End If
        End Sub

        Private Sub cmdPlayWithDefaultPlayer_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblDestinationFile.Text Is "" Then Return
            Process.Start(lblDestinationFile.Text)
        End Sub

        Private Sub cmdOpenFileLocation_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim argument As String = "/select, """ & lblDestinationFile.Text & """"
            Process.Start("explorer.exe", argument)
        End Sub

        Private Sub cmdID3Tags_Click(ByVal sender As Object, ByVal e As EventArgs)
            If lblDestinationFile.Text Is "" Then Return
            Dim frmAllID3Tags As frmID3TagsEditor = New frmID3TagsEditor()
            frmAllID3Tags.ShowDialog(Me)
        End Sub

        Private Sub cmdCheckLicense_Click(ByVal sender As Object, ByVal e As EventArgs)
            If audioConverter1.CheckLicense() Then MessageBox.Show("Registration is OK")
        End Sub

        Private Sub frmAudioConverter_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If audioConverter1.OperationState = CSAudioConverter.OperationState.Running Then
                audioConverter1.Cancel()

                While audioConverter1.OperationState <> CSAudioConverter.OperationState.Ready
                    Application.DoEvents()
                    Thread.Sleep(100)
                End While
            End If
        End Sub
    End Class
End Namespace
