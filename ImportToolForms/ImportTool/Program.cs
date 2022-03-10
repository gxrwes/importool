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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ConfigHolderSingelton config = new ConfigHolderSingelton();

            ApplicationConfiguration.Initialize();
            Application.Run(new ImportToolWindow());
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmm");
        }

        
    }
}