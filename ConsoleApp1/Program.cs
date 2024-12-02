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
            int r = Vvod("Кол-во рублей ");
            int k = Vvod("Кол-во копеек ");
            Add("Кол-во копеек=", Kop(r, k));
            Console.ReadKey();
        }
        public static int Kop(int r, int k)
        {
            return r * 100 + k;
        }
        public static int Vvod(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Add(string message, int r)
        {
            Console.WriteLine($"{message} {r}");
        }
    }
}
