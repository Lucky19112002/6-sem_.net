using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class ABCD
    {
        public int a; // Variable in class
        public ABCD()
        {
            Console.WriteLine("Default | ");
        }
        public ABCD(int k)
        {
            a = k;
            Console.WriteLine("{0} | ", a);
            //return a;
        }
        public static ABCD operator +(ABCD a , ABCD b)
        {
            ABCD thired = new ABCD();
            thired.a = a.a + b.a;
            return thired;
            Console.WriteLine("{0} | ", thired);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ABCD c = new ABCD();
            ABCD a = new ABCD(10);
            ABCD b = new ABCD(20);
            c = a + b;

            Console.ReadLine();
            
        }
    }
}
