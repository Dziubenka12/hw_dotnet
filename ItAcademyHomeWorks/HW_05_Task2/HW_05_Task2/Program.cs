using System;

namespace HW_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.WriteLine("Введите элемент массива ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\nВведите последнее значение массива ");
            int last = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите позицию в массиве ");
            int pos = Convert.ToInt32(Console.ReadLine());
            pos = pos - 1;
            for (int i = pos; i < arr.Length - 1; i = i + 2)
            {
                int mas = arr[i];
                arr[i] = last;
                last = arr[i + 1];
                arr[i + 1] = mas;
            }
            arr[arr.Length - 1] = last;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
