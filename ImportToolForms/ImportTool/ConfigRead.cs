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
        private string configPath = "import.cfg";
        private string pattern = @"(.*),(.*)";

        private string def_videoPath = "";
        private string def_PMPath = "";
        public void Read()
        {
            WLog.record("-------------------");
            WLog.record("LOADING CONFIG ");
            WLog.record("-------------------");

            // Create Regex for Config
            Regex defaultVideo = new Regex(@"DefaultPath=(.*);");
            Regex defaultRename = new Regex(@"DefaultRename=(.*);");
            Regex defaultPM= new Regex(@"DefaultPMTemplate=(.*);");
            if (!System.IO.File.Exists(configPath))
            {
                using (FileStream fs = File.Create(configPath))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("DefaultPath=;\nDefaultPMTemplate=;");
                    fs.Write(title, 0, title.Length);
                }
            }
            string[] lines = System.IO.File.ReadAllLines(configPath);
            foreach (string line in lines)
            {
                // Get default video Path
                MatchCollection def_Path_Match = defaultVideo.Matches(line);
                foreach( Match m in def_Path_Match )
                {
                    GroupCollection g = m.Groups;
                    def_videoPath = g[1].Value;
                    WLog.record("\tLOADED Default Path: " + def_videoPath);
                    if (def_videoPath.Length > 1)
                    {
                        ConfigHolderSingelton.Instance.setDestPath(def_videoPath);
                        ConfigHolderSingelton.Instance.setNewDefaultpath(def_videoPath);
                    }
                }
                

                // Get default PMTemplate
                MatchCollection def_PM_Match = defaultPM.Matches(line);
                foreach (Match m in def_PM_Match)
                {
                    GroupCollection g = m.Groups;
                    def_PMPath = g[1].Value;
                    WLog.record("\tLOADED Default Premiere Template Path:" + def_PMPath); 
                    if (def_PMPath.Length > 1)
                    {
                        ConfigHolderSingelton.Instance.setPMTemplatePath(def_PMPath);
                    }
                }
            }

        }
        public void saveConfig()
        {
            string newDefaultFile = "DefaultPath=" + ConfigHolderSingelton.Instance.getDefaultpathString() +
                ";\nDefaultPMTemplate=" + ConfigHolderSingelton.Instance.getPMTemplatePath() + ";";
            writeTofile(newDefaultFile);
        }
        private static async Task writeTofile(string input)
        {
            // Empty File
            System.IO.File.WriteAllText(ConfigHolderSingelton.Instance.defaultPathFilename, string.Empty);

            await File.WriteAllTextAsync(ConfigHolderSingelton.Instance.defaultPathFilename, input);
        }


    }
}
