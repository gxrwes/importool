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
            ConfigHolderSingelton config = new ConfigHolderSingelton();
            Config cf = new Config();
            cf.Read();

            ApplicationConfiguration.Initialize();

            Application.Run(new ImportToolWindow());
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmm");
        }

        
    }
}