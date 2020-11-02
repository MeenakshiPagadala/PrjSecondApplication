using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class StringEg
    {
        static void Main()
        {
            string name = "Meenakshi";
            Console.WriteLine("length:{0}", name.Length);
            Console.WriteLine("Uppercase:{0}", name.ToUpper());
            Console.WriteLine("contains:{0}", name.Contains("na"));
            Console.WriteLine("index:{0}", name.IndexOf('i'));
            Console.WriteLine("to check whether the name starts with:{0}", name.StartsWith("M"));
            Console.Read();
        }
    }
}
