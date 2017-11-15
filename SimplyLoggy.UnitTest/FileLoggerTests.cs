using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplyLoggy.UnitTest
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void TestSimpleText()
        {
            var fileLogger = new FileLogger();
            fileLogger.Log("simple message with text");
        }
    }
}
