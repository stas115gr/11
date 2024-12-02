using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Vvod("a=");
            int number2 = Vvod("b=");
            int number3 = Vvod("c=");
            Add($"Наименьшее число = ", Func(Func(number1, number2), number3));
            Console.ReadLine();
        }
        public static int Vvod(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        public static int Func(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public static void Add(string message, int min)
        {
            Console.WriteLine($"{message} {min}");
        }
    }
}
