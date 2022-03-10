using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImportTool
{
    internal class ImporterCopy
    {
        //private ConfigHolderSingelton _config = new ConfigHolderSingelton();
        protected static int _touchCounter = 0;
        private Form _form = null;
        public ImporterCopy(Form form)
        {
            this._form = form;
        }
        
        public int getCopyCounter() { return _touchCounter; }   
        public Form getForm() { return _form; }
        public void setForm(Form form) { _form = form; }
        public static bool Update()
        { 
            //this._form.Update();
            return true;
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
                bool b = Update();

                _touchCounter++;
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
