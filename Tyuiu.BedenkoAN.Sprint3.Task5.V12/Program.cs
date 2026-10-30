using Tyuiu.BedenkoAN.Sprint3.Task5.V12.Lib;

namespace Tyuiu.BedenkoAN.Sprint3.Task5.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1; int end = 3;
            int start1 = 1; int end2 = 10;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет произведение ряда по формуле, при a=0,25*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);
            Console.WriteLine("Старт шага2: " + start1);
            Console.WriteLine("Конец шага2: " + end2);
            int x = 5;

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumSumSeries(x, start, start1, end, end2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
