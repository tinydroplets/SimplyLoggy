using System.IO;
using System.IO.Abstractions;

namespace SimplyLoggy
{
    public class FileLogger 
    {
        //public string FilePath = @"C:\Temp\SimplyLoggy.txt";
        public string FilePath;
        //private FileWrapper _file; 
        private IFileOperations _fileOperations;


        public FileLogger(IFileOperations fileOperations)
        {
            _fileOperations = fileOperations;
        }

        public FileLogger Log(string text)
        {
             _fileOperations.Write(text);
            return this;
        }

        public FileLogger LogFilePath(string filePath)
        {
            FilePath = filePath;
            return this;
        }
    }
}
