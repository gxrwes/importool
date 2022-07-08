namespace ImportTool
{
    public partial class ImportToolWindow : Form
    {
        private ConfigHolderSingelton config = new ConfigHolderSingelton();
        private ImporterCopy ic;
        public static bool updating = true;
        private int originalCoutn = 0;
        
        public ImportToolWindow()
        {
            InitializeComponent();
            ic = new ImporterCopy();
           
        }

        public void Update()
        {
            ConfigHolderSingelton.Instance.addToJobWatcher();
            float progress = 0;
            float step = ConfigHolderSingelton.Instance.getOnePercent();
            while (updating)
            {
                string temp =  WLog.dumpLog();
                logTxtBox.AppendText( temp ) ;
                logTxtBox.Update();
                //logTxtBox.Refresh();
               
                if(ConfigHolderSingelton.Instance.getProgressPercent() < progressBarCopy.Maximum)
                    progressBarCopy.Value =(int) ConfigHolderSingelton.Instance.getProgressPercent();
                progressBarCopy.Refresh();
                progressLable1.Text = progress.ToString();
                progressLable1.Refresh();
                Thread.Sleep(200);
                
                
                if(!ConfigHolderSingelton.Instance.jobInProgress() && ConfigHolderSingelton.Instance.getProgressPercent() > 99) updating = false;
            }
            WLog.record("Closing Update");
            progressBarCopy.Value = progressBarCopy.Maximum;
            progressBarCopy.Refresh();
            ConfigHolderSingelton.Instance.fireJob();
        }
        private void importPathButton(object sender, EventArgs e)
        {
            FolderBrowserDialog importPathDialog = new FolderBrowserDialog() { Description = "Select folder to import"};
            if (importPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                config.setImportPath(importPathDialog.SelectedPath);
                importpathtxtbox.Text = config.getImportPath();
                WLog.record("Import Path OK");
            }

        }
        private void chooseDestPathButton(object sender, EventArgs e)
        {

            FolderBrowserDialog destPathDialog = new FolderBrowserDialog() { Description = "Select folder to import" };
            if (destPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.setDestPath(destPathDialog.SelectedPath);
                destpathtxtbox.Text = config.getImportPath();
                WLog.record("SRC Path OK");
            }
        }
        private void initialConfigInput1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StartImport_Click(object sender, EventArgs e)
        {
            ConfigHolderSingelton.Instance.setJobName(jobnameTextbox.Text.ToString());

            if (config.getJobName().Length < 1) WLog.record("No Jobname Selected");
            if (camera.Text.Length > 0)ConfigHolderSingelton.Instance.setCamera(camera.Text);
            if(config.getImportPath() == "")
            {
                string title = "Alert!";
                string message = "Import Path cannot be empty";
                WLog.record(title + message);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            if (configCheckboxDefault.Checked)
            {
                config.setDefault();
                config.setRenameImport(true);
                config.setCreateProject(true);
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameOriginal.Enabled = false;
                configCheckboxAutoBackup.Enabled = false;
                configCheckboxCreateProject.Enabled = false;
                destpathtxtbox.Text = config.getDestinationPath();
                WLog.record("DEFAULT SET");
            }
            else
            {
                if (configCheckboxRenameImport.Checked) config.setRenameImport(true);
                else config.setRenameImport(false);
                WLog.record("\trename import " + config.getRenameOriginalBool);
                if (configCheckboxRenameOriginal.Checked) config.setRenamePrefix("_");
                if (configCheckboxCreateProject.Checked) config.setCreateProject(true);
                else config.setCreateProject(false);
                WLog.record("\tcreate Project " + config.getCreateProject);
            }

            // Thread mainUpdate = new Thread(new ThreadStart(Update));
            StartImport.Enabled = false;
            jobnameTextbox.ReadOnly = true;
            // count target
           
            // Start Import
            WLog.record("STARTING IMPORT");
            ConfigHolderSingelton.Instance.addToJobWatcher();
            Thread copythread = new Thread(new ThreadStart( threadCopy ));
            copythread.Start();
            updating = true;
            Update();
            copythread.Join();
            ConfigHolderSingelton.Instance.fireJob();

            // End messages
            WLog.record("IMPORT COMPLETE");
            WLog.record("EOF");
            logTxtBox.Refresh(); 
            WLog.saveLog(ConfigHolderSingelton.Instance.getDestinationPath());
            DialogResult result2 = MessageBox.Show("Import Done, Click OK to close programm", "Alert!", MessageBoxButtons.OK);
            logTxtBox.Refresh();
            if (result2 == DialogResult.OK)
            {
                WLog.record("Dialog OK, Goodbye");
                this.Close();
            }

            logTxtBox.Refresh();

        }
        private void threadCopy()
        {
            bool x = ic.StartCopy(config.getImportPath(),config.getDestinationPath());
        }
        private void _t_update()
        {
           
        }

        private void logTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}