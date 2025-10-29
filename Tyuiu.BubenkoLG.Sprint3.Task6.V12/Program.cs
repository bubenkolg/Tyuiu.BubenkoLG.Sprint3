using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task6.V12.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Обработка целочисленной информации.                                ");
            Console.WriteLine("* Задание #6                                                               ");
            Console.WriteLine("* Вариант #12                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих        ");
            Console.WriteLine("* числовому отрезку [9, 18] сумму всех делителей.                          ");

            int startValue = 9;
            int stopValue = 18;

            int res = ds.GetSumTheDivisors(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("* Начальное значение: " + startValue);
            Console.WriteLine("* Конечное значение: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}