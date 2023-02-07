using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int asss;
            Console.WriteLine("Enter the size of array :");
            asss = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[asss];// declaring an array 
            int i;
            int sa;
            int uselm,b;
            Console.WriteLine("\nEnter operation u want to perfoem: ");
            Console.WriteLine("\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit");
            sa = Convert.ToInt32(Console.ReadLine());
            switch (sa)
            {
                case 1:
                    for (i = 0; i < a.Length; i++)
                    {
                        Console.Write("enter element {0} :", i + 1);
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                case 2:
                    for (i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine("Element : {0} - {1}", i, a[i]);
                    }
                    Console.WriteLine("\n\tEnter element index  u want to update : ");
                    uselm = Convert.ToInt32(Console.ReadLine());
                    for ( i = 0; i < a.Length; i++)
                    {
                        if(i == uselm)
                        {
                            Console.WriteLine("U have selected: {0} - {1}", i, a[i]);
                            Console.WriteLine("Enter the new data : ");
                            b = Convert.ToInt32(Console.ReadLine());
                            a[i] = b;
                        }
                    }
                    Console.WriteLine("New Array is  : ");
                    for (i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine("Element : {0} - {1}", i, a[i]);

                    }
                    break;
                case 3:
                    Console.Write("\n\tElements in arraÿ are :\n");
                    break;
                case 4:
                    Console.Write("\n\tElements in arraÿ are :\n");
                    for (i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine("Element : {0} - {1}", i, a[i]);
                        
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter Apporptate solution!!!!!!");
                    break;
            }


            Console.ReadLine();
        }
    }
}
