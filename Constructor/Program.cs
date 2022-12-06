using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{

    class Customer
    {
        public int customer_id;
        public string customer_name;
        public Customer()
        {
            Console.WriteLine("This is default constructor");
            this.customer_id = 101;
            this.customer_name = "Ravi";
            Console.WriteLine("Id : {0} \n Name : {1}", customer_id, customer_name);
        }
        public Customer(int custid,string custname)
        {
            this.customer_id = custid;
            this.customer_name = custname;
            Console.WriteLine("Id : {0} \n Name : {1}", custid,custname);
        }
        public Customer(Customer c)
        {
            this.customer_id = c.customer_id;
            this.customer_name = c.customer_name;
            Console.WriteLine("Id : {0} \n Name : {1}", c.customer_id, c.customer_name);
        }
    }

    class Program

    {
        static void Main(string[] args)
        {
            Customer cc = new Customer();//Default Const
            Customer cc2 = new Customer(102, "Kunil"); //Perimiterized Const
            Customer cc3 = new Customer();
            cc3.customer_id = 103;
            cc3.customer_name = "Lucky";
            Customer cc4 = new Customer(cc3); //Copy Const
            Console.ReadLine();
        }
    }
}