public class FileLoggerAdapter : Logger
{
    private readonly FileWriter _fileWriter;

    public FileLoggerAdapter(string filePath)
    {
        _fileWriter = new FileWriter(filePath);
    }

    public override void Log(string message)
    {
        _fileWriter.WriteLine($"[Log] {message}");
    }

    public override void Error(string message)
    {
        _fileWriter.WriteLine($"[Error] {message}");
    }

    public override void Warn(string message)
    {
        _fileWriter.WriteLine($"[Warning] {message}");
    }
}
