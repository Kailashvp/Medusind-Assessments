using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class SalesDetails
    {
        public int salesno { get; set; }
        public int productno { get; set; }
        public double Price { get; set; }
        public DateTime DateofSale { get; set; }
        public int Qty { get; set; }
        public double TotalAmount { get; private set; }

        public SalesDetails(int salesNo, int productNo, double price, DateTime dateofSale, int qty)
        {
            salesno = salesNo;
            productno = productNo;
            Price = price;
            DateofSale = dateofSale;
            Qty = qty;
            Sales();
        }
        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public void showData()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Sales No: " + salesno);
            Console.WriteLine("Product No: " + productno);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Date of sale: " + DateofSale);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total amount: " + TotalAmount);
            Console.ReadLine();
        }
    }
    public class sales
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter sales no: ");
            int salesno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product no: ");
            int productno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter date of sale(dd-mm-yyyy): ");
            DateTime dateofsale = DateTime.Parse(Console.ReadLine());
            Console.Write("ENter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            SalesDetails sales = new SalesDetails(salesno, productno, price, dateofsale, qty);
            sales.showData();
        }
    }
}