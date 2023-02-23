using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class find_same
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Word:");
            string abc1 = Console.ReadLine();
            Console.WriteLine("Second Word:");
            string abc2 = Console.ReadLine();
            if (abc1 == abc2)
            {
                Console.WriteLine("words are  same.");
            }
            else
            {
                Console.WriteLine("words are not same.");
            }
            Console.ReadLine();
        }
    }
}