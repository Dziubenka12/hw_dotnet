using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SportBike.);
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(SportBike.MaxSpeedPublic);
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.vinNamberProtectedInternal = "12asd";
            SportBike sportBike = new SportBike();
            sportBike.vinNamberProtectedInternal = "sa";
            Console.WriteLine(sportBike.vinNamber);
        }
    }
}
