using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace ImportTool
{
    internal class ImporterCopy
    {
        //private ConfigHolderSingelton _config = new ConfigHolderSingelton();
        protected static int g_fileIndexCounter = 0;
        protected int _fileCopyIndexCounter;
        protected static ArrayList g_Log = new ArrayList();
        ArrayList logArray = new ArrayList();
        protected static string logInitialized = "----------\n";
        string jobname;
        public ImporterCopy()
        {
            // set this instances filecount
            jobname = "UNDEFINED";
            _fileCopyIndexCounter = 0;
            logArray = new ArrayList();
            logArray.Add(logInitialized);
            logArray.Add("Jobname|" + jobname);
            WLog.record("JOBNAME " + jobname);

        }
        public ImporterCopy(string jobname)
        {
            // set this instances filecount
            this.jobname = jobname; 
            _fileCopyIndexCounter = 0;
            logArray = new ArrayList();
            logArray.Add(logInitialized);
            logArray.Add("Jobname|" + jobname);
            WLog.record("Jobname|" + jobname);

        }

        public int getCopyCounter() { return _fileCopyIndexCounter; }  
        public static int getGlobalCopyCounter() { return g_fileIndexCounter; }    
        public static string getGlobalGLog() 
        {
            string temp = "";
            foreach (var log in g_Log)
            {
                temp += "\n" + log.ToString();
            }
            g_Log.Clear();
            return temp;
        }
        public ArrayList getLogArray() { return logArray; } 
        public void Update()
        {

            //g_fileIndexCounter++;
            //logArray.Add("[ "+g_fileIndexCounter+" | " + _fileCopyIndexCounter+" ] ");
        }
        public string getLog() 
        {
            string temp = "";
            foreach(var log in logArray)
            {
                temp += log.ToString();
            } 
            return temp;
        }
        public string getAndDumpLog() 
        {
            string temp = getLog();
            logArray = new ArrayList();
            return temp;
        }
        public bool StartCopy(string tempimportpath, string tempdestpath)
        {
            try {
                //string tempimportpath = ConfigHolderSingelton.Instance.getImportPath();
                //string tempdestpath = ConfigHolderSingelton.Instance.getDestinationPath();
                ImportDirectory(tempimportpath, tempdestpath);
                ImportToolWindow.updating = false;
                return true;
            }
            catch ( Exception e)
            {
                logArray.Add("Process Failed");
                ImportToolWindow.updating = false;
            }

            return false; 
        }
        private void ImportDirectory(string sourcePath, string targetPath)
        {
            ConfigHolderSingelton.Instance.addToJobWatcher();

            string filter = ConfigHolderSingelton.Instance.getExtensionFilter();
            DirectoryInfo source = new DirectoryInfo(sourcePath);
            DirectoryInfo target = new DirectoryInfo(targetPath);
            if (ConfigHolderSingelton.Instance.IsDefault())
            {
                target = new DirectoryInfo(ConfigHolderSingelton.Instance.getDestinationPath());
            }
            Thread divCopyThread = new Thread(new ThreadStart( () => _ImportDirectory(source, target) ));
            divCopyThread.Start();
            // _ImportDirectory(source, target);
            WLog.record("\tCopyJob-Complete");
            // Job finished 
            divCopyThread.Join();
            ConfigHolderSingelton.Instance.fireJob();
        }
        private void __ThreadImportDirectory()
        {

        }
        private void _ImportDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            //sync counter
            _fileCopyIndexCounter++;
            g_Log = logArray;

            // Add Job to Jobwatcher
            ConfigHolderSingelton.Instance.addToJobWatcher();

            String timeStamp = Program.GetTimestamp(DateTime.Now);
            string filter = ConfigHolderSingelton.Instance.getExtensionFilter();

            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                ConfigHolderSingelton.Instance.fireJob();
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                WLog.record("Copying:" + target.FullName + " --> " + fi.Name);
                string name = prefixBuilder() + "" + fi.Name;
                fi.CopyTo(Path.Combine(target.ToString(), name), true);
                WLog.record("Copied And Renamed to " + name);

                ConfigHolderSingelton.Instance.addFileProgress(1);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                WLog.record("SubdirectoryCopy: "+diSourceSubDir.FullName);
                // Do not create sub direcory
                // Flatten folderstructure
                // We want just the files
                // DirectoryInfo nextTargetSubDir =  target.CreateSubdirectory(diSourceSubDir.Name);
                DirectoryInfo nextTargetSubDir = target;
                _ImportDirectory(diSourceSubDir, nextTargetSubDir);
            }
            // Delete Job to Jobwatcher
            ConfigHolderSingelton.Instance.fireJob();

        }
        public string prefixBuilder()
        {
            return "[" + _fileCopyIndexCounter + "] " + ConfigHolderSingelton.Instance.getJobName() + "_" + Program.GetTimestamp(DateTime.Now) + "_OG#";
        }
        public static void testOrBuildDirectory(string path)
        {
            if (Directory.Exists(path))
            {
                WLog.record("Directory Already Exists");
                return;
            }
            DirectoryInfo d = Directory.CreateDirectory(path);
            if (d.Exists)
                WLog.record("Directory Creaded Successfully");
            else
                WLog.record("Directory coulnt be created");
        }
        public static int countFiles(string path)
        {
            FileInfo[] files = new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories);
            WLog.record("Found " + files.Length.ToString() + " Files");
            return files.Length;
        }

    }
}
