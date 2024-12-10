﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapovDY.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((x + 2) != 0)
                {
                    y = (Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x);
                    y = Math.Round(y, 2);
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = 0;
                    valueArray[count] = y;
                    count++;
                }
            }

            return valueArray;
        }
    }
}