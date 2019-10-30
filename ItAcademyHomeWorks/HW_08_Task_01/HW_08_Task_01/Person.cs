using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08_Task_01
{
    public class Person
    {
        
        private string name;
        private string pasport;

        internal string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal string Pasport 
        {
            get 
            {
                return pasport;
            }
            private set 
            {
                pasport = value;
            }
        }

        public string ticket { get; set; }

        public Person() { name = "Неизвестно"; pasport = "Неизвестно"; }      // 1 конструктор

        public Person(string n) { name = n; pasport = "Неизвестно"; }         // 2 конструктор

        public Person(string n, string a) { name = n; pasport = a; }   // 3 конструктор
    }
}
