using System;

namespace HW_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Result();
        }

        static void Result()
        {
            Console.WriteLine("Введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите + или -");
            string calc = Console.ReadLine();
            int sum;

            // через if else
            //if (calc == '+')
            //{
            //    sum = num1 + num2;
            //}
            //else
            //{
            //    sum = num1 - num2;
            //}

            // (почему через switch не видит объявление переменной sum в if?)
            //switch (calc)
            //{
            //    case "+":
            //        sum = num1 + num2;
            //        break;
            //    case "-":
            //        sum = num1 - num2;
            //        break;
            //}

            // Тернарная операция
            sum = calc == "+" ? (num1 + num2) : (num1 - num2);

            Console.WriteLine("Результат вычисления?");
            int sum2 = Convert.ToInt32(Console.ReadLine());
            if (sum == sum2)
            {
                Console.WriteLine("Правильно");
            }
            else if (sum > sum2)
            {
                Console.WriteLine("Неправильно");
                Console.WriteLine("Должно быть больше");
            }
            else
            {
                Console.WriteLine("Неправильно");
                Console.WriteLine("Должно быть меньше");
            }
        }
    }
}
