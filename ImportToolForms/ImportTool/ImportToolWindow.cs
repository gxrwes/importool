namespace ImportTool
{
    public partial class ImportToolWindow : Form
    {
        private ConfigHolderSingelton config = new ConfigHolderSingelton();
        private ImporterCopy ic;
        public static bool updating = true;
        public ImportToolWindow()
        {
            InitializeComponent();
            ic = new ImporterCopy();
           
        }

        public void Update()
        {
            while (updating)
            {
                // update window
                // ic.Update();
                string temp =  WLog.dumpLog();
                logTxtBox.Text += temp;
                //logTxtBox.u
                logTxtBox.Update();
                logTxtBox.Refresh();
                progressLable1.Text = ConfigHolderSingelton.Instance.getJobName();
                progressLable1.Refresh();
                Thread.Sleep(100);
                progressBarCopy.Increment(1);
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
            if (configCheckboxDefault.Checked)
            {
                config.setJobName(jobnameLable.Text);
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
                config.setJobName(jobnameLable.Text);
;                if (configCheckboxRenameImport.Checked) config.setRenameImport(true);
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
            WLog.record("STARTING IMPORT");
            Thread copythread = new Thread(new ThreadStart( threadCopy ));
            copythread.Start();
            //mainUpdate.Start();
            // Start import
            updating = true;
            Update();
            copythread.Join();
            WLog.record("IMPORT COMPLETE");
            WLog.record("EOF");
            logTxtBox.Refresh();


        }
        private void threadCopy()
        {
            bool x = ic.StartCopy(config.getImportPath(),config.getDestinationPath());
            
        }
        private void _t_update()
        {
           
        }
    }
}