using System;

namespace HW_05_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int box;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                box = arr[i];
                arr[i] = arr[9 - i];
                arr[9 - i] = box;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
