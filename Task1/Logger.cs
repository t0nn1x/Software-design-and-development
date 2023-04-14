using System;

public class Logger
{
    public virtual void Log(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[Log] {message}");
        Console.ResetColor();
    }

    public virtual void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[Error] {message}");
        Console.ResetColor();
    }

    public virtual void Warn(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"[Warning] {message}");
        Console.ResetColor();
    }
}
