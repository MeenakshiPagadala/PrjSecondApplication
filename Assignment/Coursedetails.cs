using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Coursedetails
    {
        void Coursedetail()
        {
            Console.WriteLine("enter the course-id:");
            string cid = Console.ReadLine();
            Console.WriteLine("enter the course-name:");
            string cname = Console.ReadLine();
            Console.WriteLine("enter the course-fee:");
            int fee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The CourseID is {0},Course name is {1}, Course fee is {2} ", cid, cname, fee);
        }
        static void Main()
        {
            Console.WriteLine("The course details");
            Coursedetails eg = new Coursedetails();
            eg.Coursedetail();
            Console.Read();
        }
    }
}
