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
            this.chooseImportPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.importpathtxtbox = new System.Windows.Forms.TextBox();
            this.ImportPathLable = new System.Windows.Forms.Label();
            this.destpathlable = new System.Windows.Forms.Label();
            this.destpathtxtbox = new System.Windows.Forms.TextBox();
            this.chooseDestPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseImportPath
            // 
            this.chooseImportPath.Location = new System.Drawing.Point(624, 85);
            this.chooseImportPath.Name = "chooseImportPath";
            this.chooseImportPath.Size = new System.Drawing.Size(130, 23);
            this.chooseImportPath.TabIndex = 0;
            this.chooseImportPath.Text = "Choose Import Path";
            this.chooseImportPath.UseVisualStyleBackColor = true;
            this.chooseImportPath.Click += new System.EventHandler(this.importPathButton);
            // 
            // importpathtxtbox
            // 
            this.importpathtxtbox.Location = new System.Drawing.Point(130, 86);
            this.importpathtxtbox.Name = "importpathtxtbox";
            this.importpathtxtbox.ReadOnly = true;
            this.importpathtxtbox.Size = new System.Drawing.Size(488, 23);
            this.importpathtxtbox.TabIndex = 1;
            // 
            // ImportPathLable
            // 
            this.ImportPathLable.AutoSize = true;
            this.ImportPathLable.Location = new System.Drawing.Point(12, 89);
            this.ImportPathLable.Name = "ImportPathLable";
            this.ImportPathLable.Size = new System.Drawing.Size(76, 15);
            this.ImportPathLable.TabIndex = 2;
            this.ImportPathLable.Text = "Import Path :";
            // 
            // destpathlable
            // 
            this.destpathlable.AutoSize = true;
            this.destpathlable.Location = new System.Drawing.Point(12, 138);
            this.destpathlable.Name = "destpathlable";
            this.destpathlable.Size = new System.Drawing.Size(100, 15);
            this.destpathlable.TabIndex = 3;
            this.destpathlable.Text = "Destination Path :";
            // 
            // destpathtxtbox
            // 
            this.destpathtxtbox.Location = new System.Drawing.Point(130, 135);
            this.destpathtxtbox.Name = "destpathtxtbox";
            this.destpathtxtbox.ReadOnly = true;
            this.destpathtxtbox.Size = new System.Drawing.Size(488, 23);
            this.destpathtxtbox.TabIndex = 4;
            // 
            // chooseDestPath
            // 
            this.chooseDestPath.Location = new System.Drawing.Point(624, 134);
            this.chooseDestPath.Name = "chooseDestPath";
            this.chooseDestPath.Size = new System.Drawing.Size(130, 23);
            this.chooseDestPath.TabIndex = 5;
            this.chooseDestPath.Text = "Choose Destination Path";
            this.chooseDestPath.UseVisualStyleBackColor = true;
            this.chooseDestPath.Click += new System.EventHandler(this.chooseDestPathButton);
            // 
            // ImportToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 449);
            this.Controls.Add(this.chooseDestPath);
            this.Controls.Add(this.destpathtxtbox);
            this.Controls.Add(this.destpathlable);
            this.Controls.Add(this.ImportPathLable);
            this.Controls.Add(this.importpathtxtbox);
            this.Controls.Add(this.chooseImportPath);
            this.Name = "ImportToolWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button chooseImportPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox importpathtxtbox;
        private Label ImportPathLable;
        private Label destpathlable;
        private TextBox destpathtxtbox;
        private Button chooseDestPath;
    }
}