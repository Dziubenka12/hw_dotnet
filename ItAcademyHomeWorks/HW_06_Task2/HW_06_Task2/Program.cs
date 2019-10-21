using System;
using System.Linq;

namespace HW_06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Удалить из строки самое длинное слово.");
            //LongWord();
            //Lsword();
            //Kalk();
            Down();
            Console.ReadKey();
        }
        static void LongWord()
        {
            string str = "Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Удалить из строки самое длинное слово.";
            string[] longW = str.Split(' ');
            //int temp = 0;
            int max = longW[0].Length;

            for (int i = 0; i < longW.Length; i++)
                if (max < longW[i].Length)
                {
                    max = longW[i].Length;
                    //temp = i; 
                }
            for (int i = 0; i < longW.Length; i++)
                if (max == longW[i].Length)
                {
                    Console.WriteLine(longW[i]);
                }
        }

        static void Lsword()
        {
            string str = "Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Удалить из строки самое длинное слово.";
            string[] longW = str.Split(' ');
            int Llong = 0;
            int Lshort = 0;
            string s;
            int max = longW[0].Length;

            for (int i = 0; i < longW.Length; i++)
                if (max < longW[i].Length)
                {
                    max = longW[i].Length;
                    Llong = i;
                }
            for (int i = 0; i < longW.Length; i++)
                if (max > longW[i].Length)
                {
                    max = longW[i].Length;
                    Lshort = i;
                }
            s = longW[Llong];
            longW[Llong] = longW[Lshort];
            longW[Lshort] = s;
            for (int i = 0; i < longW.Length; i++)
            {
                Console.Write($"{longW[i]} ");
            }
        }

        static void Kalk()
        {
            string str = "Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Посчитать сколько в строке букв, пунктуационных знаков.";
            Console.WriteLine($"Количество пунктуационных знаков {str.Count(char.IsPunctuation)}");
            Console.WriteLine($"Количество букв {str.Count(char.IsLetter)}");
        }

        static void Down()
        {
            string str = "Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Удалить из строки самое длинное слово.";
            string[] array = str.Split(" ");
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
