using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to .net";
            Console.WriteLine("{0}", str);
            string fname, lname, mname;
            Console.WriteLine("Enter Firstname : ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Lastname : ");
            lname = Console.ReadLine();
            Console.WriteLine("Enter Middlename : ");
            mname = Console.ReadLine();
            Console.WriteLine("FirstName is {0} \nMiddleName is {1} \nLastName is {2}", fname, mname, lname);
            string fullname = fname + " " + mname + " " + lname;
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0}", fullname.ToUpper()); ;
            Console.WriteLine("Extrect miffle name {0}", fullname.Substring(5, 5));
            string s1 = "hellow", s2 = "hi", s3 = "hellow";
            Console.WriteLine("String is {0}", s1.Equals(s3));
            s1 = s2;
            Console.WriteLine("String is {0}", s1.Equals(s3));
            Console.ReadLine();
        }
    }
}
