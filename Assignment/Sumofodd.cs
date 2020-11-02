using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Sumofodd
    {
        static void Main()
        {
            int s = 0;
            Console.WriteLine("enter number n:");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                if(i%2 !=0)
                {
                    s = s + i;
                }
            }
            Console.WriteLine("the num of the odd numbers is:{0}", s);
            Console.Read();
        }
    }
}
