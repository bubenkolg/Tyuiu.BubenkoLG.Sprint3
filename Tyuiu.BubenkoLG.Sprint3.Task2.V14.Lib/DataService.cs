using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BubenkoLG.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int k = startValue;
            double res = 1;
            double x = Convert.ToDouble(value);
            do
            {
                res *= (x / k)*(x / k)* (x / k);
                k++;
            } while (k <= stopValue);
            return Math.Round(res ,3);
        }
    }
}