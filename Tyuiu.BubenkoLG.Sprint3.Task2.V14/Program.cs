using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task2.V14.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Оператор цикла do-while.                                           ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #14                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет          ");
            Console.WriteLine("* произведение ряда по формуле, при х=5                                    ");

            Console.WriteLine("*     6    x                                                               ");
            Console.WriteLine("* p = П  (---)                                                             ");
            Console.WriteLine("*    k=1   k                                                               ");

            int startValue = 1;
            int stopValue = 6;
            int x = 5;
            double res = ds.GetMultiplySeries(x, startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Значение Х = " + x);
            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}