using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term4
{
    class BankDetails
    {
        public float balance;
        private int accno;

        public float Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public int Accno{
            get
            {
                return accno;
            }
            set
            {
                accno = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankDetails b = new BankDetails();
            Console.WriteLine("Enter the Acc no");
            b.Accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the balance");
            b.Balance = float.Parse(Console.ReadLine());
            Console.WriteLine("Account No :"+ b.Accno);
            Console.WriteLine("Balance    :"+ b.Balance);
            Console.ReadKey();
        }
    }
}
