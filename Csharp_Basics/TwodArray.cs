using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class TwodArray
    {
        static void Main()
        {
            //static declaration
            int[,] matrix = new int[2, 2] { { 10, 20 }, { 30, 40 } };
            for(int i=0; i<2; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine("the values of ({0}{1}):{2}",i, j,matrix[i,j]);
                }
            }
            Console.Read();

         
        }
    }
}
