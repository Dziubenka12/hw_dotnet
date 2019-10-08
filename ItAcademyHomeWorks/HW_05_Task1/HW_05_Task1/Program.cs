using System;

namespace HW_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randArr = new int[5];
            int[] vvodArr = new int[5];
            int[] sumArr = new int[5];
            Random rand = new Random();
            
            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = rand.Next(5);
                Console.Write("Число ");
                vvodArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Рандом {randArr[i]}");
            }
            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = randArr[i] + vvodArr[i];
                Console.WriteLine($"Сумма {sumArr[i]}");
            }
        }
    }
}
