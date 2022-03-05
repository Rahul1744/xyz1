using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term5
{
    public partial class Account
    {
        double PA, IR, time, SI;
        public void CalculateInterest()
        {
            Console.Write("Enter Principle Amount (P):");
            PA = double.Parse(Console.ReadLine());
            Console.Write("Enter Interest Rate (R):");
            IR = double.Parse(Console.ReadLine());
            Console.Write("Enter the time Duration (T):");
            time = double.Parse(Console.ReadLine());
        }
        partial void ShowAmount();
    }

    partial class Account
    {
        partial void ShowAmount()
        {
            double amount = PA + SI;
            Console.WriteLine("Total amount {0}", amount);
        }
        public void ShowInterest()
        {
            SI = (PA * IR * time) / 100;
            Console.WriteLine("Simple Interest {0}",SI);
            ShowAmount();
            Console.WriteLine("\nPress Enter to quit");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.CalculateInterest();
            acc.ShowInterest();
        }
    }
}
