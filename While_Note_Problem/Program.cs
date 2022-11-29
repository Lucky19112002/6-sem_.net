using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Note_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0 , x =1 , y = 5 , z =10, count = 0;
            while (sum<480)
            {
                count++;
                sum = x + y + z;
                x = x + 1;
                y = y + 5;
                z = z + 10;
            }
            Console.WriteLine("1 X {0} = {1}", count,x);
            Console.WriteLine("5 X {0} = {1}", count, y);
            Console.WriteLine("z X {0} = {1}", count, z);
            Console.WriteLine("Change  is {0}", count);
            Console.ReadLine();
        }
    }
}
