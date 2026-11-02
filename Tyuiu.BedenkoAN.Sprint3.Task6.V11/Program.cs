using Tyuiu.BedenkoAN.Sprint3.Task6.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 10; int end = 19;
            
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [10, 19] количество всех делителей больше 10          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);
            
            

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.GetSumTheDivisors(start, end);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
