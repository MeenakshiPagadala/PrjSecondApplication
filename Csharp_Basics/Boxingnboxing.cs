
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    class Boxingnboxing
    {
        static void Main()
        {
            //Boxing =  converting the value to reference
            int petrol = 100;
            object o = petrol;
            Console.WriteLine("boxing:{0}",o);


            //Unboxing = converting reference to value
            string oil = "10";
            int oilprice = Convert.ToInt32(oil);
            Console.WriteLine("unboxing:{0}", oilprice);
            Console.Read();
        }
    }
}
