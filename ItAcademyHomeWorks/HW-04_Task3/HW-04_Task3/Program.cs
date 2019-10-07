using System;

namespace HW_04_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            float vklad = 1000;
            float proc;
            for (int i = 0; i < 12; i++)
            {
                proc = vklad * (float)0.02;
                vklad += vklad * (float)0.02;
                Console.WriteLine($"Прирост суммы {proc}");
                if (i > 1 && i < 12)
                {
                    Console.WriteLine($"Сумма вклада {vklad}");
                }
            }
        }
    }
}
