using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NikolaevaAN.Sprint3.Task0.V15.Lib
{
    public class DataService : ISprint3Task0V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (double i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(value, i) + (2 / (i + 1))) * Math.Sin(value);
            }
            return Math.Round(sumSeries,3);
        }
    }
}
