using System;

namespace AssemblyOne
{
    public class Test1
    {
        public int Moto1 = 12;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(SportBike.MaxSpeedPublic);
            Motorcycle motorcycle = new Motorcycle();
            motorcycle.vinNamberProtectedInternal = "12asd";
            SportBike sportBike = new SportBike();
            sportBike.vinNamberProtectedInternal = "sa";
            Console.WriteLine(sportBike.vinNamberPublic);
            motorcycle.StartEnginePublic();
            sportBike.StartEnginePublic2();
        }
    }
    
}
