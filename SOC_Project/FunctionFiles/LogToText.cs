public class LogToText
{
    public static void ExceptionLog(Exception exception)
    {
        try
        {
            string yy = DateTime.Now.ToString("yyyy");
            string dd = DateTime.Now.ToString("dd");
            string mm = DateTime.Now.ToString("MM");
            string errorLogPath = Path.Combine("d:/SOCApp/error/exception", yy, mm, dd);

            if (!Directory.Exists(errorLogPath))
            {
                Directory.CreateDirectory(errorLogPath);
            }

            string logPath = Path.Combine(errorLogPath, "exception.log");

            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.WriteLine($"DateTime: {DateTime.Now}");
                sw.WriteLine($"Error: {exception.GetType().Name}");
                sw.WriteLine($"Message: {exception.Message}");
                sw.WriteLine($"StackTrace: {exception.StackTrace}");
                sw.WriteLine();
            }
        }
        catch (Exception ex)
        {            
            Console.WriteLine($"Logging failed: {ex.Message}");
        }
    }
}
