using Tyuiu.BedenkoAN.Sprint3.Task7.V2.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = -5; int end = 5;

            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x)/(x-0.7) - sin(x) * 12x + 2 (произвести табулирование)     *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на ноль.*");
            Console.WriteLine("* При делении на ноль вернуть значение 0. Значения округлить до двух знаков после запятой. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);



            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double[] res = ds.GetMassFunction(start, end);

            foreach (double value in res)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
