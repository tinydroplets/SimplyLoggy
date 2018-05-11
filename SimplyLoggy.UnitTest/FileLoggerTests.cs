using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplyLoggy.UnitTest
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            var fileOperations = new FileOperations();
            fileOperations.FilePath = @"C:\temp\UnitTests\TestFile.txt";
        }

        [TestMethod]
        public void TestSpecifyFilePath()
        {
            var fileLogger = new FileLogger();
            fileLogger = fileLogger.LogFilePath(@"c:\temp\filePath.txt");
            Assert.AreEqual(@"c:\temp\filePath.txt", fileLogger.FilePath);
        }

        [TestMethod]
        public void TestSimpleText()
        {
            //how would you write a test class for this logger?
            //would you read the file and then check that the message was written correctly?
            var fileLogger = new FileLogger();
            fileLogger.Log("simple message with text");

            var fileOperations = new FileOperations();

            var textFromFile = fileOperations.Read();

            Assert.AreEqual("Hello, how are you?", textFromFile);
        }
    }
}
