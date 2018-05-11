using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimplyLoggy
{
    public interface IFileOperations
    {
        string FilePath { get; }
        void Read();
        void Write(string text);
    }
    public class FileOperations :IFileOperations
    {
        public string FilePath { get; }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
