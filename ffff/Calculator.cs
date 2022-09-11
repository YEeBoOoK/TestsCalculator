using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffff
{
    public class Calculator
    {
        public static decimal Calc(decimal a, char b, decimal c)
        {
            if (b == '+')
            {
                return a + c;
            }
            else if (b == '-')
            {
                return a - c;
            }
            else if (b == '*')
            {
                return a * c;
            }
            else if (b == '/')
            {
                return a / c;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            var num1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите знак операции: ");
            char oper = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var num2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("\nОтвет: ");
            Console.WriteLine(Calc(num1, oper, num2));
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}