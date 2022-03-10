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
            FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select folder to import"};
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                //dialog.RootFolder;
                config.setImportPath(dialog.SelectedPath);
                importpathtxtbox.Text = config.getImportPath();
            }
        }
    }
}