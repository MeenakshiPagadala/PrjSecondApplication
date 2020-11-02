using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class ArrayEg2
    {
        static void Main()
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32( Console.ReadLine());
            int[] marks = new int[num];
            for (int i=0; i <marks.Length; i++)
            {
                Console.WriteLine("enter the value {0}:", i);
                marks[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <marks.Length; i++)
            {
                Console.WriteLine("the value marks{0}:{1}", i,marks[i]);
            }
            Console.Read();
        }
    }
}
