using System.IO;

namespace SimplyLoggy
{
    public class FileLogger : ILogger
    {
        private const string FilePath = @"C:\Temp\SimplyLoggy.txt";

        public void Log(string text)
        {
            using (var streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}
