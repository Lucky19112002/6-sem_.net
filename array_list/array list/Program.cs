using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list
{
     class program
    {
        static void Main(string[] args)
        {
            arraylist obj = new arraylist;
            obj.Add(true);
            obj.Add(A);
            obj.Add(234.67);
            obj.Add("kiran");
            Console.WriteLine("\n printing noe generic array liast");
            foreach(var ele in obj) { 
                Console.WriteLine("{0}",ele);
            }
            for (int i=0;i<=3;i++)
            {
                obj.Add(Console.ReadLine());
            }
            Console.WriteLine("\n printing arraylist now with size {0}", obj.count);
            foreach(var ele in obj)
            {
                Console.WriteLine("{0}",ele);
            }
            string[] names = new string[] {"k","s","m"};
            obj.AddRange(names);
            Console.WriteLine("printing array list{0}",obj.count);
            foreach(var ele in obj)
            {
                Console.WriteLine("{0}",ele);
            }
            obj.Insert(0, "coming first");
            obj.RemoveAt(4);
            Console.WriteLine("printing array{0)", obj.count);
            foreach(var ele in obj)
            {
                Console.WriteLine("{0}",ele);
            }
            obj.Reverse();
            Console.WriteLine("printing array {0}", obj.count);
            foreach(var ele in obj)
            {
                Console.WriteLine("{0}",ele);
            }
            Console.ReadLine();
        }
    }
}
