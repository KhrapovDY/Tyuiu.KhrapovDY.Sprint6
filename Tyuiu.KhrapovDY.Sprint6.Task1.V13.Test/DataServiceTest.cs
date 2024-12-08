using Tyuiu.KhrapovDY.Sprint6.Task1.V13.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startStep = -5;
            int stopStep = 5;

            int len = stopStep - startStep + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 23.92;
            valueWaitArray[1] = 18.88;
            valueWaitArray[2] = 13.10;
            valueWaitArray[3] = 7.24;
            valueWaitArray[4] = 1.80;
            valueWaitArray[5] = -8;
            valueWaitArray[6] = -5.70;
            valueWaitArray[7] = -11.26;
            valueWaitArray[8] = -17.12;
            valueWaitArray[9] = -22.88;
            valueWaitArray[10] = -27.92;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}