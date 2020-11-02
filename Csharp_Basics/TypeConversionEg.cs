using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class TypeConversionEg
    {
        static void Main()
        {
            int salary = 2000;
            float f = salary;
            double d = f;
            Console.WriteLine("SALARAY IN int= {0}, SALARAY IN float= {1},  SALARAY IN double= {2} ", salary, f, d);
            float sal = 2500.89f;
            int sal2 = Convert.ToInt32(sal);
            Console.WriteLine("SALARAY IN float= {0}, SALARAY IN int= {1}", sal, sal2);
            Console.Read();
        }
    }
}
