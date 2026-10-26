using Tyuiu.BedenkoAN.Sprint3.Task1.V9.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1; int end = 4;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда по формуле, при х=5*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);
            int x = 5;

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetMultiplySeries(x, start, end);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
