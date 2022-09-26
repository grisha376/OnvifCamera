using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnvifCamera.Logging
{
    class EventLogging
    {
        public static void LogEvents(string text)
        {
            string logFilePath = $@"{"OnvifCamera/Logs/"}";
            try
            {
                StreamWriter sw = new StreamWriter($@"{logFilePath}{DateTime.Now:dd-MMM-yyyy}.log", true);
                sw.WriteLine(text);
                sw.Close();
            }
            catch { }
        }
    }
}
