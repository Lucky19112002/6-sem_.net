using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraysDemo
{
    class Customer
    {
        public int CustomerId { set; get; }
        public string CustomerName { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[3] { 12, 34, 56 };//infinite array which is declared and also intilized 
            int[] a = new int[5];// declaring an array 
            Console.WriteLine("Reading the array ..");
            int i, j, sum = 0;
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("enter element {0} :", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n Printing the array ..");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Console.WriteLine("\n calulating sum of elements ..");
            for (i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("\nThe sum of array elments is {0}  ", sum);
            Console.WriteLine("printing the array using for each loop");
            foreach (int ele in a)
            {
                Console.Write("{0,4}", ele);
            }
            Console.WriteLine("\n enter elelement to be searched in array");
            int searchele = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == searchele)
                {
                    Console.WriteLine("The element {0} is found at position {1}", searchele, i + 1);
                }
            }
            Console.WriteLine("\n now sorting the array..");
            for (i = 0; i < a.Length - 1; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n Printing the array after sorting..");
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);
            }
            Customer[] clist = new Customer[3];
            Console.WriteLine("\nenter values in customer array provide the details");
            for (i = 0; i < 3; i++)
            {
                Customer c = new Customer();
                Console.WriteLine("enter customer {0} Id :", i + 1);
                c.CustomerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter customer {0} Name :", i + 1);
                c.CustomerName = Console.ReadLine();

                clist[i] = c;
            }

            Console.WriteLine("\n display customers ..");
            foreach (Customer cust in clist)
            {

                Console.WriteLine("{0}-{1}", cust.CustomerId, cust.CustomerName);
            }
            Console.ReadLine();

        }
    }
}