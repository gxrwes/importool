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

        private Config cf = new Config();

        //Temp variables
        string newPath;
        string newPMPath;
        public configure_settings()
        {
            InitializeComponent();
            
            string version = ConfigHolderSingelton.Instance.getVersion();
            about_string = "\n=============ABOUT==============";
            about_string += "\n# IMPORTING MADE EASY";
            about_string += "\n# Importer V " + version + "    ";
            about_string += "\n# A program by   ";
            about_string += "\n# @Wes Stillwell, wesley.st96@yahoo.de  ";
            about_string += "\n# Let me know if ur enjoying it";
            about_string += "\n================================";
            about_string += "\n";
            about_txtbox.Text = about_string;
            about_txtbox.Update();

            newPath = ConfigHolderSingelton.Instance.getDefaultpathString();
            this.defaultPath_txtbox.Text = ConfigHolderSingelton.Instance.getDefaultpathString();
            newPMPath = ConfigHolderSingelton.Instance.getPMTemplatePath();
            this.defaultPMFile_textbox.Text = newPMPath;

        }

        private void chooseDefaultPath_Click(object sender, EventArgs e) 
        {
            FolderBrowserDialog importPathDialog = new FolderBrowserDialog() { Description = "Select DEFAULT Folder" };
            if (importPathDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                newPath = importPathDialog.SelectedPath;

                defaultPath_txtbox.Text = newPath + "\\";
                WLog.record("DEFAULT Path : " + newPath);
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

            // Accept changes, Update, then leave
            ConfigHolderSingelton.Instance.setNewDefaultpath(newPath);
            ConfigHolderSingelton.Instance.setPMTemplatePath(newPMPath);

            // Write the settings to the config
            cf.saveConfig();    

            //defaultPath_txtbox.AppendText(WLog.dumpLog());
            about_txtbox.AppendText(WLog.dumpLog());
            about_txtbox.Update();
            WLog.record("Closing Configure Window Mode: Apply Settings");
            this.Close();

        }

        private void cancel_click(object sender, EventArgs e)
        {
            WLog.record("Cancelling and Closing");
            about_txtbox.AppendText(WLog.dumpLog());
            about_txtbox.Update();
            WLog.record("Closing Configure Window Mode: Cancel");
            this.Close();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chooseDefPMTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Premiere Pro Project|*.prproj";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                newPMPath = openFileDialog.FileName;

                defaultPMFile_textbox.Text = newPMPath;
                WLog.record("DEFAULT Path : " + newPMPath);
                WLog.record("DEFAULT Path OK");
                //defaultPath_txtbox.AppendText(WLog.dumpLog());
                defaultPMFile_textbox.Update();
                about_txtbox.AppendText(WLog.dumpLog());
                about_txtbox.Update();
            }
           
        }
    }
}
