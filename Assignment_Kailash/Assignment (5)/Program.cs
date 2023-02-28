using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    public abstract class Student
    {
        public string Name;
        public int Studid;
        public double Grade;
        public abstract bool Ispass(double grade);
    }

    class UG : Student
    {
        public override bool Ispass(double grade)
        {
            if (grade > 70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate : Student
    {
        public override bool Ispass(double grade)
        {
            if (grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class student
    {
        static void Main(string[] arge)
        {
            UG u = new UG();

            Console.Write("Enter the name of the undergraduate student: ");
            u.Name = Console.ReadLine();

            Console.Write("Enter the student ID: ");
            u.Studid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the grade for the course: ");
            u.Grade = Convert.ToDouble(Console.ReadLine());

            bool status = u.Ispass(u.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", u.Name, u.Studid, status);

            Graduate g = new Graduate();

            Console.Write("Enter the name of the graduate student: ");
            g.Name = Console.ReadLine();

            Console.Write("Enter the student ID: ");
            g.Studid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the grade for the course: ");
            g.Grade = Convert.ToDouble(Console.ReadLine());

            status = g.Ispass(g.Grade);
            Console.WriteLine("Status for {0} with ID {1}: {2}", g.Name, g.Studid, status);

            Console.ReadLine();
        }
    }
}
