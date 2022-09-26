using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ImportTool
{
    internal class Config
    {
        private string configPath = "config.csv";
        private string pattern = @"(.*),(.*)";

        private string def_videoPath = "";
        public void Read()
        {
            WLog.record("-------------------");
            WLog.record("READING CONFIG ");
            WLog.record("-------------------");

            // Create Regex for Config
            Regex defaultVideo = new Regex(@"DefaultPath,(.*)");
            Regex defaultRename = new Regex(@"DefaultPath,(.*)");
            string[] lines = System.IO.File.ReadAllLines(configPath);
            foreach (string line in lines)
            {
                // Get default video Path
                MatchCollection def_Path_Match = defaultVideo.Matches(line);
                def_videoPath = def_Path_Match[0].Value;
                WLog.record("\tDefault Path: " + def_videoPath);

            }

            WriteToProgram();
        }

        public void WriteToProgram()
        {
            if(def_videoPath.Length > 1)
            {
                ConfigHolderSingelton.Instance.setDestPath(def_videoPath);
                WLog.record("Set new Default Path: " + def_videoPath);
            }
            
        }

    }
}
