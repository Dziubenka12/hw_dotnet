using System;

namespace HW_06_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение!");
            string stih = Console.ReadLine();
            char[] ar = stih.ToCharArray();
            for (int i = 0; i < stih.Length; i++)
            {
                if (stih[i] == (char)1054)
                {
                    ar[i] = (char)1040;
                }
                else if (stih[i] == (char)1086)
                {
                    ar[i] = (char)1072;
                }
            }
            stih = String.Concat<char>(ar);
            string[] array = stih.Split(";");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
