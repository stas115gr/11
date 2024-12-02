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
            int m = Vvod("Кол-во метров ");
            int c = Vvod("Кол-во сантиметров ");
            Add("Кол-во сантиметров=", Centimeters(m, c));
            Console.ReadKey();
        }
        public static int Centimeters(int m, int c)
        {
            return m * 100 + c;
        }
        public static int Vvod(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Add(string message, int m)
        {
            Console.WriteLine($"{message} {m}");
        }
    }
}
