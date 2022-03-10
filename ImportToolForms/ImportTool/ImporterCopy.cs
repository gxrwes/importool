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

        }
        public ImporterCopy(string jobname)
        {
            // set this instances filecount
            this.jobname = jobname; 
            _fileCopyIndexCounter = 0;
            logArray = new ArrayList();
            logArray.Add(logInitialized);
            logArray.Add("Jobname|" + jobname);

        }

        public int getCopyCounter() { return _fileCopyIndexCounter; }  
        public int getGlobalCopyCounter() { return g_fileIndexCounter; }    
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
        public bool StartCopy()
        {
            try {
                ImportDirectory(ConfigHolderSingelton.Instance.getImportPath(), ConfigHolderSingelton.Instance.getDestinationPath());
                return true;
            }
            catch ( Exception e)
            {
                logArray.Add("Process Failed");
            }

            return false; 
        }
        private void ImportDirectory(string sourcePath, string targetPath)
        {
            string filter = ConfigHolderSingelton.Instance.getExtensionFilter();
            DirectoryInfo source = new DirectoryInfo(sourcePath);
            DirectoryInfo target = new DirectoryInfo(targetPath);

            _ImportDirectory(source, target);
        }
        private void _ImportDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            _fileCopyIndexCounter++;
            String timeStamp = Program.GetTimestamp(DateTime.Now);
            string filter = ConfigHolderSingelton.Instance.getExtensionFilter();

            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
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
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                logArray.Add("Original copy Name " +target.FullName+"\\" + fi.Name + " ");
                string name = prefixBuilder() + "" + fi.Name;
                fi.CopyTo(Path.Combine(target.ToString(), name), true);
                logArray.Add("Copied And Renamed to " + name);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                _ImportDirectory(diSourceSubDir, nextTargetSubDir);
            }
        }

        public string prefixBuilder()
        {
            return "[" + _fileCopyIndexCounter + "] " + jobname + "_" + Program.GetTimestamp(DateTime.Now) + "_OG#";
        }
       

    }
}
