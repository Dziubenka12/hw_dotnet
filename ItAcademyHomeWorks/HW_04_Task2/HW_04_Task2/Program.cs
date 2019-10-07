using System;

namespace HW_04_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string go = Console.ReadLine();
            switch (go)
            {
                case "w":
                    Console.WriteLine("Переместить фигуру вверх");
                    break;
                case "s":
                    Console.WriteLine("Переместить фигуру вниз");
                    break;
                case "a":
                    Console.WriteLine("Переместить фигуру влево");
                    break;
                case "d":
                    Console.WriteLine("Переместить фигуру вправо");
                    break;
                default:
                    Console.WriteLine("Не перемещать фигуру");
                    break;
            }  
        }
    }
}
