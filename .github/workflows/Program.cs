using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter Id");
            String a =  Console.ReadLine();

            Console.WriteLine("Enter Name");
            String b = Console.ReadLine();

            Console.WriteLine("Enter Department Name");
            String c = Console.ReadLine();


            String d = e1.GetId(a);
            String e = e1.GetId(b);
            String f = e1.GetId(c);
            //int a=e1.GetId(1);

            //e1.GetId(a);
            //String b=e1.GetName("Jay");
           //String c = e1.GetName("Information Technology");
           
           
            Console.WriteLine("Id is "+d );
            Console.WriteLine("Name is " + e);
            Console.WriteLine("Department Name " + e);
        }
    }
}
