using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Program
    {
        public void add(int x, int y) //Function of a class
        {
            Console.WriteLine("The sum is {0}", (x + y));
        }
        public int sub(int x, int y)  //Function of a class
        {
            int c;
            c = x - y;
            return c;
        }
        static void Main(string[] args)
        {
            Program pp = new Program(); //Class Object is created.
            pp.add(12,4); // Fucntion called by Obj
            int result = pp.sub(12, 4);
            Console.WriteLine("Sub is {0}", result);
            Console.ReadLine();

        }
    }
}
