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
            this.StartImport = new System.Windows.Forms.Button();
            this.progressBarCopy = new System.Windows.Forms.ProgressBar();
            this.progressLable1 = new System.Windows.Forms.Label();
            this.logTxtBox = new System.Windows.Forms.RichTextBox();
            this.configCheckboxCreateProject = new System.Windows.Forms.CheckBox();
            this.jobnameTextbox = new System.Windows.Forms.TextBox();
            this.jobnameLable = new System.Windows.Forms.Label();
            this.camerabox = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.configSettingsButton = new System.Windows.Forms.Button();
            this.prefixBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseImportPath
            // 
            this.chooseImportPath.Location = new System.Drawing.Point(874, 110);
            this.chooseImportPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseImportPath.Name = "chooseImportPath";
            this.chooseImportPath.Size = new System.Drawing.Size(186, 38);
            this.chooseImportPath.TabIndex = 0;
            this.chooseImportPath.Text = "Choose Import Path";
            this.chooseImportPath.UseVisualStyleBackColor = true;
            this.chooseImportPath.Click += new System.EventHandler(this.importPathButton);
            // 
            // importpathtxtbox
            // 
            this.importpathtxtbox.Location = new System.Drawing.Point(169, 112);
            this.importpathtxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importpathtxtbox.Name = "importpathtxtbox";
            this.importpathtxtbox.ReadOnly = true;
            this.importpathtxtbox.Size = new System.Drawing.Size(695, 31);
            this.importpathtxtbox.TabIndex = 1;
            // 
            // ImportPathLable
            // 
            this.ImportPathLable.AutoSize = true;
            this.ImportPathLable.Location = new System.Drawing.Point(51, 125);
            this.ImportPathLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImportPathLable.Name = "ImportPathLable";
            this.ImportPathLable.Size = new System.Drawing.Size(115, 25);
            this.ImportPathLable.TabIndex = 2;
            this.ImportPathLable.Text = "Import Path :";
            // 
            // destpathlable
            // 
            this.destpathlable.AutoSize = true;
            this.destpathlable.Location = new System.Drawing.Point(17, 173);
            this.destpathlable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destpathlable.Name = "destpathlable";
            this.destpathlable.Size = new System.Drawing.Size(150, 25);
            this.destpathlable.TabIndex = 3;
            this.destpathlable.Text = "Destination Path :";
            // 
            // destpathtxtbox
            // 
            this.destpathtxtbox.Location = new System.Drawing.Point(169, 160);
            this.destpathtxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destpathtxtbox.Name = "destpathtxtbox";
            this.destpathtxtbox.ReadOnly = true;
            this.destpathtxtbox.Size = new System.Drawing.Size(695, 31);
            this.destpathtxtbox.TabIndex = 4;
            // 
            // chooseDestPath
            // 
            this.chooseDestPath.Location = new System.Drawing.Point(874, 158);
            this.chooseDestPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseDestPath.Name = "chooseDestPath";
            this.chooseDestPath.Size = new System.Drawing.Size(186, 38);
            this.chooseDestPath.TabIndex = 5;
            this.chooseDestPath.Text = "Choose Destination Path";
            this.chooseDestPath.UseVisualStyleBackColor = true;
            this.chooseDestPath.Click += new System.EventHandler(this.chooseDestPathButton);
            // 
            // configCheckboxDefault
            // 
            this.configCheckboxDefault.AutoSize = true;
            this.configCheckboxDefault.Location = new System.Drawing.Point(166, 218);
            this.configCheckboxDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configCheckboxDefault.Name = "configCheckboxDefault";
            this.configCheckboxDefault.Size = new System.Drawing.Size(192, 29);
            this.configCheckboxDefault.TabIndex = 7;
            this.configCheckboxDefault.Text = "use default settings";
            this.configCheckboxDefault.UseVisualStyleBackColor = true;
            // 
            // configCheckboxRenameImport
            // 
            this.configCheckboxRenameImport.AutoSize = true;
            this.configCheckboxRenameImport.Location = new System.Drawing.Point(166, 260);
            this.configCheckboxRenameImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configCheckboxRenameImport.Name = "configCheckboxRenameImport";
            this.configCheckboxRenameImport.Size = new System.Drawing.Size(176, 29);
            this.configCheckboxRenameImport.TabIndex = 8;
            this.configCheckboxRenameImport.Text = "rename imported";
            this.configCheckboxRenameImport.UseVisualStyleBackColor = true;
            // 
            // configCheckboxRenameOriginal
            // 
            this.configCheckboxRenameOriginal.AutoSize = true;
            this.configCheckboxRenameOriginal.Location = new System.Drawing.Point(166, 302);
            this.configCheckboxRenameOriginal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configCheckboxRenameOriginal.Name = "configCheckboxRenameOriginal";
            this.configCheckboxRenameOriginal.Size = new System.Drawing.Size(161, 29);
            this.configCheckboxRenameOriginal.TabIndex = 8;
            this.configCheckboxRenameOriginal.Text = "rename original";
            this.configCheckboxRenameOriginal.UseVisualStyleBackColor = true;
            // 
            // StartImport
            // 
            this.StartImport.Location = new System.Drawing.Point(874, 410);
            this.StartImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartImport.Name = "StartImport";
            this.StartImport.Size = new System.Drawing.Size(186, 38);
            this.StartImport.TabIndex = 10;
            this.StartImport.Text = "Start Import";
            this.StartImport.UseVisualStyleBackColor = true;
            this.StartImport.Click += new System.EventHandler(this.StartImport_Click);
            // 
            // progressBarCopy
            // 
            this.progressBarCopy.Location = new System.Drawing.Point(24, 458);
            this.progressBarCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarCopy.Name = "progressBarCopy";
            this.progressBarCopy.Size = new System.Drawing.Size(1036, 38);
            this.progressBarCopy.TabIndex = 11;
            // 
            // progressLable1
            // 
            this.progressLable1.AutoSize = true;
            this.progressLable1.Location = new System.Drawing.Point(24, 502);
            this.progressLable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLable1.Name = "progressLable1";
            this.progressLable1.Size = new System.Drawing.Size(16, 25);
            this.progressLable1.TabIndex = 12;
            this.progressLable1.Text = ":";
            // 
            // logTxtBox
            // 
            this.logTxtBox.Location = new System.Drawing.Point(166, 503);
            this.logTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logTxtBox.Name = "logTxtBox";
            this.logTxtBox.Size = new System.Drawing.Size(893, 361);
            this.logTxtBox.TabIndex = 13;
            this.logTxtBox.Text = "";
            this.logTxtBox.TextChanged += new System.EventHandler(this.logTxtBox_TextChanged);
            // 
            // configCheckboxCreateProject
            // 
            this.configCheckboxCreateProject.AutoSize = true;
            this.configCheckboxCreateProject.Location = new System.Drawing.Point(166, 341);
            this.configCheckboxCreateProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configCheckboxCreateProject.Name = "configCheckboxCreateProject";
            this.configCheckboxCreateProject.Size = new System.Drawing.Size(144, 29);
            this.configCheckboxCreateProject.TabIndex = 14;
            this.configCheckboxCreateProject.Text = "create Project";
            this.configCheckboxCreateProject.UseVisualStyleBackColor = true;
            // 
            // jobnameTextbox
            // 
            this.jobnameTextbox.Location = new System.Drawing.Point(169, 63);
            this.jobnameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jobnameTextbox.Name = "jobnameTextbox";
            this.jobnameTextbox.Size = new System.Drawing.Size(141, 31);
            this.jobnameTextbox.TabIndex = 15;
            // 
            // jobnameLable
            // 
            this.jobnameLable.AutoSize = true;
            this.jobnameLable.Location = new System.Drawing.Point(73, 77);
            this.jobnameLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobnameLable.Name = "jobnameLable";
            this.jobnameLable.Size = new System.Drawing.Size(93, 25);
            this.jobnameLable.TabIndex = 16;
            this.jobnameLable.Text = "Jobname :";
            // 
            // camerabox
            // 
            this.camerabox.Location = new System.Drawing.Point(450, 63);
            this.camerabox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.camerabox.Name = "camerabox";
            this.camerabox.Size = new System.Drawing.Size(141, 31);
            this.camerabox.TabIndex = 17;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(354, 77);
            this.lable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(76, 25);
            this.lable2.TabIndex = 18;
            this.lable2.Text = "Camera:";
            // 
            // configSettingsButton
            // 
            this.configSettingsButton.Location = new System.Drawing.Point(874, 213);
            this.configSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.configSettingsButton.Name = "configSettingsButton";
            this.configSettingsButton.Size = new System.Drawing.Size(186, 38);
            this.configSettingsButton.TabIndex = 19;
            this.configSettingsButton.Text = "Configure Setings";
            this.configSettingsButton.UseVisualStyleBackColor = true;
            this.configSettingsButton.Click += new System.EventHandler(this.configSettingsButton_Click);
            // 
            // prefixBox
            // 
            this.prefixBox.Location = new System.Drawing.Point(354, 302);
            this.prefixBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prefixBox.MaxLength = 5;
            this.prefixBox.Name = "prefixBox";
            this.prefixBox.Size = new System.Drawing.Size(59, 31);
            this.prefixBox.TabIndex = 20;
            // 
            // ImportToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 927);
            this.Controls.Add(this.prefixBox);
            this.Controls.Add(this.configSettingsButton);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.camerabox);
            this.Controls.Add(this.jobnameLable);
            this.Controls.Add(this.jobnameTextbox);
            this.Controls.Add(this.configCheckboxCreateProject);
            this.Controls.Add(this.logTxtBox);
            this.Controls.Add(this.progressLable1);
            this.Controls.Add(this.progressBarCopy);
            this.Controls.Add(this.StartImport);
            this.Controls.Add(this.configCheckboxRenameOriginal);
            this.Controls.Add(this.configCheckboxRenameImport);
            this.Controls.Add(this.configCheckboxDefault);
            this.Controls.Add(this.chooseDestPath);
            this.Controls.Add(this.destpathtxtbox);
            this.Controls.Add(this.destpathlable);
            this.Controls.Add(this.ImportPathLable);
            this.Controls.Add(this.importpathtxtbox);
            this.Controls.Add(this.chooseImportPath);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private Button StartImport;
        private ProgressBar progressBarCopy;
        private Label progressLable1;
        private RichTextBox logTxtBox;
        private CheckBox configCheckboxCreateProject;
        private TextBox jobnameTextbox;
        private Label jobnameLable;
        private TextBox camerabox;
        private Label lable2;
        private Button configSettingsButton;
        private TextBox prefixBox;
    }
}