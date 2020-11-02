using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calling one methd from another method
namespace Methods
{
    class MethodEg2
    {
        int Displayage(int age)
        {
            return age;
        }
        void Displayuserdetails(string cn, string ct, string ge, string em,int a)
        {
            int ag = Displayage(a);
            Console.WriteLine("name:{0}, city:{1}, gender:{2}, email:{3}, age:{4}", cn, ct, ge, em,a);
        }
        int Total(int[] marray)
        {
            int sum = 0;
            for (int i = 0; i < marray.Length; i++)
            {
                sum = sum + marray[i];
            }
            return sum;
        }
        static void Main()
        {
            int[] marks = { 89, 80, 70 };
            string Cname, city, gender, email;
            Console.WriteLine("enter name");
            Cname = Console.ReadLine();
            Console.WriteLine("enter city");
            city = Console.ReadLine();
            Console.WriteLine("enter gender");
            gender = Console.ReadLine();
            Console.WriteLine("enter email");
            email = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32(Console.ReadLine());
            MethodEg2 eg2 = new MethodEg2();
            eg2.Displayuserdetails(Cname, city, gender, email,age);
            Console.WriteLine("sum of the marks{0}", eg2.Total(marks));
            Console.Read();


        }
    
    }
}
