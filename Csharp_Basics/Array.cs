using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Array
    {
        static void Main()
        {
            string[] flower = new string[4];
            flower[0] = "Sunflower";
            flower[1] = "Jasmine";
            flower[2] = "Rose";
            flower[3] = "Some random new flower";
            Console.WriteLine(flower[0]);
            for(int i=0; i<=3; i++)
            {
                Console.WriteLine("index{0}:{1}", i, flower[i]);
            }


            // int[] marks = new int[4] { 90, 89, 56, 78 };
            int[] marks = {4,5,6,7,8,9,10 };
            for (int size = 0; size < marks.Length; size++)
            {
                //Console.WriteLine("index{0}:{1}", size, marks[size]);
                Console.WriteLine(marks[size]);
            }

            Console.Read();
        }


    }
}
