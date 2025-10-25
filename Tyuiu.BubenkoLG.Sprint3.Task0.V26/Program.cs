using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task0.V26.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Оператор цикла for.                                                ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #26                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение    ");
            Console.WriteLine("* ряда по формуле                                                          ");

            Console.WriteLine("*          k                                                               ");
            Console.WriteLine("*     9   2                                                                ");
            Console.WriteLine("* p = П ------- * cos(1,8)                                                 ");
            Console.WriteLine("*        (k+1)                                                             ");
            Console.WriteLine("*    k=1                                                                   ");

            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
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