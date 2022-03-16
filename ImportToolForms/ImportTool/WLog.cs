using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportTool
{
    internal class WLog
    {
        private static string _logComplete = "";
        private static string _logError = "";
        private static string _logWarning = "";
        private static string _logDebug = "";
        private static int _logCount = 0;

        public static string getLogComplete() { return _logComplete; }
        public static string getLogError() { return _logError; }
        public static string getLogDebug() { return _logDebug; }
        public static string getLogWarning() { return _logWarning; }
        public static string dumpLog() 
        {
            string temp = getLogComplete();
            _logComplete = "";
            return temp;
        }
        public static void record(string value) 
        { 
            _logComplete += " ["+_logCount+"] "+value + "\n"; 
        }
    }
}
