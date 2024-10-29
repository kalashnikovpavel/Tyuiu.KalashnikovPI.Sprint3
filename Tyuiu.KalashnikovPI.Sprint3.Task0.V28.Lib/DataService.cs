﻿
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalashnikovPI.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double s = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                s *= ((Math.Pow(value, 3) * i) + 2);
            }
            return s;
        }
    }
}
