using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BubenkoLG.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                res *= Math.Cos(value) + (k / 4.0);
                k++;
            }
            return Math.Round(res,3);
        }
    }
}