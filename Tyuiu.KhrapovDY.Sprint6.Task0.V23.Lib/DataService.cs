﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhrapovDY.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double res = Math.Log((((double)x + 1) / ((double)x + 2)), Math.E);
            return Math.Round(res, 3);
        }
    }
}
