using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public interface IStudents
    {
        int Stdid { get; set; }
        string Name { get; set; }
        int Fees { get; set; }
        void ShowDetails();
    }
    public class DayScholar : IStudents
    {
        public int Stdid { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Dayscholar Details");
            Console.WriteLine("Student ID: " + Stdid);
            Console.WriteLine("Studetn Name: " + Name);
            Console.WriteLine("Fees: " + Fees);
            Console.WriteLine();
        }
    }
    public class Resident : IStudents
    {
        public int Stdid { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Resident Details");
            Console.WriteLine("Student ID: " + Stdid);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Fees: " + Fees);
            Console.WriteLine();
        }
    }
    class Interface
    {
        public static void Main()
        {
            DayScholar ds = new DayScholar();

            Console.WriteLine("Enter the Student Id: ");
            ds.Stdid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Name: ");
            ds.Name = Console.ReadLine();

            Console.WriteLine("Enter the fees amount: ");
            ds.Fees = Convert.ToInt32(Console.ReadLine());

            ds.ShowDetails();

            Resident r = new Resident();

            Console.WriteLine("Enter the Student Id: ");
            r.Stdid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Student Name: ");
            r.Name = Console.ReadLine();

            Console.WriteLine("Enter the fees amount: ");
            r.Fees = Convert.ToInt32(Console.ReadLine());

            r.ShowDetails();

            Console.Read();
        }
    }
}
