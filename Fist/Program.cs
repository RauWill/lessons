using System;

namespace Fist
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b, c, d;

            Console.WriteLine("Введите первое число");

            str = Console.ReadLine();

            a = int.Parse(str);

            Console.WriteLine("Введите второе число");

            str = Console.ReadLine();

            b = int.Parse(str);

            c = a + b;

            d = a * b;

            Console.WriteLine("Сумма ваших чисел: " + c);

            Console.WriteLine();

            Console.WriteLine("Произведение ваших чисел: " + d);  
              



            



        }
    }
}
