using System;

namespace Static_Function
{
    class abcd
    {
        public int count = 0;
        public static void printcount() // Due to satic function we need to use class->Object.
        {
            abcd oa = new abcd();
            oa.count = oa.count + 1;
            Console.WriteLine("The value is {0}", oa.count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            abcd.printcount(); // Due to 2 diffent static function is 2 differen class . We cannot use the object to call upon the fucntion.
            abcd.printcount(); // So we use the class direcly to call the function.
            Console.ReadLine();
        }
    }
}
