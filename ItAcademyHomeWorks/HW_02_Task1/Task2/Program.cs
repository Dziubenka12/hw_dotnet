using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            Console.WriteLine(num1.GetType());
            Int32 num2 = 12;
            Console.WriteLine(num2.GetType());
            byte num3 = 13;
            Console.WriteLine(num3.GetType());
            Byte num4 = 13;
            Console.WriteLine(num4.GetType());
            char num5 = 'A';
            Console.WriteLine(num5.GetType());
            Char num6 = 'A';
            Console.WriteLine(num6.GetType());
            //etc;
            Object obj = 12;
            Console.WriteLine(obj.GetType());
            object obj2 = 12;
            Console.WriteLine(obj2.GetType());
            string hi = "Hello";
            Console.WriteLine(hi.GetType());
            String hi2 = "Hello!";
            Console.WriteLine(hi2.GetType());
            Console.ReadKey();
        }
    }
}
