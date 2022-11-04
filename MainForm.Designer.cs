﻿namespace Mckinney_CourseProject_CEIS209
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
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showSongs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.songList = new System.Windows.Forms.ListBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
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
            // genreText
            // 
            this.genreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.genreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.genreText.Location = new System.Drawing.Point(124, 210);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(376, 44);
            this.genreText.TabIndex = 2;
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
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(0)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Oswald", 16F);
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.addButton.Location = new System.Drawing.Point(11, 486);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(505, 195);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // showSongs
            // 
            this.showSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(189)))), ((int)(((byte)(194)))));
            this.showSongs.FlatAppearance.BorderSize = 0;
            this.showSongs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.showSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSongs.Font = new System.Drawing.Font("Oswald", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSongs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.showSongs.Location = new System.Drawing.Point(11, 734);
            this.showSongs.Name = "showSongs";
            this.showSongs.Size = new System.Drawing.Size(505, 195);
            this.showSongs.TabIndex = 6;
            this.showSongs.Text = "Show All Songs";
            this.showSongs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
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
            this.panel1.Controls.Add(this.genreText);
            this.panel1.Controls.Add(this.yearText);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 982);
            this.panel1.TabIndex = 21;
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.outputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.outputText.Location = new System.Drawing.Point(627, 565);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
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
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.songList);
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.outputText);
            this.headerPanel.Controls.Add(this.minimizeBtn);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Location = new System.Drawing.Point(2, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1474, 1039);
            this.headerPanel.TabIndex = 13;
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
            this.minimizeBtn.Location = new System.Drawing.Point(1336, 1);
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
            this.closeButton.Location = new System.Drawing.Point(1414, 1);
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
            this.ClientSize = new System.Drawing.Size(1477, 1042);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox genreText;
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
    }
}

