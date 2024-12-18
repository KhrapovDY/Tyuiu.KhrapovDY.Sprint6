using Tyuiu.KhrapovDY.Sprint6.Task4.V11.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task4.V11.Test
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

            valueWaitArray[0] = 20.36;
            valueWaitArray[1] = 15.42;
            valueWaitArray[2] = 10.99;
            valueWaitArray[3] = 7.43;
            valueWaitArray[4] = 4.33;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = -8.87;
            valueWaitArray[8] = -13.03;
            valueWaitArray[9] = -16.53;
            valueWaitArray[10] = -19.60;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startStep, stopStep);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}