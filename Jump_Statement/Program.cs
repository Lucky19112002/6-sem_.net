using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number :"); // First save point 
        L1: Console.WriteLine("Renter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                goto Test1;
            }
            else
            {
                goto L1;
            }
        Test1: Console.WriteLine("It's Done."); // secondsave point 
            Console.ReadLine();
        }
    }
}
