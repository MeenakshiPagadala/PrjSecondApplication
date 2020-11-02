using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FrequencyofNo
    {
        static void Main()
        {
            int k = 0;
            Console.WriteLine("enter the number of elements in an array:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[num];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter the value {0}:", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter the number to determine the frequency:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                if (n == numbers[i])
                {
                    k = k + 1;  
                }
            }
            Console.WriteLine("the frequency of the number {0} is {1}",n,k);
            Console.Read();
        }
    }
}
