using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_For
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1.0f;
            int n,i;
            Console.WriteLine("Enter Number :");
            n = Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i < n; i++)
			{
                f = f * i ;
			}
            Console.WriteLine("The Factior of {0} is {1}",n,f);
            Console.ReadLine();
        }
    }
}
