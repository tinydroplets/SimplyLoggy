using System.IO;

namespace SimplyLoggy
{
    public class FileLogger : Logger
    {
        private const string FilePath = @"C:\Temp\SimplyLoggy.txt";

        public new void Log(string text)
        {
            using (var streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(text);
            }
        }
    }
}
