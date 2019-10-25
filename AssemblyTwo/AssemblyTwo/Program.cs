using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.vinNamberProtectedInternal = "12asd";
            SportBike sportBike = new SportBike();
            sportBike.vinNamberProtectedInternal = "sa";
            Console.WriteLine(sportBike.vinNamber);
        }
    }
}
