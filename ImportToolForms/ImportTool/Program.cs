using System.Configuration;
using System.Collections.Specialized;

namespace ImportTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            // TODO create config
            ConfigHolderSingelton config = new ConfigHolderSingelton();

            ApplicationConfiguration.Initialize();

            //Load Config
            string text = System.IO.File.ReadAllText(ConfigHolderSingelton.Instance.defaultPathFilename);
            WLog.record("LOADING DEFAULT PATH :: -" + text);
            ConfigHolderSingelton.Instance.setNewDefaultpath(text);

            Application.Run(new ImportToolWindow());
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmm");
        }

        
    }
}