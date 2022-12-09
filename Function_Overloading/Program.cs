using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Overloading
{

    class abcd
    {
        public void add(int x, float y)
        {
            Console.WriteLine("Sum iś {0}", (x + y));
        }
        public decimal add(int x, float kk, decimal cc)
        {
            return (x + Convert.ToDecimal(kk) + cc);
        }
        public double add(int x, float ss, double dd)
        {
            return (x + Convert.ToDouble(ss) + dd);
        }
    }
    class cde : abcd
    {
        public void add(int x, int c)
        {
            Console.WriteLine("The sum os {0}",(x+c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cde cc = new cde();
            cc.add(12, 15); // class - cde : add(int,int)
            cc.add(12, 'A');// class - abcd : add(int,float)
            Console.WriteLine( cc.add(12, 45.6f, 254.26)); // class - abcd : add(int,float,decimal)
            Console.WriteLine( cc.add(12, 45.6F, 444.26)); // class - abcd : add(int,float,dobule)
            Console.ReadLine();
        }
    }
}
