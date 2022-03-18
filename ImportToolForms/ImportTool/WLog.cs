using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ImportTool
{
    internal class WLog
    {
        private static string _logComplete = "";
        private static string _logError = "";
        private static string _logWarning = "";
        private static string _logDebug = "";
        private static int _logCount = 0;
        private static ArrayList _logArray = new ArrayList();

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
            _logCount++;
            _logComplete += " ["+_logCount+"] "+value + "\n";
            _logArray.Add(new WLogOBJ(_logCount, value));
        }
        public static string getLog()
        {
            string temp = "";
            foreach(WLogOBJ obj in _logArray)
            {
                temp += " [" + obj.id + "] " + obj.getRecordDateAsString() +" "+ obj.value + "\n";
            }
            return temp;
        }
        public static void saveLog(string path)
        {
            string[] temp = new string[_logArray.Count];
            int i = 0;
            foreach(WLogOBJ obj in _logArray)
            {
                temp[i] = obj.writeObject();
                i++;
            }
            path += "IL_" + Program.GetTimestamp(DateTime.Now) + ".log";
            File.WriteAllLines(path,temp);  
        }
    }
    internal class WLogOBJ
    {
        public string value;
        public int id;
        private DateTime cDate;
        public string type = "";
        public WLogOBJ(int id, string value)
        {
            cDate = DateTime.Now;
            this.id = id;
            this.value = value;
            type = "default";
        }
        public DateTime getRecordDate() { return cDate; }
        public string getRecordDateAsString()
        {
            return cDate.ToString();
        }

        public string writeObject()
        {
            return "["+id+"]"+cDate.ToString()+" - "+value + "\tType: "+type;
        }
        
    }
}
