using Tyuiu.BedenkoAN.Sprint3.Task4.V6.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -5, y = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Беденко А.Н. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                               *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Беденко Алексей Николаевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=x/(cos(x)-sin(x))");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("старт -5 : "  );
            Console.WriteLine("конец 5 "  );


            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.Calculate(x, y);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
