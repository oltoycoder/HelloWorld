using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Person n = new Person();
            Console.WriteLine("What is your name");
            String name = null;
            name = Console.ReadLine();
            n.setName(name);
            Console.WriteLine("What is your age?");
            int age = 0;
            age = Convert.ToInt32(Console.ReadLine());
            n.setAge(age);
            Console.WriteLine("What is your email?");
            String email = null;
            email = Console.ReadLine();
            n.setEmail(email);
            Console.WriteLine("What is your first address line?");
            String addressLine1;
            addressLine1 = null;
            addressLine1 = Console.ReadLine();
            n.setALine1(addressLine1);
            Console.WriteLine("What is your second address line?");
            String addressLine2;
            addressLine2 = null;
            addressLine2 = Console.ReadLine();
            n.setALine2(addressLine2);
            Console.WriteLine("What is your postcode?");
            String postcode;
            postcode = null;
            postcode = Console.ReadLine();
            n.setPostcode(postcode);
            Console.WriteLine("");
            n.printDetails();
            //Person x = new Person();
            //x.setName("Hello{0}" + name);
        }
    }
}
