using System.IO;
using System.IO.Abstractions;

namespace SimplyLoggy
{
    public class FileLogger 
    {
        //public string FilePath = @"C:\Temp\SimplyLoggy.txt";
        public string FilePath;
        private FileWrapper _file; 


        public FileLogger(FileWrapper file)
        {
            _file = file;
        }

        public FileLogger Log(string text)
        {
             _file.WriteAllText(FilePath, text);
            return this;
        }

        public FileLogger LogFilePath(string filePath)
        {
            FilePath = filePath;
            return this;
        }
    }
}
