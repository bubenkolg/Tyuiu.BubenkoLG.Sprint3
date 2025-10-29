using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task5.V2.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Вложенные циклы.                                                   ");
            Console.WriteLine("* Задание #5                                                               ");
            Console.WriteLine("* Вариант #2                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("*     cos(k) + x                                                           ");
            Console.WriteLine("* y = ----------  при x = 5                                                ");
            Console.WriteLine("*          x                                                               ");

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Значение X = " + x);
            Console.WriteLine("* Начальное значение 1: " + startValue1);
            Console.WriteLine("* Начальное значение 2: " + startValue2);
            Console.WriteLine("* Конечное значение 1: " + stopValue1);
            Console.WriteLine("* Конечное значение 2: " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}