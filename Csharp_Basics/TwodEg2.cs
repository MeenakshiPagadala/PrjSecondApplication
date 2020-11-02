using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class TwodEg2
    {
        static void Main()
        {
            Console.WriteLine("enter the rows:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the rows:");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("enter the value of matrix1[{0},{1}]: ", i, j);                  
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("enter the value of matrix1[{0},{1}]:{2} ", i, j, matrix1[i, j]);
                }
            }
            Console.Read();
        }
    }
}
