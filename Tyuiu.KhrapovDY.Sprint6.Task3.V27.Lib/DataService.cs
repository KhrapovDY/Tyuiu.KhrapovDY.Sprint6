using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapovDY.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] x = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                x[i] = matrix[i, 3];
            }

            Array.Sort(x);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 3] = x[i];
            }
            return matrix;
        }
    }
}
