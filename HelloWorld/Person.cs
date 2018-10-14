using System;
using System.Collections.Generic;
using System.Text;


namespace HelloWorld
{
    class Person
    {
        String name;
        int age;
        String email;
        String aLine1;
        String aLine2;
        String postcode;
        public String getName()
        {
            return name;
        }

        public void setName(String _name)
        {
            name = _name;
            Console.WriteLine("Hello " + _name);
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int _age)
        {
            age = _age;
            Console.WriteLine("Age " + _age);
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String _email)
        {
            email = _email;
            Console.WriteLine("Email " + _email);
        }

        public String getALine1()
        {
            return aLine1;
        }

        public void setALine1(String _aline1)
        {
            aLine1 = _aline1;
            Console.WriteLine("Address line 1 " + _aline1);
        }

        public String getALine2()
        {
            return aLine2;
        }

        public void setALine2(String _aline2)
        {
            aLine2 = _aline2;
            Console.WriteLine("Address line 2 " + _aline2);
        }

        public String getPostcode()
        {
            return postcode;
        }

        public void setPostcode(String _postcode)
        {
            postcode = _postcode;
            Console.WriteLine("Postcode " + _postcode) ;
        }

        public void printDetails()
        {
            Console.WriteLine(name + "\n" + age + "\n" + email + "\n" + aLine1 + "\n" + aLine2 + "\n" + postcode);
        }



    }
}
