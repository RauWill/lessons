using System;

namespace Fist
{
    class Program
    {
        // Программа для вывода суммы и произведения двух чисел
        static void Main(string[] args)
        {
            string stringOperand;
            int firstOperand, secondOperand, summ, composition;

            Console.WriteLine("Введите первое число");

            stringOperand = Console.ReadLine();
            firstOperand = int.Parse(stringOperand);

            Console.WriteLine("Введите второе число");

            stringOperand = Console.ReadLine();
            secondOperand = int.Parse(stringOperand);

            summ = firstOperand + secondOperand;
            composition = firstOperand * secondOperand;

            Console.WriteLine("Сумма ваших чисел: " + summ);
            Console.WriteLine();
            Console.WriteLine("Произведение ваших чисел: " + composition + ". Удачи)");  
            
            // changes from github
            

        }
    }
}
