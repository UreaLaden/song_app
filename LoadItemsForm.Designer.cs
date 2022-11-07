namespace Mckinney_CourseProject_CEIS209
{
    partial class SongLoader
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.loadItemsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titleText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(107, 106);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(557, 205);
            this.checkedListBox.Sorted = true;
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.CheckOnClick = true;
            // 
            // loadItemsButton
            // 
            this.loadItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.loadItemsButton.FlatAppearance.BorderSize = 0;
            this.loadItemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadItemsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.loadItemsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(230)))), ((int)(((byte)(221)))));
            this.loadItemsButton.Location = new System.Drawing.Point(228, 334);
            this.loadItemsButton.Name = "loadItemsButton";
            this.loadItemsButton.Size = new System.Drawing.Size(253, 60);
            this.loadItemsButton.TabIndex = 1;
            this.loadItemsButton.Text = "Done";
            this.loadItemsButton.UseVisualStyleBackColor = false;
            this.loadItemsButton.Click += new System.EventHandler(this.loadItemsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.loadItemsButton);
            this.panel1.Controls.Add(this.checkedListBox);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 410);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel2.Controls.Add(this.titleText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 75);
            this.panel2.TabIndex = 3;
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.titleText.Location = new System.Drawing.Point(82, 17);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(605, 41);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "Choose ${songAmount} songs to Load\r\n";
            // 
            // SongLoader
            // 
            this.AcceptButton = this.loadItemsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(163)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(778, 417);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SongLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadItemsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button loadItemsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titleText;
    }
}