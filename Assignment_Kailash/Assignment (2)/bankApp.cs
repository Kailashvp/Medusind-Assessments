using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    
    public class Acc
    {
         int AccNo;
         string CusName;
         string AccType;
         string transactionType;
         double Amt;
         double Bal;

        public Acc(int Accno, string CusName, string AccType, string transactionType, double Amt) 
        {
            this.AccNo = AccNo;
            this.CusName = CusName;
            this.AccType = AccType;
            this.transactionType = transactionType;
            this.Amt = Amt;
            this.Bal = 0;
        }

        public void Credit(double Amt)
        {
            Bal += Amt;
        }

        public void Debit(double Amt)
        {
            Bal -= Amt;
        }

            public void ShowData() 
        {
            Console.WriteLine("Enter Account NO:");
            this.AccNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            this.CusName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            this.AccType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (d->deposit / w->withdrawal):");
            this.transactionType = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            this.Amt = Convert.ToDouble(Console.ReadLine());
            if (transactionType == "d")
            {
                transactionType = "Deposit";
                Bal = Bal + Amt;
            }
            else if (transactionType == "w" && Amt < Bal)
            {
                transactionType = "Withdrawal";
                Bal = Bal - Amt;
            }
            else if (transactionType == "w" && Amt > Bal)
            {
                transactionType = "Transaction is not possible.";
            }
            Console.WriteLine("Account NO:"+AccNo);
            Console.WriteLine("Customer Name:"+CusName);
            Console.WriteLine("Account Type:" +AccType);
            Console.WriteLine("Transaction Type:" +transactionType);
            Console.WriteLine("Amount:"+Amt);
            Console.WriteLine("Balance:"+Bal);
        }
    }
    public class Accountsabc
    {
        public static void Main(string[] args)
        {
            Acc myaccount = new Acc(0938238,"Kailash","savings","d",50000.00);
            myaccount.Credit(1000);
            myaccount.Debit(0);
            myaccount.ShowData();
            Console.Read();
        }
    }

}