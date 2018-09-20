namespace MainViewWinForm
{
    partial class MainViewForm
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
            this.addFileButton = new System.Windows.Forms.Button();
            this.searchResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.startSearchButton = new System.Windows.Forms.Button();
            this.getInformationAboutModulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(276, 12);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addFileButton.Size = new System.Drawing.Size(75, 23);
            this.addFileButton.TabIndex = 0;
            this.addFileButton.Text = "Add file";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // searchResultRichTextBox
            // 
            this.searchResultRichTextBox.Location = new System.Drawing.Point(2, 153);
            this.searchResultRichTextBox.Name = "searchResultRichTextBox";
            this.searchResultRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.searchResultRichTextBox.Size = new System.Drawing.Size(358, 129);
            this.searchResultRichTextBox.TabIndex = 1;
            this.searchResultRichTextBox.Text = "";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 70);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(231, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // startSearchButton
            // 
            this.startSearchButton.Location = new System.Drawing.Point(276, 68);
            this.startSearchButton.Name = "startSearchButton";
            this.startSearchButton.Size = new System.Drawing.Size(75, 23);
            this.startSearchButton.TabIndex = 3;
            this.startSearchButton.Text = "Search";
            this.startSearchButton.UseVisualStyleBackColor = true;
            this.startSearchButton.Click += new System.EventHandler(this.startSearchButton_Click);
            // 
            // getInformationAboutModulesButton
            // 
            this.getInformationAboutModulesButton.Location = new System.Drawing.Point(13, 11);
            this.getInformationAboutModulesButton.Name = "getInformationAboutModulesButton";
            this.getInformationAboutModulesButton.Size = new System.Drawing.Size(97, 23);
            this.getInformationAboutModulesButton.TabIndex = 4;
            this.getInformationAboutModulesButton.Text = "About seachers";
            this.getInformationAboutModulesButton.UseVisualStyleBackColor = true;
            this.getInformationAboutModulesButton.Click += new System.EventHandler(this.getInformationAboutModulesButton_Click);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 286);
            this.Controls.Add(this.getInformationAboutModulesButton);
            this.Controls.Add(this.startSearchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchResultRichTextBox);
            this.Controls.Add(this.addFileButton);
            this.Name = "MainViewForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.RichTextBox searchResultRichTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button startSearchButton;
        private System.Windows.Forms.Button getInformationAboutModulesButton;
    }
}

