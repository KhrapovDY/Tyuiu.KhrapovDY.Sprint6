using System.IO;
using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapovDY.Sprint6.Task5.V2.Lib
{
    public class DataService : ISprint6Task5V2
    {

        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader raeder = new StreamReader(path))
            {
                string line;
                while ((line = raeder.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            numsArray = numsArray.Where(val => val < 0).ToArray();

            return numsArray;
        }
    }
}