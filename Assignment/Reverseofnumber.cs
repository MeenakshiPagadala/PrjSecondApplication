using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Reverseofnumber
    {
        static void Main()
        {
            int i,m=0;
            Console.WriteLine("enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                i = n % 10;
                if (i>0)
                {
                    m = m * 10 + i;
                }
                n = n / 10;
            }
            Console.WriteLine("the reverse of the number:{0}",m);
            Console.Read();
        }
    }
}
