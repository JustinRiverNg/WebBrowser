namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.bookmarkSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteBookmarkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(51, 120);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(429, 264);
            this.bookmarkListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(512, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a term and press\r\n\"search\" to search\r\nthrough your bookmarks:";
            // 
            // bookmarkSearchTextBox
            // 
            this.bookmarkSearchTextBox.Location = new System.Drawing.Point(515, 120);
            this.bookmarkSearchTextBox.Name = "bookmarkSearchTextBox";
            this.bookmarkSearchTextBox.Size = new System.Drawing.Size(147, 20);
            this.bookmarkSearchTextBox.TabIndex = 5;
            // 
            // bookmarkSearchButton
            // 
            this.bookmarkSearchButton.Location = new System.Drawing.Point(697, 117);
            this.bookmarkSearchButton.Name = "bookmarkSearchButton";
            this.bookmarkSearchButton.Size = new System.Drawing.Size(75, 23);
            this.bookmarkSearchButton.TabIndex = 6;
            this.bookmarkSearchButton.Text = "Search";
            this.bookmarkSearchButton.UseVisualStyleBackColor = true;
            this.bookmarkSearchButton.Click += new System.EventHandler(this.BookmarkSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(512, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Press \"delete\" to\r\ndelete the currently\r\nselected item:";
            // 
            // deleteBookmarkButton
            // 
            this.deleteBookmarkButton.Location = new System.Drawing.Point(697, 204);
            this.deleteBookmarkButton.Name = "deleteBookmarkButton";
            this.deleteBookmarkButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBookmarkButton.TabIndex = 8;
            this.deleteBookmarkButton.Text = "Delete";
            this.deleteBookmarkButton.UseVisualStyleBackColor = true;
            this.deleteBookmarkButton.Click += new System.EventHandler(this.DeleteBookmarkButton_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBookmarkButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookmarkSearchButton);
            this.Controls.Add(this.bookmarkSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookmarkListBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookmarkSearchTextBox;
        private System.Windows.Forms.Button bookmarkSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteBookmarkButton;
    }
}