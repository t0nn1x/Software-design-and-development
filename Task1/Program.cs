using System;

class Program
{
    static void Main(string[] args)
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("This is a log message.");
        consoleLogger.Error("This is an error message.");
        consoleLogger.Warn("This is a warning message.");

        string logFilePath = "log.txt";
        FileLoggerAdapter fileLogger = new FileLoggerAdapter(logFilePath);
        fileLogger.Log("This is a log message.");
        fileLogger.Error("This is an error message.");
        fileLogger.Warn("This is a warning message.");

        Console.WriteLine($"File logger has written logs to {logFilePath}");
    }
}
