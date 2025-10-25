using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BubenkoLG.Sprint3.Task0.V26.Lib
{
    public class DataService : ISprint3Task0V26
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                res = res * ((Math.Pow(2, k)/(k+1))*Math.Cos(1.8));
            }
            res = Math.Round(res,3);
            return res;
        }
    }
}