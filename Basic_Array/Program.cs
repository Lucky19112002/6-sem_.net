using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int j ,i, sum = 0;
            Console.WriteLine("\nWrite the array ");
            for ( i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter telement [{0}]", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());                                            //Enter element in array
            }
            Console.WriteLine("\nPrinting array... ");
            for ( i = 0; i < a.Length; i++)
            {
                Console.Write("{0,4}", a[i]);                                                          //Print array
            }
            Console.WriteLine("\nCalcuate sum of array... ");
            for ( i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];                                                                       //Sum of array elements.
            }
            Console.WriteLine("\nThe sum od array is {0}", sum);
            Console.WriteLine("\nDisplay array using fpr each loop");
            foreach (int ele in a)
            {
                Console.Write("\n{0,4}", ele);                                                          //Print using ForEach Loop Function
            }
            Console.WriteLine("\nEnter the element  to be search in array :");
            int searchable = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == searchable)
                {
                    Console.WriteLine("\n The elemnt {0} is found at {1} position", searchable, i + 1); // Search and Element in array
                }
            }                
            Console.WriteLine("\nShorting the above array");
            for ( i = 0; i < a.Length; i++)
            {
                for ( j = 0; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];                                                                      // Shorting array in asseding S
                        a[j] = temp;
                    }
                }
            }
            for ( i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\n{0}", a[i]);
            }
            Console.ReadLine();
        }
    }
}
