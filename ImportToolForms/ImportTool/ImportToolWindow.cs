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
            float progress = 0;
            float step = config.getOnePercent();
            while (updating)
            {
                string temp =  WLog.dumpLog();
                logTxtBox.Text += temp;
                logTxtBox.Update();
                logTxtBox.Refresh();
                WLog.record("Progress: "+ config.getProgressPercent());
                if (progress < config.getProgressPercent())
                {
                    progress = config.getProgressPercent();
                    int i_t = (int)progress;
                    progressBarCopy.Value = i_t;
                }
                progressBarCopy.Refresh();
                progressLable1.Text = progress.ToString();
                progressLable1.Refresh();
                Thread.Sleep(100);
                
                if(!ConfigHolderSingelton.Instance.jobInProgress()) updating = false;
            }
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
                ConfigHolderSingelton.Instance.setJobName(jobnameLable.Text);
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
                ConfigHolderSingelton.Instance.setJobName(jobnameLable.Text);
                if (configCheckboxRenameImport.Checked) config.setRenameImport(true);
                else config.setRenameImport(false);
                WLog.record("\trename import " + config.getRenameOriginalBool);
                if (configCheckboxRenameOriginal.Checked) config.setRenamePrefix("_");
                if (configCheckboxCreateProject.Checked) config.setCreateProject(true);
                else config.setCreateProject(false);
                WLog.record("\tcreate Project " + config.getCreateProject);
            }

            //Thread mainUpdate = new Thread(new ThreadStart(Update));
            StartImport.Enabled = false;
            jobnameTextbox.ReadOnly = true;
            // count target
           
            // Start Import
            WLog.record("STARTING IMPORT");
            Thread copythread = new Thread(new ThreadStart( threadCopy ));
            copythread.Start();
            updating = true;
            Update();
            copythread.Join();

            // End messages
            WLog.record("IMPORT COMPLETE");
            WLog.record("EOF");
            logTxtBox.Refresh();
            DialogResult result2 = MessageBox.Show("Import Done, Click OK to close programm", "Alert!", MessageBoxButtons.OK);
            if (result2 == DialogResult.OK)
            {
                this.Close();
            }


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