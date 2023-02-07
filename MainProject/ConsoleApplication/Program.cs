using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindQueue;
namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            findingcube cube = new findingcube();
            Console.WriteLine("{0}", cube.cubefind(3));
            Console.ReadLine();
        }
    }
}
