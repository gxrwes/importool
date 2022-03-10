namespace ImportTool
{
    public partial class ImportToolWindow : Form
    {
        private ConfigHolderSingelton config = new ConfigHolderSingelton();
        public ImportToolWindow()
        {
            InitializeComponent();
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
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameImport.Enabled = false;
                configCheckboxRenameOriginal.Enabled = false;
            }
        }
    }
}