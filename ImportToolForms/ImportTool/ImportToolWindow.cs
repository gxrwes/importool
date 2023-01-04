using System.Diagnostics;

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
            WLog.record("LOADING:Main.Class.ImportToolWindow");
            string temp = WLog.dumpLog();
            logTxtBox.AppendText(temp);
            logTxtBox.Update();

        }

        public void Update()
        {
            ConfigHolderSingelton.Instance.addToJobWatcher();
            float progress = 0;
            float step = ConfigHolderSingelton.Instance.getOnePercent();
            while (updating)
            {
                // Show Log in Log Box
                string temp =  WLog.dumpLog();
                logTxtBox.AppendText( temp ) ;
                logTxtBox.Update();
               
                if(ConfigHolderSingelton.Instance.getProgressPercent() < progressBarCopy.Maximum)
                    progressBarCopy.Value =(int) ConfigHolderSingelton.Instance.getProgressPercent();
                progressBarCopy.Refresh();
                progressLable1.Text = progress.ToString();
                progressLable1.Refresh();
                //Thread.Sleep(500);
                
                
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
                ConfigHolderSingelton.Instance.setImportPath(importPathDialog.SelectedPath);
                ConfigHolderSingelton.Instance.setImportPath(importPathDialog.SelectedPath);
                importpathtxtbox.Text = ConfigHolderSingelton.Instance.getImportPath();
                WLog.record("Import Path : "+ ConfigHolderSingelton.Instance.getImportPath());
                WLog.record("Import Path OK");
                logTxtBox.AppendText(WLog.dumpLog());
                logTxtBox.Update();

            }

        }
        private void chooseDestPathButton(object sender, EventArgs e)
        {
            FolderBrowserDialog destPathDialog = new FolderBrowserDialog() { Description = "Select folder to import" };
            if (destPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConfigHolderSingelton.Instance.setDestPath(destPathDialog.SelectedPath);
                destpathtxtbox.Text = ConfigHolderSingelton.Instance.getImportPath();
                WLog.record("SRC Path OK");
            }
        }
        private void configSettingsButton_Click(object sender, EventArgs e)
        {
            configure_settings form = new configure_settings();

            form.Show();
            string temp = WLog.dumpLog();
            logTxtBox.AppendText(temp);
            logTxtBox.Update();
        }
        private void initialConfigInput1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StartImport_Click(object sender, EventArgs e)
        {
            ConfigHolderSingelton.Instance.setJobName(jobnameTextbox.Text.ToString());
            //ConfigHolderSingelton.Instance.setCamera(camerabox.Text.ToString());
            WLog.record("CAMERA DETECT " + ConfigHolderSingelton.Instance.getCamera() );
            if (ConfigHolderSingelton.Instance.getJobName().Length < 1) WLog.record("No Jobname Selected");
            if (camerabox.Text.Length > 0)ConfigHolderSingelton.Instance.setCamera(camerabox.Text);
            if(ConfigHolderSingelton.Instance.getImportPath() == "")
            {
                string title = "Alert! ";
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
                ConfigHolderSingelton.Instance.setDefault();
                ConfigHolderSingelton.Instance.setRenameImport(true);
                ConfigHolderSingelton.Instance.setCreateProject(true);
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameOriginal.Enabled = false;
                configCheckboxAutoBackup.Enabled = false;
                configCheckboxCreateProject.Enabled = true;
                destpathtxtbox.Text = ConfigHolderSingelton.Instance.getDestinationPath();
                WLog.record("DEFAULT SET");
            }
            else
            {
                if (configCheckboxRenameImport.Checked) ConfigHolderSingelton.Instance.setRenameImport(true);
                else ConfigHolderSingelton.Instance.setRenameImport(false);
                WLog.record("\trename import " + ConfigHolderSingelton.Instance.getRenameOriginalBool);
                if (configCheckboxRenameOriginal.Checked) ConfigHolderSingelton.Instance.setRenamePrefix("_");
                if (configCheckboxCreateProject.Checked) ConfigHolderSingelton.Instance.setCreateProject(true);
                else ConfigHolderSingelton.Instance.setCreateProject(false);
                WLog.record("\tcreate Project " + ConfigHolderSingelton.Instance.getCreateProject);
            }


            // Thread mainUpdate = new Thread(new ThreadStart(Update));
            StartImport.Enabled = false;
            jobnameTextbox.ReadOnly = true;
            // Set new dest path with updated values
            //ConfigHolderSingelton.Instance.setDestPath( ConfigHolderSingelton.Instance.projectPathBuilder());
            string temp01 =  ConfigHolderSingelton.Instance.projectPathBuilder();
            WLog.record("Setting SRC Path to "+ ConfigHolderSingelton.Instance.getImportPath() );
            WLog.record("Setting DEST Path to\t" + ConfigHolderSingelton.Instance.getDestinationPath());
            WLog.record("Setting CAMERA to\t\t" + ConfigHolderSingelton.Instance.getCamera());
            // count target

            // Start Import
            WLog.record("-------------------------------------------------");
            WLog.record("STARTING IMPORT");
            WLog.record("-------------------------------------------------");
            ConfigHolderSingelton.Instance.addToJobWatcher();
            Thread copythread = new Thread(new ThreadStart( threadCopy ));
            copythread.Start();
            updating = true;
            Update();
            copythread.Join();
            ConfigHolderSingelton.Instance.fireJob();


            if (configCheckboxCreateProject.Enabled == true)
            {
                WLog.record("Creating Premiere Project");
                ConfigHolderSingelton.Instance.setCreateProject(true);
                try
                {
                    string src = ConfigHolderSingelton.Instance.getPMTemplatePath();
                    string dest = ConfigHolderSingelton.Instance.tempPMtargetPath + "_.prproj.";
                    File.Copy(src,dest, false);
                }
                catch (IOException iox)
                {
                    WLog.record("ERROR:0x101 - could not create project" + iox.Message);
                }
            }

            // End messages
            WLog.record("-------------------------------------------------");
            WLog.record("IMPORT COMPLETE");
            WLog.record("-------------------------------------------------");
            WLog.record("EOP");
            logTxtBox.Refresh(); 
            WLog.saveLog(ConfigHolderSingelton.Instance.getDestinationPath());
            DialogResult result2 = MessageBox.Show("Import Done, Click OK to close ", "Alert!", MessageBoxButtons.OK);
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
            
            bool x = ic.StartCopy(ConfigHolderSingelton.Instance.getImportPath(),ConfigHolderSingelton.Instance.getDestinationPath());
        }
        private void _t_update()
        {
           
        }

        private void logTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}