using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,choice;
            Console.WriteLine("Enter value in a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subs");
                Console.WriteLine("3. Mul");
                Console.WriteLine("4. Div");
                Console.WriteLine("ENTER YOUR CHOICE ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
	            {
                    case 1: c = a + b ;
                        Console.WriteLine("The sum is {0}",c);
                        break;
                    case 2: c = a - b ;
                        Console.WriteLine("The sub is {0}",c);
                        break;
                    case 3: c = a * b ;
                        Console.WriteLine("The mul is {0}",c);
                        break;
                    case 4: c = a / b ;
                        Console.WriteLine("The div is {0}",c);
                        break; 
                    default:
                        Console.WriteLine("Enter value form 1 to 4 only ");
                        break;
	            }
                Console.WriteLine("Do hyou want to continue <y/n>....... ?");
                if(Console.ReadLine() != "y")
                {
                    break;
                }
	        } while (true);
            {
                /*Console.WriteLine("Printing using do while loop");

            int counter = 1;
            do
            {
                Console.Write("{0,5}", counter);
                if (counter%100 == 0 && counter != 0)
                {
                    Console.Write("\n Keep Continuing ..... <y/n>?");
                    if(Console.ReadLine() != "y")
                    {
                        break;
                    }
                }
                counter = counter + 1;
            } while (true);
            Console.WriteLine("Finish Counting");
            Console.ReadLine();*/
                }
            {
                /*int counter = 1;
            do
            {
                Console.Write("{0,5}", counter);
                counter = counter + 1 ;
            }while (counter <= 100);
            Console.ReadLine();*/
             }
        }
    }
}
