using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics
{
    enum Feedback
    {
        poor,fair,good,verygood, excellent
    }

    class EnumerationEg
    {
        enum Months
        {
            jan=1,feb,mar,april,may,june,july,aug,sep,oct,Nov,dec
        }
        static void Main()
        {
            string name = "sai";
            Console.WriteLine("name: {0},  rating: {1}", name, Feedback.verygood);
            Console.WriteLine("name: {0},  rating: {1}", name, (int) (Feedback.verygood));
            Console.WriteLine("name: {0},  rating: {1}", name, Convert.ToInt32(Feedback.verygood));
            Console.WriteLine("name: {0},  rating: {1}", name, Convert.ToInt32(Feedback.verygood));
            Console.WriteLine("name: {0},  month of birth : {1}", name, (Months.Nov));
            Console.Read();
        }
    }
}
