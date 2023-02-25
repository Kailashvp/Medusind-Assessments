using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class abc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first name Plz :");
            string firstName = Console.ReadLine();

            Console.WriteLine("last name Plz :");
            string lastName = Console.ReadLine();

            abc pro = new abc();
            Display(firstName.ToUpper(),lastName.ToUpper());
        }

        public static void Display(string firstName, string lastName)
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.Read();
        }
    }
}