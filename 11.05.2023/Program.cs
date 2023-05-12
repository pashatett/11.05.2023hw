using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11._05._2023
{
    internal class Program
    {
        static void task1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 100 && a >= 1 && a % 3 == 0) Console.WriteLine("Fizz");
            if (a <= 100 && a >= 1 && a % 5 == 0) Console.WriteLine("Buzz");
            if (a <= 100 && a >= 1 && a % 3 == 0 && a % 5 == 0) Console.WriteLine("Fizz Buzz");
            if (a > 100 || a < 1) Console.WriteLine(a);
        }
        static void task2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / 100 * b);
        }
        static void task3()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{3}",a, b, c, d);
        }
        static void Main(string[] args)
        {
        }
    }
}
