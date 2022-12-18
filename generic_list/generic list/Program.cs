using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_list
{ 
    class product
    {
        public int productID { get; set; }
        public string productName { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int>() { 1, 2, 3, 4 };
            numbers.Add(20);
            List<string> cities = new List<string>() { "a","b","c"};
            cities.Add( "vadodara");
            Console.WriteLine("\n printing numbers");
            foreach(int i in numbers)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine("\n printing cities");
            foreach(string city in cities)
            {
                Console.WriteLine("{0}", city);
            }
            List<product> products = new List<product>();
            Console.WriteLine("enter no of products");
            int noofproducts=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n enter product details");
            for(int i=0;i<noofproducts;i++)
            {
                product p= new product();
                Console.WriteLine("enter procut ID{0}", i+1);
                p.productID=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter product nsme{0}", i + 1);
                p.productName=Console.ReadLine();
                products.Add(p);
            }
            Console.WriteLine("product display");
            foreach(product prd in products)
            {
                Console.WriteLine("{0}.......{1}",prd.productID,prd.productName);
            }
            Console.ReadLine();
        }
    }
}
