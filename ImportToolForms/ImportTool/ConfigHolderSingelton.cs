﻿using System;
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

        // progess holders
        private static int _jobsInProgress = 0;
        private static int _originalTargetCount;
        private static int _progrssCount;
        // Import Configs
        //---------------

        private static string importJobName = "";
        private string defaultPath = @"F:\MediaProjects\Videos\";
        private bool isDefault = false;
        private bool createProject = true;

        // FILE PATHS
        private static string importPath = "";
        private static string destPath = "";
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
            return importPath;
        }
        public string getDestinationPath()
        {
            return destPath;
        }
        public string getRenamePrefix()
        {
            return this.renameOriginalCopyPrefix;
        }
        public string getJobName() { return importJobName; }
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
            importPath = path; 
            _originalTargetCount = ImporterCopy.countFiles(path);
        }
        public void setDestPath(string path) 
        { 
            destPath = path; 
        }
        public void setJobName(string name)
        {
            importJobName = name;
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
            tempPath += "["+ dayFormat + "]_" + getJobName() + "\\";
            //tempPath += "[" + dayFormat + "]_" +  "\\";
            // add directory Footage
            tempPath += "Footage\\" + this.getCamera() + "\\";
            return tempPath;

        }
        public void addToJobWatcher() 
        {
            _jobsInProgress++;
        }
        public void fireJob() { _jobsInProgress--; }
        public void addFileProgress(int value)
        {
            _progrssCount++;
        }
        public float getProgressPercent()
        {
            float temp = ( ((float)_originalTargetCount / 100) * _progrssCount ) * 100;
            return temp;
        }
        public float getOnePercent()
        {
            return ((float)_originalTargetCount / 100);
        }
    }
}
