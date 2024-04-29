namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType+": " + message);
            }
        }
        public void LogError(string message)
        {
            Log(message, "Error");
           
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }
    }
}