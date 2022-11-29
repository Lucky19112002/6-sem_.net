using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            while (i<=10)
            {
                i++;
                if (i == 5)
                    continue;
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
        }
    }
}
