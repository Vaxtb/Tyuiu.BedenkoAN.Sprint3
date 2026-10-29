using Tyuiu.BedenkoAN.Sprint3.Task3.V11.Lib;
namespace Tyuiu.BedenkoAN.Sprint3.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "sqwreq vqwqq q";
            char b = 'q';
            char c = '7';
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
            Console.WriteLine("* Используя цикл foreach заменить буквы q на цифру 7 в строке: sqwreq vqwqq q");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(s);
            Console.WriteLine("что заменить : " + b);
            Console.WriteLine("на что заменить: " + c);
            

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.ReplaceCharOnNum(s, b, c);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
