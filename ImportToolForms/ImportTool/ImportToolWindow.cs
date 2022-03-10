namespace ImportTool
{
    public partial class ImportToolWindow : Form
    {
        private ConfigHolderSingelton config = new ConfigHolderSingelton();
        private ImporterCopy ic;
        public ImportToolWindow()
        {
            InitializeComponent();
            ic = new ImporterCopy(this);
        }

        public void Update()
        {
            // update window
            progressLable1.Text = (ic.getCopyCounter()).ToString();
            progressLable1.Refresh();
        }
        private void importPathButton(object sender, EventArgs e)
        {
            FolderBrowserDialog importPathDialog = new FolderBrowserDialog() { Description = "Select folder to import"};
            if (importPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                config.setImportPath(importPathDialog.SelectedPath);
                importpathtxtbox.Text = config.getImportPath();
            }

        }
        private void chooseDestPathButton(object sender, EventArgs e)
        {

            FolderBrowserDialog destPathDialog = new FolderBrowserDialog() { Description = "Select folder to import" };
            if (destPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.setImportPath(destPathDialog.SelectedPath);
                destpathtxtbox.Text = config.getImportPath();  
            }
        }
        private void initialConfigInput1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StartImport_Click(object sender, EventArgs e)
        {
            if (configCheckboxDefault.Checked)
            {
                config.setDefault();
                config.setRenameImport(true);
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameOriginal.Enabled = false;
                configCheckboxAutoBackup.Enabled = false;
            }
            else
            {
                if (configCheckboxRenameImport.Checked) config.setRenameImport(true);
                else config.setRenameImport(false);
                if (configCheckboxRenameOriginal.Checked) config.setRenamePrefix("_");
                else config.setRenamePrefix("");
            }

            ic.setForm(this);   
            ic.StartCopy();
            Update();
            // Start import

        }
    }
}