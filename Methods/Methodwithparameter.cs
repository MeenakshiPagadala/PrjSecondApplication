using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Methodwithparameter
    {
        void Byvalue(string p)
        {
            p = "0000000000";
            Console.WriteLine("Value inside method {0}", p);
        }
        void Byreference(ref string ph)
        {
            ph = "0000000000";
            Console.WriteLine("Value inside method {0}", ph);
        }
        static void Main()
        {
            string phno = "561234789";
            Methodwithparameter mobj = new Methodwithparameter();
            Console.WriteLine("before calling byvalue method:{0}", phno);
            mobj.Byvalue(phno);
            Console.WriteLine("after calling byvalue method:{0}", phno);
            Console.WriteLine("---------------------------");
            Console.WriteLine("before calling byreference method:{0}", phno);
            mobj.Byreference(ref phno);
            Console.WriteLine("after calling byreference method:{0}", phno);
            Console.Read();
        }
    }
}
