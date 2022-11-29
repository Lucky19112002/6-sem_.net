using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0 , pow = 1 , x , y ;
            Console.WriteLine("Enter Value & Power : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= y; i++)
            {
                pow = pow * x;
            }
            Console.WriteLine("The {0} to the power {1} is {2}", x, y, pow);
            Console.ReadLine();
        }
    }
}
