namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteHistoryButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(42, 132);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(419, 277);
            this.historyListBox.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(542, 83);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(147, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(713, 83);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(75, 23);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(540, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a term and press\r\n\"search\" to search\r\nthrough your history:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(540, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Press \"delete\" to\r\ndelete the currently\r\nselected item:";
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Location = new System.Drawing.Point(713, 175);
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.deleteHistoryButton.TabIndex = 5;
            this.deleteHistoryButton.Text = "Delete";
            this.deleteHistoryButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(540, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Press \"clear history\"\r\nto clear the search\r\nhistory:";
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(713, 262);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(75, 51);
            this.clearHistoryButton.TabIndex = 7;
            this.clearHistoryButton.Text = "Clear\r\nHistory";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteHistoryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.historyListBox);
            this.Name = "HistoryManagerForm";
            this.Text = "HistoryManagerForm";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteHistoryButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearHistoryButton;
    }
}