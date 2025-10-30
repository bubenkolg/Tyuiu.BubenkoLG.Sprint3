using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task7.V5.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                 ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #5                                                               ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции             ");
            Console.WriteLine("*         2sin(x)                                                          ");
            Console.WriteLine("* F(x) = -------- + cos(x) - 7x * 2                                        ");
            Console.WriteLine("*        3x + 1,2                                                          ");
            Console.WriteLine("*(произвести табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1.   ");
            Console.WriteLine("*Произвести проверку деления на ноль.                                      ");
            Console.WriteLine("*При делении на ноль вернуть значение 0. Значения округлить до двух        ");
            Console.WriteLine("*знаков после запятой. Значения занести в массив.                          ");

            int startValue = -5;
            int stopValue = 5;
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Старт шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1, 5:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}