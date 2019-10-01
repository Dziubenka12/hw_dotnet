using System;

namespace HW_03_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static void Sum()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Какая сумма двух чисел?");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            if(sum==sum2)
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }

        }
    }
}
