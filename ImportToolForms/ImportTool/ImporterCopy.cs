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
        public static void Update()
        {
            g_fileIndexCounter ++;
            logArray.Add("["+g_fileIndexCounter+"] ");
        }
        public bool StartCopy()
        {
            try {
                CopyDirectory(ConfigHolderSingelton.Instance.getImportPath(), ConfigHolderSingelton.Instance.getDestinationPath());
                return true;
            }
            catch ( Exception e)
            {
                Console.WriteLine(" copy failed");
            }

            return false; 
        }
        private static void CopyDirectory(string sourcePath, string targetPath)
        {
            string filter = ConfigHolderSingelton.Instance.getExtensionFilter();
            // Get information about the source directory
            var dir_src = new DirectoryInfo(sourcePath);
            var dir_dst = new DirectoryInfo(targetPath);
            // Check if the source directory exists
            if (!dir_src.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir_src.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir_src.GetDirectories();

            // Create the destination directory
            if (!dir_dst.Exists) 
                Directory.CreateDirectory(targetPath);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir_src.GetFiles())
            {
                string targetFilePath = Path.Combine(targetPath, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (ConfigHolderSingelton.Instance.searchRecursive())
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(targetPath, subDir.Name);
                    CopyDirectory(subDir.FullName, newDestinationDir);
                }
            }
        }

    }
}
