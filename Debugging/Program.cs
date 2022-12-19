using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Employee
    {
        public void totalsalary(int sal,int bons)
        {
            Console.WriteLine("Total salalry is  --1" + (sal + bons));
            Console.WriteLine("Total salalry is  --2" + (sal + bons));
            Console.WriteLine("Total salalry is  --3" + (sal + bons));
            Console.WriteLine("Total salalry is  --4" + (sal + bons));
            Console.WriteLine("Total salalry is  --5" + (sal + bons));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee ee = new Employee();
            ee.totalsalary(25000, 4000);
            Console.WriteLine("Hellow World!");
            Console.WriteLine("Hai");
            Console.ReadLine();
        }
    }
}
