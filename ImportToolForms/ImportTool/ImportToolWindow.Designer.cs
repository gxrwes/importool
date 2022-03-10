namespace ImportTool
{
    partial class ImportToolWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choosePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.importpathtxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // choosePath
            // 
            this.choosePath.Location = new System.Drawing.Point(56, 15);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(130, 23);
            this.choosePath.TabIndex = 0;
            this.choosePath.Text = "Choose Import Path";
            this.choosePath.UseVisualStyleBackColor = true;
            this.choosePath.Click += new System.EventHandler(this.importPathButton);
            // 
            // importpathtxtbox
            // 
            this.importpathtxtbox.Location = new System.Drawing.Point(208, 15);
            this.importpathtxtbox.Name = "importpathtxtbox";
            this.importpathtxtbox.ReadOnly = true;
            this.importpathtxtbox.Size = new System.Drawing.Size(546, 23);
            this.importpathtxtbox.TabIndex = 1;
            // 
            // ImportToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 449);
            this.Controls.Add(this.importpathtxtbox);
            this.Controls.Add(this.choosePath);
            this.Name = "ImportToolWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button choosePath;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox importpathtxtbox;
    }
}