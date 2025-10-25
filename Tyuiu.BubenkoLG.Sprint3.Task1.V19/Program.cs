using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task1.V19.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task1.V19
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Оператор цикла while.                                               ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #19                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение  ");
            Console.WriteLine("* ряда по формуле, при х=1                                                 ");

            Console.WriteLine("*     9            k                                                       ");
            Console.WriteLine("* p = П  cos(x) + ---                                                      ");
            Console.WriteLine("*    k=1           4                                                       ");

            int startValue = 1;
            int stopValue = 9;
            int x = 1;
            double res = ds.GetMultiplySeries(x,startValue, stopValue);


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