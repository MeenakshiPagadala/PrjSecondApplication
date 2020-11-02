using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class NaturalReverse
    {
        static void Main()
        {
            Console.WriteLine("Enter number n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=n; i>0; i--)
            {
                Console.WriteLine("{0}", i);
            }
            Console.Read();
        }
    }
}
