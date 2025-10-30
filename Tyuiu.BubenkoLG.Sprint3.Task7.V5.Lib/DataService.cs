using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BubenkoLG.Sprint3.Task7.V5.Lib
{
    public class DataService : ISprint3Task7V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] null_0 = new double[0];
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3 * x + 1.2) == 0)
                {
                    return null_0;
                }
                y = Math.Round(((2*Math.Sin(x)) / (3*x+1.2)) + Math.Cos(x) - 7*x*2, 2);
                result[count] = y;
                count++;
            }
            return result;
        }
    }
}