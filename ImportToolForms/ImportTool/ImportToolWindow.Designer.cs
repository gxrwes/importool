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
            this.configCheckboxDefault = new System.Windows.Forms.CheckBox();
            this.configCheckboxRenameImport = new System.Windows.Forms.CheckBox();
            this.configCheckboxRenameOriginal = new System.Windows.Forms.CheckBox();
            this.configCheckboxAutoBackup = new System.Windows.Forms.CheckBox();
            this.StartImport = new System.Windows.Forms.Button();
            this.progressBarCopy = new System.Windows.Forms.ProgressBar();
            this.progressLable1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chooseImportPath
            // 
            this.chooseImportPath.Location = new System.Drawing.Point(612, 66);
            this.chooseImportPath.Name = "chooseImportPath";
            this.chooseImportPath.Size = new System.Drawing.Size(130, 23);
            this.chooseImportPath.TabIndex = 0;
            this.chooseImportPath.Text = "Choose Import Path";
            this.chooseImportPath.UseVisualStyleBackColor = true;
            this.chooseImportPath.Click += new System.EventHandler(this.importPathButton);
            // 
            // importpathtxtbox
            // 
            this.importpathtxtbox.Location = new System.Drawing.Point(118, 67);
            this.importpathtxtbox.Name = "importpathtxtbox";
            this.importpathtxtbox.ReadOnly = true;
            this.importpathtxtbox.Size = new System.Drawing.Size(488, 23);
            this.importpathtxtbox.TabIndex = 1;
            // 
            // ImportPathLable
            // 
            this.ImportPathLable.AutoSize = true;
            this.ImportPathLable.Location = new System.Drawing.Point(12, 75);
            this.ImportPathLable.Name = "ImportPathLable";
            this.ImportPathLable.Size = new System.Drawing.Size(76, 15);
            this.ImportPathLable.TabIndex = 2;
            this.ImportPathLable.Text = "Import Path :";
            // 
            // destpathlable
            // 
            this.destpathlable.AutoSize = true;
            this.destpathlable.Location = new System.Drawing.Point(12, 104);
            this.destpathlable.Name = "destpathlable";
            this.destpathlable.Size = new System.Drawing.Size(100, 15);
            this.destpathlable.TabIndex = 3;
            this.destpathlable.Text = "Destination Path :";
            // 
            // destpathtxtbox
            // 
            this.destpathtxtbox.Location = new System.Drawing.Point(118, 96);
            this.destpathtxtbox.Name = "destpathtxtbox";
            this.destpathtxtbox.ReadOnly = true;
            this.destpathtxtbox.Size = new System.Drawing.Size(488, 23);
            this.destpathtxtbox.TabIndex = 4;
            // 
            // chooseDestPath
            // 
            this.chooseDestPath.Location = new System.Drawing.Point(612, 95);
            this.chooseDestPath.Name = "chooseDestPath";
            this.chooseDestPath.Size = new System.Drawing.Size(130, 23);
            this.chooseDestPath.TabIndex = 5;
            this.chooseDestPath.Text = "Choose Destination Path";
            this.chooseDestPath.UseVisualStyleBackColor = true;
            this.chooseDestPath.Click += new System.EventHandler(this.chooseDestPathButton);
            // 
            // configCheckboxDefault
            // 
            this.configCheckboxDefault.AutoSize = true;
            this.configCheckboxDefault.Location = new System.Drawing.Point(116, 131);
            this.configCheckboxDefault.Name = "configCheckboxDefault";
            this.configCheckboxDefault.Size = new System.Drawing.Size(128, 19);
            this.configCheckboxDefault.TabIndex = 7;
            this.configCheckboxDefault.Text = "use default settings";
            this.configCheckboxDefault.UseVisualStyleBackColor = true;
            // 
            // configCheckboxRenameImport
            // 
            this.configCheckboxRenameImport.AutoSize = true;
            this.configCheckboxRenameImport.Location = new System.Drawing.Point(116, 156);
            this.configCheckboxRenameImport.Name = "configCheckboxRenameImport";
            this.configCheckboxRenameImport.Size = new System.Drawing.Size(118, 19);
            this.configCheckboxRenameImport.TabIndex = 8;
            this.configCheckboxRenameImport.Text = "rename imported";
            this.configCheckboxRenameImport.UseVisualStyleBackColor = true;
            // 
            // configCheckboxRenameOriginal
            // 
            this.configCheckboxRenameOriginal.AutoSize = true;
            this.configCheckboxRenameOriginal.Location = new System.Drawing.Point(116, 181);
            this.configCheckboxRenameOriginal.Name = "configCheckboxRenameOriginal";
            this.configCheckboxRenameOriginal.Size = new System.Drawing.Size(109, 19);
            this.configCheckboxRenameOriginal.TabIndex = 8;
            this.configCheckboxRenameOriginal.Text = "rename original";
            this.configCheckboxRenameOriginal.UseVisualStyleBackColor = true;
            // 
            // configCheckboxAutoBackup
            // 
            this.configCheckboxAutoBackup.AutoSize = true;
            this.configCheckboxAutoBackup.Location = new System.Drawing.Point(116, 206);
            this.configCheckboxAutoBackup.Name = "configCheckboxAutoBackup";
            this.configCheckboxAutoBackup.Size = new System.Drawing.Size(92, 19);
            this.configCheckboxAutoBackup.TabIndex = 9;
            this.configCheckboxAutoBackup.Text = "auto backup";
            this.configCheckboxAutoBackup.UseVisualStyleBackColor = true;
            // 
            // StartImport
            // 
            this.StartImport.Location = new System.Drawing.Point(612, 246);
            this.StartImport.Name = "StartImport";
            this.StartImport.Size = new System.Drawing.Size(130, 23);
            this.StartImport.TabIndex = 10;
            this.StartImport.Text = "Start Import";
            this.StartImport.UseVisualStyleBackColor = true;
            this.StartImport.Click += new System.EventHandler(this.StartImport_Click);
            // 
            // progressBarCopy
            // 
            this.progressBarCopy.Location = new System.Drawing.Point(17, 523);
            this.progressBarCopy.Name = "progressBarCopy";
            this.progressBarCopy.Size = new System.Drawing.Size(725, 23);
            this.progressBarCopy.TabIndex = 11;
            // 
            // progressLable1
            // 
            this.progressLable1.AutoSize = true;
            this.progressLable1.Location = new System.Drawing.Point(711, 505);
            this.progressLable1.Name = "progressLable1";
            this.progressLable1.Size = new System.Drawing.Size(10, 15);
            this.progressLable1.TabIndex = 12;
            this.progressLable1.Text = ":";
            // 
            // ImportToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 556);
            this.Controls.Add(this.progressLable1);
            this.Controls.Add(this.progressBarCopy);
            this.Controls.Add(this.StartImport);
            this.Controls.Add(this.configCheckboxAutoBackup);
            this.Controls.Add(this.configCheckboxRenameOriginal);
            this.Controls.Add(this.configCheckboxRenameImport);
            this.Controls.Add(this.configCheckboxDefault);
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
        private CheckBox configCheckboxDefault;
        private CheckBox configCheckboxRenameImport;
        private CheckBox configCheckboxRenameOriginal;
        private CheckBox configCheckboxAutoBackup;
        private Button StartImport;
        private ProgressBar progressBarCopy;
        private Label progressLable1;
    }
}