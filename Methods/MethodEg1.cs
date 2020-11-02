using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MethodEg1
    {
        //method with void return type
         void Welcome()
        {
            Console.WriteLine("Hello world");
        }
        //method with string return type
        string Getname()
        {
            return "SRI";
        }
        //method with int return type
        int GetAge()
        {
            return 22;
        }
        //method with character return type
        char GetInitial()
        {
            return 'P';
        }
        static void Main()
        {
            MethodEg1 eg1 = new MethodEg1();
            string name = eg1.Getname();
            eg1.Welcome();
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Age:{0}", eg1.GetAge());
            Console.WriteLine("Initial leter:{0}", eg1.GetInitial());
            Console.Read();
        }
    }
}
