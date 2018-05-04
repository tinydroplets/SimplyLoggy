using System.IO;

namespace SimplyLoggy
{
    public class FileLogger : ILogger
    {
        //public string FilePath = @"C:\Temp\SimplyLoggy.txt";
        public string FilePath;

        public void Log(string text)
        {
            using (var streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(text);
            }
        }

        public FileLogger LogFilePath(string filePath)
        {
            FilePath = filePath;
            return this;
        }
    }
}
