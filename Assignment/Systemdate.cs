using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Systemdate
    {
        DateTime Date()
        {
            DateTime n = DateTime.Now;
            return n;
        }
        static void Main()
        {
            Systemdate sd = new Systemdate();
            Console.Write("Current Date and Time is :{0} ",sd.Date());
            Console.Read();
        }
    }
}
