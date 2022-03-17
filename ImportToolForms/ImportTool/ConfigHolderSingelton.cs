using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ImportTool
{

    public sealed class  ConfigHolderSingelton
    {
        //SINGELTON
        private static ConfigHolderSingelton instance = null;
        private static readonly object padlock = new object();

        private static int _jobsInProgress = 0;
        // Import Configs
        //---------------

        private string importJobName = "";
        private string defaultPath = @"F:\MediaProjects\Videos\";
        private bool isDefault = false;
        private bool createProject = true;

        // FILE PATHS
        private string importPath = "";
        private string destPath = "";
        private bool extensionFilterBool = false;
        private string extensionFilter = "*";
        private bool searchRecursiveB = true;
        private bool projAdded = false;

        // CopyJob Original File Hanlder
        private bool renameOriginalBool = false;
        private string renameOriginalCopyPrefix = "";


        // Import Rename with tags
        private bool renameImport = false;


        // Constructors
        public static ConfigHolderSingelton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ConfigHolderSingelton();
                    }
                    return instance;
                }
            }
        }
             

        // Getters
        public bool IsDefault() { return isDefault; }
        public string getImportPath()
        {
            return this.importPath;
        }
        public string getDestinationPath()
        {
            return this.destPath;
        }
        public string getRenamePrefix()
        {
            return this.renameOriginalCopyPrefix;
        }
        public string getJobName() { return this.importJobName; }
        public string getExtensionFilter() { return this.extensionFilter; }
        public bool getRenameOriginalBool() { return this.renameOriginalBool; }
        public bool searchRecursive() { return this.searchRecursiveB; }
        public bool getCreateProject() { return this.createProject; }

        public string getCamera()
        {
            return "Camera01";
        }
        public bool jobInProgress()
        {
            if (_jobsInProgress > 0) return true;
            return false;
        }


        // Setters
        public void setExtenstionFilter(string ext)
        {
            if (ext.Length > 0)
            {
                this.extensionFilter = ext;
                this.extensionFilterBool = true;
            }
            else
            {
                this.extensionFilterBool = false;
                // throw exception at somepoint
            }
        }
        public void setRenamePrefix(string prefix)
        {
            if (prefix.Length > 0)
            {
                this.renameOriginalBool = true;
            }
            else
            {
                this.renameOriginalBool = false;
                // throw exception at somepoint
            }
            this.renameOriginalCopyPrefix = prefix;
        }
        public void setImportPath(string path) 
        {
            isDefault = false;
            this.importPath = path; 
        }
        public void setDestPath(string path) 
        { 
            this.destPath = path; 
        }
        public void setJobName(string name)
        {
            this.importJobName = name;
        }
        public void setDefault() 
        {
            isDefault=true;
            this.setDestPath(this.defaultPath);
            this.setExtenstionFilter("mp4");
            this.setRenamePrefix("_");
        }
        public void setRenameImport(bool renamebool)
        {
            this.renameOriginalBool = renamebool;
        }
        public void setSearchRecursive(bool value) { this.searchRecursiveB = value; }
        public void setCreateProject(bool value) 
        { 
            this.createProject = value;
            if (this.createProject && !projAdded)
            {
                projAdded = true;   
                destPath += projectPathBuilder();
                ImporterCopy.testOrBuildDirectory(destPath);
            }
        }

        public string projectPathBuilder()
        {
            string tempPath = "";
            DateTime dat = DateTime.Now;
            // add directory Year to path
            tempPath = dat.Year + "\\";
            // add directory Jobname and number
            string dayFormat = dat.DayOfYear.ToString();
            if (dayFormat.Length == 2) dayFormat = "0" + dayFormat;
            else if(dayFormat.Length == 1) dayFormat = "00" + dayFormat;
            //tempPath += "["+ dayFormat + "]_" + this.getJobName() + "\\";
            tempPath += "[" + dayFormat + "]_" +  "\\";
            // add directory Footage
            tempPath += "Footage\\" + this.getCamera() + "\\";
            return tempPath;

        }
        public void addToJobWatcher() 
        {
            _jobsInProgress++;
        }
        public void fireJob() { _jobsInProgress--; }

    }
}
