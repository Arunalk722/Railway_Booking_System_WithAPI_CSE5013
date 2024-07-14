﻿namespace SOC_Project.FunctionFiles
{
    public class LogToText
    {
        public static void exceptionLog(Exception exception)
        {
            try
            {
                String yy = DateTime.Now.ToString("yyyy");
                String dd = DateTime.Now.ToString("dd");
                String mm = DateTime.Now.ToString("MM");
                String _errorLogPath = "d:/SOCApp/error/exception/" + yy + "/" + mm + "/" + dd;

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
