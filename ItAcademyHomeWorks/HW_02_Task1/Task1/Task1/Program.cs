using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)a. 3 примера явного преобразования типов 
            long nam1 = 21;
            int nam2 = (int)nam1;
            short nam3 = (short)nam1;
            sbyte num4 = (sbyte)nam1;
            //1)b. 3 примера неявного преобразования типов
            sbyte num5= 22;
            short num6 = num5;
            int num7 = num5;
            long num8 = num5;
            //1)c. 1 пример операции упаковки
            int num9 = 10;
            object obj = num9;
            //1)d. 1 пример операции распаковки 
            long num10 = (int)obj;
        }
    }
}
