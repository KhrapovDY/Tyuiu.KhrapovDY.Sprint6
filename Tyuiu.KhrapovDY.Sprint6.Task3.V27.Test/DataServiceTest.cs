using Tyuiu.KhrapovDY.Sprint6.Task3.V27.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 9, 13, -14, 23, 1 }, { 15, -17, 21, 25, 23 }, { -4, 29, -20, -10, 14 }, { 27, 33, 12 , 33, -12 }, { 18, -9, -5, 6, 3 } };

            var result = ds.Calculate(matrix);
            int[,] wait = { { 9, 13, -14, -10, 1 }, { 15, -17, 21, 6, 23 }, { -4, 29, -20, 23, 14 }, { 27, 33, 12, 25, -12 }, { 18, -9, -5, 33, 3 } };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}