using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class reverseprob
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plz enter:");
            string abc = Console.ReadLine();
            string reversedword = "";
            for (int i = abc.Length - 1; i >= 0; i--) {
                reversedword += abc[i];
        }
        Console.WriteLine("After reversing of the Text  " + reversedword);
        Console.ReadLine(); 
    }
}
}