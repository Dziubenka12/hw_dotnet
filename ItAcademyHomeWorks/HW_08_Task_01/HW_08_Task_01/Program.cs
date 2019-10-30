using System;

namespace HW_08_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Airport airport = new Airport();
            airport.HelloAirport();
            person.Name = Console.ReadLine();
            //Console.WriteLine($"добро пожаловать {person.Name}. Укажите номер паспорта");
            airport.Hello();
            //person.Name = 
        }
    }
}
