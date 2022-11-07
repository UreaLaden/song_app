namespace Mckinney_CourseProject_CEIS209
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showSongs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadSongsBtn = new System.Windows.Forms.Button();
            this.storeSongsBtn = new System.Windows.Forms.Button();
            this.genreText = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Oswald", 16F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(79, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.titleText.Location = new System.Drawing.Point(124, 84);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(376, 44);
            this.titleText.TabIndex = 0;
            // 
            // urlText
            // 
            this.urlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.urlText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.urlText.Location = new System.Drawing.Point(124, 333);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(376, 44);
            this.urlText.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Oswald", 16F);
            this.urlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.urlLabel.Location = new System.Drawing.Point(12, 325);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(76, 54);
            this.urlLabel.TabIndex = 6;
            this.urlLabel.Text = "URL:";
            // 
            // yearText
            // 
            this.yearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.yearText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.yearText.Location = new System.Drawing.Point(124, 273);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(376, 44);
            this.yearText.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Oswald", 16F);
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.yearLabel.Location = new System.Drawing.Point(12, 265);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(80, 54);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Oswald", 16F);
            this.genreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.genreLabel.Location = new System.Drawing.Point(12, 202);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(96, 54);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            // 
            // artistText
            // 
            this.artistText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.artistText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.artistText.Location = new System.Drawing.Point(124, 147);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(376, 44);
            this.artistText.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Oswald", 16F);
            this.artistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.artistLabel.Location = new System.Drawing.Point(12, 139);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(94, 54);
            this.artistLabel.TabIndex = 12;
            this.artistLabel.Text = "Artist:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Oswald", 16F);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.addButton.Location = new System.Drawing.Point(11, 464);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(505, 105);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // showSongs
            // 
            this.showSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.showSongs.FlatAppearance.BorderSize = 0;
            this.showSongs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSongs.Font = new System.Drawing.Font("Oswald", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showSongs.Location = new System.Drawing.Point(11, 832);
            this.showSongs.Name = "showSongs";
            this.showSongs.Size = new System.Drawing.Size(505, 105);
            this.showSongs.TabIndex = 6;
            this.showSongs.Text = "Show All Songs";
            this.showSongs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.loadSongsBtn);
            this.panel1.Controls.Add(this.storeSongsBtn);
            this.panel1.Controls.Add(this.genreText);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.findButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.showSongs);
            this.panel1.Controls.Add(this.artistLabel);
            this.panel1.Controls.Add(this.genreLabel);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.urlLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.urlText);
            this.panel1.Controls.Add(this.artistText);
            this.panel1.Controls.Add(this.titleText);
            this.panel1.Controls.Add(this.yearText);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 982);
            this.panel1.TabIndex = 21;
            // 
            // loadSongsBtn
            // 
            this.loadSongsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.loadSongsBtn.FlatAppearance.BorderSize = 0;
            this.loadSongsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.loadSongsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadSongsBtn.Font = new System.Drawing.Font("Oswald", 8F);
            this.loadSongsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.loadSongsBtn.Location = new System.Drawing.Point(271, 406);
            this.loadSongsBtn.Name = "loadSongsBtn";
            this.loadSongsBtn.Size = new System.Drawing.Size(245, 41);
            this.loadSongsBtn.TabIndex = 16;
            this.loadSongsBtn.Text = "Load Song List";
            this.loadSongsBtn.UseVisualStyleBackColor = false;
            this.loadSongsBtn.Click += new System.EventHandler(this.loadSongsBtn_Click);
            // 
            // storeSongsBtn
            // 
            this.storeSongsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.storeSongsBtn.Enabled = false;
            this.storeSongsBtn.FlatAppearance.BorderSize = 0;
            this.storeSongsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.storeSongsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storeSongsBtn.Font = new System.Drawing.Font("Oswald", 8F);
            this.storeSongsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.storeSongsBtn.Location = new System.Drawing.Point(11, 406);
            this.storeSongsBtn.Name = "storeSongsBtn";
            this.storeSongsBtn.Size = new System.Drawing.Size(245, 41);
            this.storeSongsBtn.TabIndex = 15;
            this.storeSongsBtn.Text = "Store Songs";
            this.storeSongsBtn.UseVisualStyleBackColor = false;
            // 
            // genreText
            // 
            this.genreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.genreText.FormattingEnabled = true;
            this.genreText.Items.AddRange(new object[] {
            "Pop",
            "Dubstep",
            "Chillstep",
            "R & B",
            "Hip Hop",
            "Rap",
            "Country",
            "Rock"});
            this.genreText.Location = new System.Drawing.Point(124, 212);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(376, 45);
            this.genreText.TabIndex = 2;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Oswald", 16F);
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.clearButton.Location = new System.Drawing.Point(11, 709);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(505, 105);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.findButton.FlatAppearance.BorderSize = 0;
            this.findButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Oswald", 16F);
            this.findButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.findButton.Location = new System.Drawing.Point(11, 587);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(505, 105);
            this.findButton.TabIndex = 13;
            this.findButton.Text = "Find Song";
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.outputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.outputText.Location = new System.Drawing.Point(627, 565);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(777, 427);
            this.outputText.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(619, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(619, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 62);
            this.label2.TabIndex = 19;
            this.label2.Text = "Song List:";
            // 
            // songList
            // 
            this.songList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.songList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 37;
            this.songList.Location = new System.Drawing.Point(627, 118);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(777, 374);
            this.songList.TabIndex = 20;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.SongList_SelectedIndexChanged);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.playButton);
            this.headerPanel.Controls.Add(this.webViewDisplay);
            this.headerPanel.Controls.Add(this.songList);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.outputText);
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(2140, 1039);
            this.headerPanel.TabIndex = 13;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(252)))), ((int)(((byte)(0)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Oswald", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.playButton.Location = new System.Drawing.Point(1525, 811);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(505, 105);
            this.playButton.TabIndex = 15;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(1460, 288);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(632, 452);
            this.webViewDisplay.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 23;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(2002, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(55, 63);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(2080, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(55, 63);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.headerLabel.Location = new System.Drawing.Point(21, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(234, 37);
            this.headerLabel.TabIndex = 22;
            this.headerLabel.Text = "Video Manager";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2146, 1045);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button showSongs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button clearButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ComboBox genreText;
        private System.Windows.Forms.Button loadSongsBtn;
        private System.Windows.Forms.Button storeSongsBtn;
    }
}

