#region LICENSE
//
// Copyright (c) Microncode.com
// 
// This source is subject to the Microsoft Public License. 
// See https://opensource.org/licenses/ms-pl.html.
// All other rights reserved. 
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
// WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSAudioConverterExample
{
    public partial class frmAudioConverter : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public frmAudioConverter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the operation has done.
        /// </summary>
        private void audioConverter1_ConvertDone(object sender, EventArgs e)
        {
            //Set the ID3 tags
            if ((cboDestinationFormat.Text != "WAV") && (cboDestinationFormat.Text != "ACM"))
            {
                //Set the ID3 tags of the destination file:
                audioConverter1.TagTitle = txtTagTitle.Text;
                audioConverter1.TagAlbum = txtTagAlbum.Text;
                audioConverter1.TagTrack = uint.Parse(txtTagTrackNum.Text);
                audioConverter1.TagComment = txtTagComment.Text;
                audioConverter1.TagYear = txtTagYear.Text;
                audioConverter1.TagCopyright = txtTagCopyright.Text;
                audioConverter1.SetID3Tags(lblDestinationFile.Text);
            }

            lblCurrentProgress.Text = "Done.";
            cmdConvert.Enabled = true;
        }

        /// <summary>
        /// When start the operation.
        /// </summary>
        private void audioConverter1_ConvertStart(object sender, EventArgs e)
        {
            Console.WriteLine("Start.");
        }

        /// <summary>
        /// On progress.
        /// </summary>
        private void audioConverter1_ConvertProgress(object sender, CSAudioConverter.PercentArgs e)
        {
            string sFileName = Path.GetFileName(audioConverter1.SourceFiles[e.Track].File);

            lblCurrentProgress.Text = "Processing " + audioConverter1.SourceFiles[e.Track].File;
            prgCurrentProgress.Value = e.Number;
        }

        /// <summary>
        /// On error.
        /// </summary>
        private void audioConverter1_ConvertError(object sender, CSAudioConverter.MessageArgs e)
        {
            Console.WriteLine("Error: " + e.String);
            lblCurrentProgress.Text = "Error: " + e.String;
            
            //Enable the control:
            cmdConvert.Enabled = true;

        }

        /// <summary>
        /// Form_Load event. Load the audio properties from the AudioConverter control to the form controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioConverter_Load(object sender, EventArgs e)
        {
            audioConverter1.UserName = "Your email";
            audioConverter1.UserKey = "Your registration key";

            #region LoadAudioProperties

            //Formats:
            cboDestinationFormat.DataSource = audioConverter1.GetFormats();
            cboDestinationFormat.Text = "MP3";

            //Bitrate
            cboBitrate.DataSource = audioConverter1.GetBitrates();
            cboBitrate.Text = "192";

            //Samplerate
            cboSamplerate.DataSource = audioConverter1.GetSamplerates();
            cboSamplerate.Text = "44100";

            //Bit depth
            cboBits.DataSource = audioConverter1.GetBits();
            cboBits.Text = "16";

            //Channels
            cboChannels.DataSource = audioConverter1.GetChannels();
            cboChannels.Text = "2";

            //Decoder Mode
            cboDecodeMode.DataSource = audioConverter1.GetDecoderModes();
            cboDecodeMode.Text = "LocalCodecs";

            //Get all the ACM Tags that installed in the system (for ACM WAV) according to the sample-rate, bits-depth and channels:
            cboACMTags.DataSource = audioConverter1.GetACMTags(CSAudioConverter.ACM_FORMAT.ACM_FORMATENUMF_CONVERT, 1, 44100, 2, 16);
            cboACMTags.Text = "PCM";

            #endregion
            
            //Set the current year of the ID3 tag:
            txtTagYear.Text = DateTime.Now.Year.ToString();

            #region AllFFmpegFormatsCodecs
            
            //Display all the supported FFMpeg formats, codecs and extensions in the console:

            //Get the formats from the control:
            List<CSAudioConverter.FFMpegFormat> Formats = audioConverter1.GetFFMpegFormats<List<CSAudioConverter.FFMpegFormat>>();

            //Loop through all the formats:
            foreach (var format in Formats)
            {
                Console.WriteLine("Format Name:");
                Console.WriteLine(format.Name);

                Console.WriteLine("Format Name Long:");
                Console.WriteLine(format.NameLong);

                //Loop through all the extensions:
                foreach (var extension in format.Extensions)
                {
                    Console.WriteLine(" * " + extension);
                }

                //Loop through all the codecs:
                foreach (var codec in format.Codecs)
                {
                    Console.WriteLine(" - " + codec);
                }
            }
            

            #endregion

        }

        /// <summary>
        /// Set the destination file. This example use the default music folder of Windows.
        /// </summary>
        private void SetDestinationFileName()
        {
            //Get the default music directory of Windows:
            string sDestinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "\\out." + cboDestinationFormat.Text.ToLower();

            //If the destination is ACM add the .WAV ext.
            if (cboDestinationFormat.Text == "ACM")
                sDestinationFile = sDestinationFile + ".wav";

            //Set the lblDestinationFile:
            lblDestinationFile.Text = sDestinationFile;

            //Set the destination file of the control:
            lblDestinationFile.Text = sDestinationFile;
        }

        /// <summary>
        /// Convert, join and cut the source audio file(s).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConvert_Click(object sender, EventArgs e)
        {
            //Check if already running:
            if(audioConverter1.OperationState == CSAudioConverter.OperationState.Running)
            {
                MessageBox.Show("Already running.");
                return;
            }

            //Check if there is source multimedia file to process:
            if (txtSourceMediaFile1.Text == "")
            {
                MessageBox.Show("Please select the SourceMediaFile1 to convert");
                return;
            }

            #region DecodeModeExplain
            /*
            Set the mode of the decoder, this can be the LocalCodecs which 
            will use the codecs that installed on the system, or FFMpeg 
            which will use the FFMpeg libraries. If you decide to use the 
            FFMpeg libraries, please make sure the FFMpeg folder with dll 
            files is existed under the output directory of the project:
            */
            #endregion
            audioConverter1.DecodeMode = (CSAudioConverter.DecodeMode)Enum.Parse(typeof(CSAudioConverter.DecodeMode), cboDecodeMode.Text);

            //Set the destination path and properties:
            SetDestinationFileName();

            //Set the destination file:
            audioConverter1.DestinatioFile = lblDestinationFile.Text;

            //[Optional: Default is MP3]
            //Set the destination audio format, this can be AAC, APE, MP2, MP3, OGG, PCM WAV, ACM WAV and WMA:
            audioConverter1.Format = (CSAudioConverter.Format)Enum.Parse(typeof(CSAudioConverter.Format), cboDestinationFormat.Text);

            #region MoreOptionalProperties

            //If the destination format is ACM (WAV) set the ACM tag and format.
            if (cboDestinationFormat.Text == "ACM")
            {
                //Set the ACM tag and format:

                //[Optional: Default is WAV]
                audioConverter1.ACMTag = cboACMTags.Text;

                //[Optional: Default is 44100, 16, Stereo]
                audioConverter1.ACMFormat = cboACMFormats.Text;
            }

            //[Optional: Default is 192]
            //Set the bitrate of the destination:
            audioConverter1.Bitrate = (CSAudioConverter.Bitrate)Enum.Parse(typeof(CSAudioConverter.Bitrate), cboBitrate.Text);
            //Or set by value
            //audioConverter1.BitrateVal = 192;

            //[Optional: Default is 44100]
            //Set the sample rate of the destination (from 8000 to 48000):
            audioConverter1.Samplerate = (CSAudioConverter.Samplerate)Enum.Parse(typeof(CSAudioConverter.Samplerate), cboSamplerate.Text);
            //Or set by value
            //audioConverter1.SamplerateVal = 48000;

            //[Optional: Default is 16]
            //Set the bit-depth of the destination file (8, 16, 24, 32):
            audioConverter1.Bits = (CSAudioConverter.Bits)Enum.Parse(typeof(CSAudioConverter.Bits), cboBits.Text);

            //[Optional: Default is 2]
            //Set the number of the channels of the destination file (1 or 2):
            audioConverter1.Channels = (CSAudioConverter.Channels)Enum.Parse(typeof(CSAudioConverter.Channels), cboChannels.Text);

            #endregion

            //Add one or more source multimedia files to the SourceFiles list. 
            //If you will add more then one source multimedia file to the list, 
            //the control will join them all into one multimedia file:

            //First clear the SourceFiles list:
            audioConverter1.SourceFiles.Clear();

            //Set the time length to converter:
            TimeSpan from_time = new TimeSpan(timeFrom1.Value.Hour, timeFrom1.Value.Minute, timeFrom1.Value.Second);
            TimeSpan to_time = new TimeSpan(timeTo1.Value.Hour, timeTo1.Value.Minute, timeTo1.Value.Second);

            //Add the file to the SourceFiles list:
            Options.Core.SourceFile sourceFile = new Options.Core.SourceFile(txtSourceMediaFile1.Text, from_time, to_time);

            audioConverter1.SourceFiles.Add(sourceFile);

            #region ExamplesOfAddingFiles
            //If you want to convert all the file you can add source file without the from_time and the to_time:
            //audioConverter1.SourceFiles.Add(new Options.Core.SourceFile(txtSourceMediaFile1.Text));

            //This will also convert all the file:
            //audioConverter1.SourceFiles.Add(new Options.Core.SourceFile(txtSourceMediaFile1.Text, 0, 0));

            //This will convert from the from_time to the end of the file:
            //audioConverter1.SourceFiles.Add(new Options.Core.SourceFile(txtSourceMediaFile1.Text, from_time, 0));
            #endregion
            
            // Add the second multimedia file (for joining):
            if (txtSourceMediaFile2.Text != "")
            {
                //Set the time length to converter of the second multimedia file:

                from_time = new TimeSpan(timeFrom2.Value.Hour, timeFrom2.Value.Minute, timeFrom2.Value.Second);
                to_time = new TimeSpan(timeTo2.Value.Hour, timeTo2.Value.Minute, timeTo2.Value.Second);

                //Add the second file to the SourceFiles list:
                audioConverter1.SourceFiles.Add(new Options.Core.SourceFile(txtSourceMediaFile2.Text, from_time, to_time));
            }

            //Add more multimedia files to join as adding the second multimedia file...

            //Run the process:
            audioConverter1.Convert();

            //Disable the buttons controls until the process has ended:
            cmdConvert.Enabled = false;
        }

        /// <summary>
        /// Cancel the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //Cancel:
            audioConverter1.Cancel();
        }

        /// <summary>
        /// Pause the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPause_Click(object sender, EventArgs e)
        {
            //Check if the process is running:
            if (audioConverter1.OperationState == CSAudioConverter.OperationState.Running)
            {
                audioConverter1.Pause();
            }
        }

        /// <summary>
        /// Resume the operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdResume_Click(object sender, EventArgs e)
        {
            //Check if the process is paused:
            if (audioConverter1.OperationState == CSAudioConverter.OperationState.Paused)
            {
                audioConverter1.Resume();
            }
        }

        /// <summary>
        /// Get the length time of the source file.
        /// </summary>
        /// <param name="fileProperties"></param>
        /// <returns></returns>
        private DateTime GetDateTime(Options.Core.FileProperties fileProperties)
        {
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeSpan ts = new TimeSpan(1, fileProperties.Length.Hours, fileProperties.Length.Minutes, fileProperties.Length.Seconds, 0);
            dt = dt + ts;

            return dt;
        }

        /// <summary>
        /// Select the first and the default multimedia file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSelectMediaFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Set the txtSourceMediaFile1:
                txtSourceMediaFile1.Text =  openFileDialog1.FileName;

                #region DecodeModeExplain
                /*
                Set the mode of the decoder, this can be the LocalCodecs which 
                will use the codecs that installed on the system, or FFMpeg 
                which will use the FFMpeg libraries. If you decide to use the 
                FFMpeg libraries, please make sure the FFMpeg folder with dll 
                files is existed under the output directory of the project:
                */
                #endregion
                audioConverter1.DecodeMode = (CSAudioConverter.DecodeMode)Enum.Parse(typeof(CSAudioConverter.DecodeMode), cboDecodeMode.Text);

                //Open the first source multimedia file and get general file properties
                if (!audioConverter1.Open(txtSourceMediaFile1.Text))
                {
                    MessageBox.Show("The source multimedia file is not supported.");
                    txtSourceMediaFile1.Text = "";
                    return;
                }

                //Print the source multimedia properties to the console:
                Console.WriteLine("\nSampleRate: " + audioConverter1.FileProperties.WaveFormat.SampleRate +
                                    "\nBitsPerSample: " + audioConverter1.FileProperties.WaveFormat.BytesPerSecond +
                                    "\nChannels: " + audioConverter1.FileProperties.WaveFormat.Channels);

                //The time length of the source multimedia file:
                Console.WriteLine("\nTime length: " + audioConverter1.FileProperties.Length +
                                    "\nTotal seconds: " + audioConverter1.FileProperties.Length.TotalSeconds);

                //From 00:00:00
                timeFrom1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                //To the time-length of the source file:
                timeTo1.Value = GetDateTime(audioConverter1.FileProperties);

                //Get the ID3 tags of the source multimedia files:
                txtTagTitle.Text = audioConverter1.TagTitle;
                txtTagAlbum.Text = audioConverter1.TagAlbum;
                txtTagTrackNum.Text = audioConverter1.TagTrack.ToString();
                txtTagComment.Text = audioConverter1.TagComment;
                txtTagYear.Text = audioConverter1.TagYear;
                txtTagCopyright.Text = audioConverter1.TagCopyright;
            }
        }

        /// <summary>
        /// Select the second multimedia file (for joining).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSelectMediaFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Set the txtSourceMediaFile2:
                txtSourceMediaFile2.Text = openFileDialog1.FileName;

                //Get general file properties
                if (!audioConverter1.Open(txtSourceMediaFile2.Text))
                {
                    MessageBox.Show("The source multimedia file is not supported.");
                    return;
                }

                //Print the source multimedia properties to the console:
                Console.WriteLine("\nSampleRate: " + audioConverter1.FileProperties.WaveFormat.SampleRate +
                                    "\nBitsPerSample: " + audioConverter1.FileProperties.WaveFormat.BitsPerSample +
                                    "\nChannels: " + audioConverter1.FileProperties.WaveFormat.Channels);

                //The time length of the source multimedia file:
                Console.WriteLine("\nTime length: " + audioConverter1.FileProperties.Length +
                                    "\nTotal seconds: " + audioConverter1.FileProperties.Length.TotalSeconds);
                
                //From 00:00:00
                timeFrom2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                //To the time-length of the source file:
                timeTo2.Value = GetDateTime(audioConverter1.FileProperties);
            }
        }

        /// <summary>
        /// Get ACM formats according to the selected tag.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboACMTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboACMFormats.DataSource = audioConverter1.GetACMFormats(cboACMTags.Text);

            cboACMFormats.SelectedIndex = 0;
        }

        /// <summary>
        /// When selecting the ACM WAV format, display the ACM Tags and Formats.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDetinationFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Set the destination:
            SetDestinationFileName();

            lblBits.Visible = false;
            cboBits.Visible = false;
            pnlACM.Visible = false;

            if (cboDestinationFormat.Text == "ACM")
            {
                //Display the ACM settings
                pnlACM.Visible = true;
                pnlACM.Left = 34;
                pnlACM.Top = 340;
            }

            if (cboDestinationFormat.Text == "WAV")
            {
                //Display the bit-depth combo box
                lblBits.Visible = true;
                cboBits.Visible = true;
            }

        }

        /// <summary>
        /// Open the destination multimedia file with the default multimedia player of the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlayWithDefaultPlayer_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            Process.Start(lblDestinationFile.Text);
        }

        /// <summary>
        /// Open the directory of the destination multimedia file with the WIndows Explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOpenFileLocation_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + lblDestinationFile.Text + "\"";

            Process.Start("explorer.exe", argument);
        }

        /// <summary>
        /// Show the frmID3TagsEditor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdID3Tags_Click(object sender, EventArgs e)
        {
            if (lblDestinationFile.Text == "") return;

            frmID3TagsEditor frmAllID3Tags = new frmID3TagsEditor();

            //frmAllID3Tags.LoadFile(lblDestinationFile.Text);
            frmAllID3Tags.ShowDialog(this);
        }

        /// <summary>
        /// Check the license.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCheckLicense_Click(object sender, EventArgs e)
        {
            if (audioConverter1.CheckLicense())
                MessageBox.Show("Registration is OK");
        }

        /// <summary>
        /// Safe exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAudioConverter_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region SafeExit
            
            //Check if already running:
            if (audioConverter1.OperationState == CSAudioConverter.OperationState.Running)
            {
                //Stop:
                audioConverter1.Cancel();

                //Wait for the ready state
                while (audioConverter1.OperationState != CSAudioConverter.OperationState.Ready)
                {
                    Application.DoEvents();
                    Thread.Sleep(100);
                }
            }

            #endregion
        }

    }
}
