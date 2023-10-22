﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikolaevaAN.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                sumSeries += (Math.Pow(value, startValue) + 0.5) * Math.Cos(startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries, 3);
        }
    }
}
