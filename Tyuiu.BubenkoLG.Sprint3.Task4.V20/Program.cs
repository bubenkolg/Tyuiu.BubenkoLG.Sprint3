using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BubenkoLG.Sprint3.Task4.V20.Lib;


namespace Tyuiu.BubenkoLG.Sprint3.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Бубенко Л. Г. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                                ");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах.                ");
            Console.WriteLine("* Задание #4                                                               ");
            Console.WriteLine("* Вариант #20                                                              ");
            Console.WriteLine("* Выполнила: Бубенко Людмила Георгиевна | СМАРТб-25-1                      ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение      ");
            Console.WriteLine("* функции y=x/(cos(x) - x)+2,5 При х = 0 пропустить значение.              ");
            Console.WriteLine("* Полученные значения перемножать.                                         ");

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);


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