namespace CSAudioConverterExample
{
    partial class frmID3TagsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmID3TagsEditor));
            this.lblTagComment = new System.Windows.Forms.Label();
            this.txtTagComment = new System.Windows.Forms.TextBox();
            this.lblTagYear = new System.Windows.Forms.Label();
            this.txtTagYear = new System.Windows.Forms.TextBox();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblTagTitle = new System.Windows.Forms.Label();
            this.txtTagTitle = new System.Windows.Forms.TextBox();
            this.lblTagAlbum = new System.Windows.Forms.Label();
            this.txtTagAlbum = new System.Windows.Forms.TextBox();
            this.lblTagCopyright = new System.Windows.Forms.Label();
            this.txtTagCopyright = new System.Windows.Forms.TextBox();
            this.lblTagGenres = new System.Windows.Forms.Label();
            this.cboTagGenres = new System.Windows.Forms.ComboBox();
            this.txtMediaFile = new System.Windows.Forms.TextBox();
            this.lblMediaFile = new System.Windows.Forms.Label();
            this.cmdOpenMediaFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblTagTrackNum = new System.Windows.Forms.Label();
            this.txtTagTrackNum = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lstTagArtists = new System.Windows.Forms.ListBox();
            this.lstTagImages = new System.Windows.Forms.ListBox();
            this.cmdTagArtistsAdd = new System.Windows.Forms.Button();
            this.cmdTagArtistsRemove = new System.Windows.Forms.Button();
            this.lstTagGenres = new System.Windows.Forms.ListBox();
            this.cmdTagGenresRemove = new System.Windows.Forms.Button();
            this.cmdTagGenresAdd = new System.Windows.Forms.Button();
            this.lblTagLyrics = new System.Windows.Forms.Label();
            this.txtTagLyrics = new System.Windows.Forms.TextBox();
            this.cmdClearAllTags = new System.Windows.Forms.Button();
            this.cmdTagImagesRemove = new System.Windows.Forms.Button();
            this.cmdTagImagesAdd = new System.Windows.Forms.Button();
            this.cmdTagArtistsUp = new System.Windows.Forms.Button();
            this.cmdTagArtistsDown = new System.Windows.Forms.Button();
            this.cmdTagGenresDown = new System.Windows.Forms.Button();
            this.cmdTagGenresUp = new System.Windows.Forms.Button();
            this.cmdTagImagesDown = new System.Windows.Forms.Button();
            this.cmdTagImagesUp = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdTagComposersDown = new System.Windows.Forms.Button();
            this.cmdTagComposersUp = new System.Windows.Forms.Button();
            this.cmdTagComposersRemove = new System.Windows.Forms.Button();
            this.cmdTagComposersAdd = new System.Windows.Forms.Button();
            this.lstTagComposers = new System.Windows.Forms.ListBox();
            this.lblTagComposers = new System.Windows.Forms.Label();
            this.cboTagRating = new System.Windows.Forms.ComboBox();
            this.lblTagRating = new System.Windows.Forms.Label();
            this.lblImages = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.audioConverter1 = new CSAudioConverter.AudioConverter();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTagComment
            // 
            this.lblTagComment.AutoSize = true;
            this.lblTagComment.Location = new System.Drawing.Point(32, 180);
            this.lblTagComment.Name = "lblTagComment";
            this.lblTagComment.Size = new System.Drawing.Size(51, 13);
            this.lblTagComment.TabIndex = 16;
            this.lblTagComment.Text = "Comment";
            // 
            // txtTagComment
            // 
            this.txtTagComment.Location = new System.Drawing.Point(35, 196);
            this.txtTagComment.Name = "txtTagComment";
            this.txtTagComment.Size = new System.Drawing.Size(469, 20);
            this.txtTagComment.TabIndex = 15;
            // 
            // lblTagYear
            // 
            this.lblTagYear.AutoSize = true;
            this.lblTagYear.Location = new System.Drawing.Point(519, 180);
            this.lblTagYear.Name = "lblTagYear";
            this.lblTagYear.Size = new System.Drawing.Size(29, 13);
            this.lblTagYear.TabIndex = 14;
            this.lblTagYear.Text = "Year";
            // 
            // txtTagYear
            // 
            this.txtTagYear.Location = new System.Drawing.Point(522, 196);
            this.txtTagYear.Name = "txtTagYear";
            this.txtTagYear.Size = new System.Drawing.Size(227, 20);
            this.txtTagYear.TabIndex = 13;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(30, 239);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(35, 13);
            this.lblArtists.TabIndex = 12;
            this.lblArtists.Text = "Artists";
            // 
            // lblTagTitle
            // 
            this.lblTagTitle.AutoSize = true;
            this.lblTagTitle.Location = new System.Drawing.Point(30, 119);
            this.lblTagTitle.Name = "lblTagTitle";
            this.lblTagTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTagTitle.TabIndex = 10;
            this.lblTagTitle.Text = "Title";
            // 
            // txtTagTitle
            // 
            this.txtTagTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTagTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTagTitle.Location = new System.Drawing.Point(33, 135);
            this.txtTagTitle.Name = "txtTagTitle";
            this.txtTagTitle.Size = new System.Drawing.Size(227, 20);
            this.txtTagTitle.TabIndex = 9;
            // 
            // lblTagAlbum
            // 
            this.lblTagAlbum.AutoSize = true;
            this.lblTagAlbum.Location = new System.Drawing.Point(274, 119);
            this.lblTagAlbum.Name = "lblTagAlbum";
            this.lblTagAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblTagAlbum.TabIndex = 18;
            this.lblTagAlbum.Text = "Album";
            // 
            // txtTagAlbum
            // 
            this.txtTagAlbum.Location = new System.Drawing.Point(277, 135);
            this.txtTagAlbum.Name = "txtTagAlbum";
            this.txtTagAlbum.Size = new System.Drawing.Size(227, 20);
            this.txtTagAlbum.TabIndex = 17;
            // 
            // lblTagCopyright
            // 
            this.lblTagCopyright.AutoSize = true;
            this.lblTagCopyright.Location = new System.Drawing.Point(519, 402);
            this.lblTagCopyright.Name = "lblTagCopyright";
            this.lblTagCopyright.Size = new System.Drawing.Size(51, 13);
            this.lblTagCopyright.TabIndex = 20;
            this.lblTagCopyright.Text = "Copyright";
            // 
            // txtTagCopyright
            // 
            this.txtTagCopyright.Location = new System.Drawing.Point(522, 418);
            this.txtTagCopyright.Name = "txtTagCopyright";
            this.txtTagCopyright.Size = new System.Drawing.Size(227, 20);
            this.txtTagCopyright.TabIndex = 19;
            // 
            // lblTagGenres
            // 
            this.lblTagGenres.AutoSize = true;
            this.lblTagGenres.Location = new System.Drawing.Point(274, 239);
            this.lblTagGenres.Name = "lblTagGenres";
            this.lblTagGenres.Size = new System.Drawing.Size(41, 13);
            this.lblTagGenres.TabIndex = 21;
            this.lblTagGenres.Text = "Genres";
            // 
            // cboTagGenres
            // 
            this.cboTagGenres.FormattingEnabled = true;
            this.cboTagGenres.Items.AddRange(new object[] {
            "",
            "Blues",
            "Classic rock",
            "Country",
            "Dance",
            "Disco",
            "Funk",
            "Grunge",
            "Hip-Hop",
            "Jazz",
            "Metal",
            "New Age",
            "Oldies",
            "Other",
            "Pop",
            "Rhythm and Blues",
            "Rap",
            "Reggae",
            "Rock",
            "Techno",
            "Industrial",
            "Alternative",
            "Ska",
            "Death metal",
            "Pranks",
            "Soundtrack",
            "Euro-Techno",
            "Ambient",
            "Trip-Hop",
            "Vocal",
            "Jazz & Funk",
            "Fusion",
            "Trance",
            "Classical",
            "Instrumental",
            "Acid",
            "House",
            "Game",
            "Sound clip",
            "Gospel",
            "Noise",
            "Alternative Rock",
            "Bass",
            "Soul",
            "Punk",
            "Space",
            "Meditative",
            "Instrumental Pop",
            "Instrumental Rock",
            "Ethnic",
            "Gothic",
            "Darkwave",
            "Techno-Industrial",
            "Electronic",
            "Pop-Folk",
            "Eurodance",
            "Dream",
            "Southern Rock",
            "Comedy",
            "Cult",
            "Gangsta",
            "Top 40",
            "Christian Rap",
            "Pop/Funk",
            "Jungle",
            "Native US",
            "Cabaret",
            "New Wave",
            "Psychedelic",
            "Rave",
            "Show tunes",
            "Trailer",
            "Lo-Fi",
            "Tribal",
            "Acid Punk",
            "Acid Jazz",
            "Polka",
            "Retro",
            "Musical",
            "Rock ’n’ Roll",
            "Hard Rock"});
            this.cboTagGenres.Location = new System.Drawing.Point(275, 343);
            this.cboTagGenres.Name = "cboTagGenres";
            this.cboTagGenres.Size = new System.Drawing.Size(93, 21);
            this.cboTagGenres.TabIndex = 22;
            // 
            // txtMediaFile
            // 
            this.txtMediaFile.Location = new System.Drawing.Point(33, 34);
            this.txtMediaFile.Name = "txtMediaFile";
            this.txtMediaFile.Size = new System.Drawing.Size(651, 20);
            this.txtMediaFile.TabIndex = 23;
            // 
            // lblMediaFile
            // 
            this.lblMediaFile.AutoSize = true;
            this.lblMediaFile.Location = new System.Drawing.Point(32, 18);
            this.lblMediaFile.Name = "lblMediaFile";
            this.lblMediaFile.Size = new System.Drawing.Size(55, 13);
            this.lblMediaFile.TabIndex = 24;
            this.lblMediaFile.Text = "Media File";
            // 
            // cmdOpenMediaFile
            // 
            this.cmdOpenMediaFile.Location = new System.Drawing.Point(690, 34);
            this.cmdOpenMediaFile.Name = "cmdOpenMediaFile";
            this.cmdOpenMediaFile.Size = new System.Drawing.Size(59, 19);
            this.cmdOpenMediaFile.TabIndex = 25;
            this.cmdOpenMediaFile.Text = "...";
            this.cmdOpenMediaFile.UseVisualStyleBackColor = true;
            this.cmdOpenMediaFile.Click += new System.EventHandler(this.cmdOpenMediaFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(33, 836);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(227, 35);
            this.cmdSave.TabIndex = 26;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblTagTrackNum
            // 
            this.lblTagTrackNum.AutoSize = true;
            this.lblTagTrackNum.Location = new System.Drawing.Point(519, 119);
            this.lblTagTrackNum.Name = "lblTagTrackNum";
            this.lblTagTrackNum.Size = new System.Drawing.Size(42, 13);
            this.lblTagTrackNum.TabIndex = 28;
            this.lblTagTrackNum.Text = "Track#";
            // 
            // txtTagTrackNum
            // 
            this.txtTagTrackNum.Location = new System.Drawing.Point(522, 135);
            this.txtTagTrackNum.Name = "txtTagTrackNum";
            this.txtTagTrackNum.Size = new System.Drawing.Size(227, 20);
            this.txtTagTrackNum.TabIndex = 27;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(33, 548);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(227, 181);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 29;
            this.picImage.TabStop = false;
            // 
            // lstTagArtists
            // 
            this.lstTagArtists.FormattingEnabled = true;
            this.lstTagArtists.Location = new System.Drawing.Point(33, 255);
            this.lstTagArtists.Name = "lstTagArtists";
            this.lstTagArtists.Size = new System.Drawing.Size(197, 82);
            this.lstTagArtists.TabIndex = 31;
            // 
            // lstTagImages
            // 
            this.lstTagImages.FormattingEnabled = true;
            this.lstTagImages.Location = new System.Drawing.Point(275, 548);
            this.lstTagImages.Name = "lstTagImages";
            this.lstTagImages.Size = new System.Drawing.Size(444, 147);
            this.lstTagImages.TabIndex = 32;
            this.lstTagImages.Click += new System.EventHandler(this.lstTagImages_Click);
            this.lstTagImages.SelectedIndexChanged += new System.EventHandler(this.lstTagImages_SelectedIndexChanged);
            // 
            // cmdTagArtistsAdd
            // 
            this.cmdTagArtistsAdd.Location = new System.Drawing.Point(33, 343);
            this.cmdTagArtistsAdd.Name = "cmdTagArtistsAdd";
            this.cmdTagArtistsAdd.Size = new System.Drawing.Size(59, 19);
            this.cmdTagArtistsAdd.TabIndex = 33;
            this.cmdTagArtistsAdd.Text = "Add";
            this.cmdTagArtistsAdd.UseVisualStyleBackColor = true;
            this.cmdTagArtistsAdd.Click += new System.EventHandler(this.cmdTagArtistsAdd_Click);
            // 
            // cmdTagArtistsRemove
            // 
            this.cmdTagArtistsRemove.Location = new System.Drawing.Point(98, 343);
            this.cmdTagArtistsRemove.Name = "cmdTagArtistsRemove";
            this.cmdTagArtistsRemove.Size = new System.Drawing.Size(59, 19);
            this.cmdTagArtistsRemove.TabIndex = 34;
            this.cmdTagArtistsRemove.Text = "Remove";
            this.cmdTagArtistsRemove.UseVisualStyleBackColor = true;
            this.cmdTagArtistsRemove.Click += new System.EventHandler(this.cmdTagArtistsRemove_Click);
            // 
            // lstTagGenres
            // 
            this.lstTagGenres.FormattingEnabled = true;
            this.lstTagGenres.Location = new System.Drawing.Point(275, 255);
            this.lstTagGenres.Name = "lstTagGenres";
            this.lstTagGenres.Size = new System.Drawing.Size(200, 82);
            this.lstTagGenres.TabIndex = 35;
            // 
            // cmdTagGenresRemove
            // 
            this.cmdTagGenresRemove.Location = new System.Drawing.Point(434, 343);
            this.cmdTagGenresRemove.Name = "cmdTagGenresRemove";
            this.cmdTagGenresRemove.Size = new System.Drawing.Size(59, 19);
            this.cmdTagGenresRemove.TabIndex = 37;
            this.cmdTagGenresRemove.Text = "Remove";
            this.cmdTagGenresRemove.UseVisualStyleBackColor = true;
            this.cmdTagGenresRemove.Click += new System.EventHandler(this.cmdGenresRemove_Click);
            // 
            // cmdTagGenresAdd
            // 
            this.cmdTagGenresAdd.Location = new System.Drawing.Point(369, 343);
            this.cmdTagGenresAdd.Name = "cmdTagGenresAdd";
            this.cmdTagGenresAdd.Size = new System.Drawing.Size(59, 19);
            this.cmdTagGenresAdd.TabIndex = 36;
            this.cmdTagGenresAdd.Text = "Add";
            this.cmdTagGenresAdd.UseVisualStyleBackColor = true;
            this.cmdTagGenresAdd.Click += new System.EventHandler(this.cmdGenresAdd_Click);
            // 
            // lblTagLyrics
            // 
            this.lblTagLyrics.AutoSize = true;
            this.lblTagLyrics.Location = new System.Drawing.Point(32, 387);
            this.lblTagLyrics.Name = "lblTagLyrics";
            this.lblTagLyrics.Size = new System.Drawing.Size(34, 13);
            this.lblTagLyrics.TabIndex = 39;
            this.lblTagLyrics.Text = "Lyrics";
            // 
            // txtTagLyrics
            // 
            this.txtTagLyrics.Location = new System.Drawing.Point(35, 403);
            this.txtTagLyrics.Multiline = true;
            this.txtTagLyrics.Name = "txtTagLyrics";
            this.txtTagLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTagLyrics.Size = new System.Drawing.Size(467, 102);
            this.txtTagLyrics.TabIndex = 38;
            // 
            // cmdClearAllTags
            // 
            this.cmdClearAllTags.Location = new System.Drawing.Point(31, 60);
            this.cmdClearAllTags.Name = "cmdClearAllTags";
            this.cmdClearAllTags.Size = new System.Drawing.Size(126, 25);
            this.cmdClearAllTags.TabIndex = 40;
            this.cmdClearAllTags.Text = "Clear All Tags";
            this.cmdClearAllTags.UseVisualStyleBackColor = true;
            this.cmdClearAllTags.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cmdTagImagesRemove
            // 
            this.cmdTagImagesRemove.Location = new System.Drawing.Point(338, 710);
            this.cmdTagImagesRemove.Name = "cmdTagImagesRemove";
            this.cmdTagImagesRemove.Size = new System.Drawing.Size(59, 19);
            this.cmdTagImagesRemove.TabIndex = 42;
            this.cmdTagImagesRemove.Text = "Remove";
            this.cmdTagImagesRemove.UseVisualStyleBackColor = true;
            this.cmdTagImagesRemove.Click += new System.EventHandler(this.cmdImagesRemove_Click);
            // 
            // cmdTagImagesAdd
            // 
            this.cmdTagImagesAdd.Location = new System.Drawing.Point(273, 710);
            this.cmdTagImagesAdd.Name = "cmdTagImagesAdd";
            this.cmdTagImagesAdd.Size = new System.Drawing.Size(59, 19);
            this.cmdTagImagesAdd.TabIndex = 41;
            this.cmdTagImagesAdd.Text = "Add";
            this.cmdTagImagesAdd.UseVisualStyleBackColor = true;
            this.cmdTagImagesAdd.Click += new System.EventHandler(this.cmdImagesAdd_Click);
            // 
            // cmdTagArtistsUp
            // 
            this.cmdTagArtistsUp.Location = new System.Drawing.Point(232, 278);
            this.cmdTagArtistsUp.Name = "cmdTagArtistsUp";
            this.cmdTagArtistsUp.Size = new System.Drawing.Size(23, 19);
            this.cmdTagArtistsUp.TabIndex = 43;
            this.cmdTagArtistsUp.Text = "▲";
            this.cmdTagArtistsUp.UseVisualStyleBackColor = true;
            this.cmdTagArtistsUp.Click += new System.EventHandler(this.cmdTagArtistsUp_Click);
            // 
            // cmdTagArtistsDown
            // 
            this.cmdTagArtistsDown.Location = new System.Drawing.Point(231, 300);
            this.cmdTagArtistsDown.Name = "cmdTagArtistsDown";
            this.cmdTagArtistsDown.Size = new System.Drawing.Size(24, 19);
            this.cmdTagArtistsDown.TabIndex = 44;
            this.cmdTagArtistsDown.Text = "▼";
            this.cmdTagArtistsDown.UseVisualStyleBackColor = true;
            this.cmdTagArtistsDown.Click += new System.EventHandler(this.cmdTagArtistsDown_Click);
            // 
            // cmdTagGenresDown
            // 
            this.cmdTagGenresDown.Location = new System.Drawing.Point(476, 300);
            this.cmdTagGenresDown.Name = "cmdTagGenresDown";
            this.cmdTagGenresDown.Size = new System.Drawing.Size(24, 19);
            this.cmdTagGenresDown.TabIndex = 47;
            this.cmdTagGenresDown.Text = "▼";
            this.cmdTagGenresDown.UseVisualStyleBackColor = true;
            this.cmdTagGenresDown.Click += new System.EventHandler(this.cmdTagGenresDown_Click);
            // 
            // cmdTagGenresUp
            // 
            this.cmdTagGenresUp.Location = new System.Drawing.Point(477, 278);
            this.cmdTagGenresUp.Name = "cmdTagGenresUp";
            this.cmdTagGenresUp.Size = new System.Drawing.Size(23, 19);
            this.cmdTagGenresUp.TabIndex = 46;
            this.cmdTagGenresUp.Text = "▲";
            this.cmdTagGenresUp.UseVisualStyleBackColor = true;
            this.cmdTagGenresUp.Click += new System.EventHandler(this.cmdTagGenresUp_Click);
            // 
            // cmdTagImagesDown
            // 
            this.cmdTagImagesDown.Location = new System.Drawing.Point(721, 627);
            this.cmdTagImagesDown.Name = "cmdTagImagesDown";
            this.cmdTagImagesDown.Size = new System.Drawing.Size(24, 19);
            this.cmdTagImagesDown.TabIndex = 49;
            this.cmdTagImagesDown.Text = "▼";
            this.cmdTagImagesDown.UseVisualStyleBackColor = true;
            this.cmdTagImagesDown.Click += new System.EventHandler(this.cmdTagImagesDown_Click);
            // 
            // cmdTagImagesUp
            // 
            this.cmdTagImagesUp.Location = new System.Drawing.Point(722, 605);
            this.cmdTagImagesUp.Name = "cmdTagImagesUp";
            this.cmdTagImagesUp.Size = new System.Drawing.Size(23, 19);
            this.cmdTagImagesUp.TabIndex = 48;
            this.cmdTagImagesUp.Text = "▲";
            this.cmdTagImagesUp.UseVisualStyleBackColor = true;
            this.cmdTagImagesUp.Click += new System.EventHandler(this.cmdTagImagesUp_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(266, 836);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(227, 35);
            this.cmdCancel.TabIndex = 50;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdTagComposersDown
            // 
            this.cmdTagComposersDown.Location = new System.Drawing.Point(720, 300);
            this.cmdTagComposersDown.Name = "cmdTagComposersDown";
            this.cmdTagComposersDown.Size = new System.Drawing.Size(24, 19);
            this.cmdTagComposersDown.TabIndex = 56;
            this.cmdTagComposersDown.Text = "▼";
            this.cmdTagComposersDown.UseVisualStyleBackColor = true;
            this.cmdTagComposersDown.Click += new System.EventHandler(this.cmdTagComposersDown_Click);
            // 
            // cmdTagComposersUp
            // 
            this.cmdTagComposersUp.Location = new System.Drawing.Point(721, 278);
            this.cmdTagComposersUp.Name = "cmdTagComposersUp";
            this.cmdTagComposersUp.Size = new System.Drawing.Size(23, 19);
            this.cmdTagComposersUp.TabIndex = 55;
            this.cmdTagComposersUp.Text = "▲";
            this.cmdTagComposersUp.UseVisualStyleBackColor = true;
            this.cmdTagComposersUp.Click += new System.EventHandler(this.cmdTagComposersUp_Click);
            // 
            // cmdTagComposersRemove
            // 
            this.cmdTagComposersRemove.Location = new System.Drawing.Point(587, 343);
            this.cmdTagComposersRemove.Name = "cmdTagComposersRemove";
            this.cmdTagComposersRemove.Size = new System.Drawing.Size(59, 19);
            this.cmdTagComposersRemove.TabIndex = 54;
            this.cmdTagComposersRemove.Text = "Remove";
            this.cmdTagComposersRemove.UseVisualStyleBackColor = true;
            this.cmdTagComposersRemove.Click += new System.EventHandler(this.cmdComposersRemove_Click);
            // 
            // cmdTagComposersAdd
            // 
            this.cmdTagComposersAdd.Location = new System.Drawing.Point(522, 343);
            this.cmdTagComposersAdd.Name = "cmdTagComposersAdd";
            this.cmdTagComposersAdd.Size = new System.Drawing.Size(59, 19);
            this.cmdTagComposersAdd.TabIndex = 53;
            this.cmdTagComposersAdd.Text = "Add";
            this.cmdTagComposersAdd.UseVisualStyleBackColor = true;
            this.cmdTagComposersAdd.Click += new System.EventHandler(this.cmdComposersAdd_Click);
            // 
            // lstTagComposers
            // 
            this.lstTagComposers.FormattingEnabled = true;
            this.lstTagComposers.Location = new System.Drawing.Point(522, 255);
            this.lstTagComposers.Name = "lstTagComposers";
            this.lstTagComposers.Size = new System.Drawing.Size(197, 82);
            this.lstTagComposers.TabIndex = 52;
            // 
            // lblTagComposers
            // 
            this.lblTagComposers.AutoSize = true;
            this.lblTagComposers.Location = new System.Drawing.Point(519, 239);
            this.lblTagComposers.Name = "lblTagComposers";
            this.lblTagComposers.Size = new System.Drawing.Size(59, 13);
            this.lblTagComposers.TabIndex = 51;
            this.lblTagComposers.Text = "Composers";
            // 
            // cboTagRating
            // 
            this.cboTagRating.FormattingEnabled = true;
            this.cboTagRating.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5"});
            this.cboTagRating.Location = new System.Drawing.Point(522, 470);
            this.cboTagRating.Name = "cboTagRating";
            this.cboTagRating.Size = new System.Drawing.Size(93, 21);
            this.cboTagRating.TabIndex = 57;
            // 
            // lblTagRating
            // 
            this.lblTagRating.AutoSize = true;
            this.lblTagRating.Location = new System.Drawing.Point(519, 454);
            this.lblTagRating.Name = "lblTagRating";
            this.lblTagRating.Size = new System.Drawing.Size(38, 13);
            this.lblTagRating.TabIndex = 58;
            this.lblTagRating.Text = "Rating";
            // 
            // lblImages
            // 
            this.lblImages.AutoSize = true;
            this.lblImages.Location = new System.Drawing.Point(32, 532);
            this.lblImages.Name = "lblImages";
            this.lblImages.Size = new System.Drawing.Size(41, 13);
            this.lblImages.TabIndex = 59;
            this.lblImages.Text = "Images";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 762);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 10);
            this.panel1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(0, -63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 1);
            this.label2.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 1);
            this.label1.TabIndex = 174;
            // 
            // audioConverter1
            // 
            this.audioConverter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("audioConverter1.BackgroundImage")));
            this.audioConverter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.audioConverter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.audioConverter1.DestinatioFile = null;
            this.audioConverter1.Location = new System.Drawing.Point(587, 12);
            this.audioConverter1.Name = "audioConverter1";
            this.audioConverter1.RatingStars = 0F;
            this.audioConverter1.RatingUser = "Windows Media Player 9 Series";
            this.audioConverter1.Size = new System.Drawing.Size(52, 52);
            this.audioConverter1.TabIndex = 64;
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
            // 
            // frmID3TagsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 895);
            this.Controls.Add(this.audioConverter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImages);
            this.Controls.Add(this.lblTagRating);
            this.Controls.Add(this.cboTagRating);
            this.Controls.Add(this.cmdTagComposersDown);
            this.Controls.Add(this.cmdTagComposersUp);
            this.Controls.Add(this.cmdTagComposersRemove);
            this.Controls.Add(this.cmdTagComposersAdd);
            this.Controls.Add(this.lstTagComposers);
            this.Controls.Add(this.lblTagComposers);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdTagImagesDown);
            this.Controls.Add(this.cmdTagImagesUp);
            this.Controls.Add(this.cmdTagGenresDown);
            this.Controls.Add(this.cmdTagGenresUp);
            this.Controls.Add(this.cmdTagArtistsDown);
            this.Controls.Add(this.cmdTagArtistsUp);
            this.Controls.Add(this.cmdTagImagesRemove);
            this.Controls.Add(this.cmdTagImagesAdd);
            this.Controls.Add(this.cmdClearAllTags);
            this.Controls.Add(this.lblTagLyrics);
            this.Controls.Add(this.txtTagLyrics);
            this.Controls.Add(this.cmdTagGenresRemove);
            this.Controls.Add(this.cmdTagGenresAdd);
            this.Controls.Add(this.lstTagGenres);
            this.Controls.Add(this.cmdTagArtistsRemove);
            this.Controls.Add(this.cmdTagArtistsAdd);
            this.Controls.Add(this.lstTagImages);
            this.Controls.Add(this.lstTagArtists);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblTagTrackNum);
            this.Controls.Add(this.txtTagTrackNum);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdOpenMediaFile);
            this.Controls.Add(this.lblMediaFile);
            this.Controls.Add(this.txtMediaFile);
            this.Controls.Add(this.cboTagGenres);
            this.Controls.Add(this.lblTagGenres);
            this.Controls.Add(this.lblTagCopyright);
            this.Controls.Add(this.txtTagCopyright);
            this.Controls.Add(this.lblTagAlbum);
            this.Controls.Add(this.txtTagAlbum);
            this.Controls.Add(this.lblTagComment);
            this.Controls.Add(this.txtTagComment);
            this.Controls.Add(this.lblTagYear);
            this.Controls.Add(this.txtTagYear);
            this.Controls.Add(this.lblArtists);
            this.Controls.Add(this.lblTagTitle);
            this.Controls.Add(this.txtTagTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmID3TagsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All ID3 Tags Editor";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTagComment;
        private System.Windows.Forms.TextBox txtTagComment;
        private System.Windows.Forms.Label lblTagYear;
        private System.Windows.Forms.TextBox txtTagYear;
        private System.Windows.Forms.Label lblArtists;
        private System.Windows.Forms.Label lblTagTitle;
        private System.Windows.Forms.TextBox txtTagTitle;
        private System.Windows.Forms.Label lblTagAlbum;
        private System.Windows.Forms.TextBox txtTagAlbum;
        private System.Windows.Forms.Label lblTagCopyright;
        private System.Windows.Forms.TextBox txtTagCopyright;
        private System.Windows.Forms.Label lblTagGenres;
        private System.Windows.Forms.ComboBox cboTagGenres;
        private System.Windows.Forms.TextBox txtMediaFile;
        private System.Windows.Forms.Label lblMediaFile;
        private System.Windows.Forms.Button cmdOpenMediaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label lblTagTrackNum;
        private System.Windows.Forms.TextBox txtTagTrackNum;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ListBox lstTagArtists;
        private System.Windows.Forms.ListBox lstTagImages;
        private System.Windows.Forms.Button cmdTagArtistsAdd;
        private System.Windows.Forms.Button cmdTagArtistsRemove;
        private System.Windows.Forms.ListBox lstTagGenres;
        private System.Windows.Forms.Button cmdTagGenresRemove;
        private System.Windows.Forms.Button cmdTagGenresAdd;
        private System.Windows.Forms.Label lblTagLyrics;
        private System.Windows.Forms.TextBox txtTagLyrics;
        private System.Windows.Forms.Button cmdClearAllTags;
        private System.Windows.Forms.Button cmdTagImagesRemove;
        private System.Windows.Forms.Button cmdTagImagesAdd;
        private System.Windows.Forms.Button cmdTagArtistsUp;
        private System.Windows.Forms.Button cmdTagArtistsDown;
        private System.Windows.Forms.Button cmdTagGenresDown;
        private System.Windows.Forms.Button cmdTagGenresUp;
        private System.Windows.Forms.Button cmdTagImagesDown;
        private System.Windows.Forms.Button cmdTagImagesUp;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdTagComposersDown;
        private System.Windows.Forms.Button cmdTagComposersUp;
        private System.Windows.Forms.Button cmdTagComposersRemove;
        private System.Windows.Forms.Button cmdTagComposersAdd;
        private System.Windows.Forms.ListBox lstTagComposers;
        private System.Windows.Forms.Label lblTagComposers;
        private System.Windows.Forms.ComboBox cboTagRating;
        private System.Windows.Forms.Label lblTagRating;
        private System.Windows.Forms.Label lblImages;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private CSAudioConverter.AudioConverter audioConverter1;
    }
}