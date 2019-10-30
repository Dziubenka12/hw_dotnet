using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_Task_01
{
    class Airport : Person
    {
        //Person person = new Person();
        public readonly string nameAirport = "Минск2";
        public void HelloAirport()
        {
            Console.WriteLine($"Добрый день! Вас приветсвует аэропорт {nameAirport}. Представьтесь пожалуйста!");
        }
        public void Hello()
        {
            if (Name == "Неизвестно") 
            {
                Console.WriteLine("Вы не представились!");
            }
            else Console.WriteLine($"Добро пожаловать {Name}. Укажите номер паспорта");
            
        }
    }
}
