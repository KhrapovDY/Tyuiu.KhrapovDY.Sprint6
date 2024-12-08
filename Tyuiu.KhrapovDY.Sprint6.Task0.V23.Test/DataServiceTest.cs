using Tyuiu.KhrapovDY.Sprint6.Task0.V23.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = -0.405;
            Assert.AreEqual(wait, res);
        }
    }
}