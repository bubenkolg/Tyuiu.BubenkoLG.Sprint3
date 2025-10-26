using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BubenkoLG.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string res = "";

            char[] coll_str = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (char el in value)
            {
                for (int i = 0; i < coll_str.Length; i++)
                {
                    if (el == coll_str[i])
                    {
                        res += el;
                    }
                }
            }
            return Convert.ToInt32(res);
            
        }
    }
}