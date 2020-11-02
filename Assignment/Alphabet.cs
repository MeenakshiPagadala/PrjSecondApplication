using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Alphabet
    {
        static void Main()
        {
            char i = 'A';
            while (i<='Z')
            {
                Console.WriteLine("{0}", i);
                i++;
            }
            Console.Read();
        }
    }
}
