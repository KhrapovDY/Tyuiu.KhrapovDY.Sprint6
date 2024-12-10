using Tyuiu.KhrapovDY.Sprint6.Task6.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\Desktop\DataService6\InPutDataFileTask6V30.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}