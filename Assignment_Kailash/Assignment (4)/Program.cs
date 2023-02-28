using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class Person
    {
        protected string Name { get; set; }
        protected string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
    public class Doctor : Person
    {
        string RegNo { get; set; }
        double FeesCharge { get; set; }
        string Specialization { get; set; }

        public Doctor(string name, string address, string regNo, double feesCharge, string specialization)
            : base(name, address)
        {
            RegNo = regNo;
            FeesCharge = feesCharge;
            Specialization = specialization;
        }

        public void ShowData()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Registration Number: " + RegNo);
            Console.WriteLine("Fees Charged: " + FeesCharge);
            Console.WriteLine("Specialization: " + Specialization);
            Console.Read();
        }
    }

    public class doctor
    {
        public static void Main()
        {
            Console.Write("Enter the name of the Doctor: ");
            string name = Console.ReadLine();

            Console.Write("Enter the address of the Doctor: ");
            string address = Console.ReadLine();

            Console.Write("Enter the registration number of the Doctor: ");
            string regNo = Console.ReadLine();

            Console.Write("Enter the fees charged by the Doctor: ");
            double feescharge = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the specialization of the Doctor: ");
            string specialization = Console.ReadLine();

            Doctor doctor = new Doctor(name, address, regNo, feescharge, specialization);
            doctor.ShowData();
        }
    }

}
