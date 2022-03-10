using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportTool
{

    public sealed class  ConfigHolderSingelton
    {
        //SINGELTON
        private static ConfigHolderSingelton instance = null;
        private static readonly object padlock = new object();
        // Import Configs
        //---------------

        private string importJobName = "";
        private string defaultPath = @"C:\temp";

        // FILE PATHS
        private string importPath = "";
        private string destPath = "";
        private bool extensionFilterBool = false;
        private string extensionFilter = "";

        // CopyJob Original File Hanlder
        private bool renameOriginalBool = false;
        private string renameOriginalCopyPrefix = "";


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
                this.renameOriginalCopyPrefix = prefix;
            }
            else
            {
                this.renameOriginalBool = false;
                // throw exception at somepoint
            }
        }

        public void setImportPath(string path) 
        { 
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

    }
}
