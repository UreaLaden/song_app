namespace Mckinney_CourseProject_CEIS209
{
    partial class NoteBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBox));
            this.panel1 = new System.Windows.Forms.Panel();
            this.noteBoxText = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteBoxTitle = new System.Windows.Forms.Label();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.noteBoxTitle);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 49);
            this.panel1.TabIndex = 0;
            // 
            // noteBoxText
            // 
            this.noteBoxText.AutoSize = true;
            this.noteBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.noteBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.noteBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.noteBoxText.Location = new System.Drawing.Point(185, 99);
            this.noteBoxText.Name = "noteBoxText";
            this.noteBoxText.Size = new System.Drawing.Size(352, 37);
            this.noteBoxText.TabIndex = 1;
            this.noteBoxText.Text = "This is placeholder text.";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(163)))), ((int)(((byte)(199)))));
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(117)))), ((int)(((byte)(0)))));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.okBtn.Location = new System.Drawing.Point(249, 178);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(214, 53);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Got It";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.pictureBoxImg);
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 229);
            this.panel2.TabIndex = 3;
            // 
            // noteBoxTitle
            // 
            this.noteBoxTitle.AutoSize = true;
            this.noteBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.noteBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.noteBoxTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noteBoxTitle.Location = new System.Drawing.Point(22, 8);
            this.noteBoxTitle.Margin = new System.Windows.Forms.Padding(3);
            this.noteBoxTitle.Name = "noteBoxTitle";
            this.noteBoxTitle.Size = new System.Drawing.Size(162, 37);
            this.noteBoxTitle.TabIndex = 0;
            this.noteBoxTitle.Text = "Attention !";
            this.noteBoxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Image = global::Mckinney_CourseProject_CEIS209.Properties.Resources.notice_transparent_icon_big;
            this.pictureBoxImg.Location = new System.Drawing.Point(31, 31);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            // 
            // NoteBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(163)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(630, 280);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.noteBoxText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label noteBoxTitle;
        private System.Windows.Forms.Label noteBoxText;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxImg;
    }
}