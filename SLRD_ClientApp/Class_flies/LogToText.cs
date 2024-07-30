using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
    public class LogToText
    {
        public static void ExceptionLog(Exception exception)
        {
            try
            {
                String yy = DateTime.Now.ToString("yyyy");
                String dd = DateTime.Now.ToString("dd");
                String mm = DateTime.Now.ToString("MM");
                String _errorLogPath = "d:/SOCClient/error/exception/" + yy + "/" + mm + "/" + dd;

                String message = exception.GetType().Name.ToString();
                String logLine = exception.StackTrace.Substring(exception.StackTrace.Length - 7, 7);
                String fullLog = exception.ToString();
                String errorType = exception.GetType().ToString();

                if (!Directory.Exists(_errorLogPath))
                {
                    Directory.CreateDirectory(_errorLogPath);
                }

                String _logPath = Path.Combine(_errorLogPath, "exceptopn.log");

                using (StreamWriter sw = new StreamWriter(_logPath, true))
                {
                    sw.WriteLine("date time\t\t:" + DateTime.Now.ToString());
                    sw.WriteLine("error\t\t:" + errorType);
                    sw.WriteLine("message\t\t:" + message);
                    sw.WriteLine("log line\t\t:" + logLine);
                    sw.WriteLine("full log\t\t:" + fullLog);
                    sw.WriteLine(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
