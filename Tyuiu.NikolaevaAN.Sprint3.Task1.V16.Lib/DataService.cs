using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikolaevaAN.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                sumSeries += (Math.Pow(value, 2) * Math.Sin(i)) + 1;
                i++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
