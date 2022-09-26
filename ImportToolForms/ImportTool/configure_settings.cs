using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportTool
{
    public partial class configure_settings : Form
    {
        private string about_string;
        private string configFilePath = "import.cfg";
        public configure_settings()
        {
            InitializeComponent();
            this.defaultPath_txtbox.Text = ConfigHolderSingelton.Instance.getDefaultpathString();
            string version = ConfigHolderSingelton.Instance.getVersion();
            about_string = "\n=============ABOUT==============";
            about_string += "\n# IMPORTING MADE EASY";
            about_string += "\n# Importer V " + version + "    ";
            about_string += "\n# A program by @Wes Stillwell  ";
            about_string += "\n# Let me know if ur enjoying it";
            about_string += "\n================================";
            about_string += "\n";
            about_txtbox.Text = about_string;
            about_txtbox.Update(); 

        }

        private void chooseDefaultPath_Click(object sender, EventArgs e) 
        {
            FolderBrowserDialog importPathDialog = new FolderBrowserDialog() { Description = "Select DEFAULT Folder" };
            if (importPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ConfigHolderSingelton.Instance.setNewDefaultpath(importPathDialog.SelectedPath);
                defaultPath_txtbox.Text = ConfigHolderSingelton.Instance.getDefaultpathString();
                WLog.record("DEFAULT Path : " + ConfigHolderSingelton.Instance.getImportPath());
                WLog.record("DEFAULT Path OK");
                //defaultPath_txtbox.AppendText(WLog.dumpLog());
                defaultPath_txtbox.Update();
                about_txtbox.AppendText(WLog.dumpLog());
                about_txtbox.Update();

            }
        }
    
        private void backButton_click(object sender, EventArgs e)
        {
            WLog.record("Writing to file and Closing");

            writeTofile();
            //defaultPath_txtbox.AppendText(WLog.dumpLog());
            about_txtbox.AppendText(WLog.dumpLog());
            about_txtbox.Update();
            this.Close();

        }

        private static async Task writeTofile()
        { 
            string newDefaultFile = ConfigHolderSingelton.Instance.getDefaultpathString();
            string cfg_filepath = ConfigHolderSingelton.Instance.defaultPathFilename;
            await File.WriteAllTextAsync(ConfigHolderSingelton.Instance.defaultPathFilename, newDefaultFile) ;

        }
    }
}
