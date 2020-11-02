using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Noofdigits
    {
        static void Main()
        {
            int k=0,i;
            Console.WriteLine("Enter the number:");
            int n =Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                i = n % 10;
                if (i>0)
                {
                    k = k + 1;
                }
                n = n / 10;
            }
            Console.WriteLine("number of digits:{0}", k);
            Console.Read();
        }
    }
}
