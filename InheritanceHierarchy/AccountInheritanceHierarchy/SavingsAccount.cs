using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    internal class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string accNumber, decimal initialBalance, string lastName, string firstName, decimal interestRate)
            : base(accNumber, initialBalance, lastName, firstName)
        {
            InterestRate = interestRate;
        }

        // property for interestRate attribute
        public decimal InterestRate
        {
            get
            {
                return interestRate;
               
            }
            set
            {
                if (interestRate < 0)
                {
                    interestRate = 0.05m;
                    Console.WriteLine("Interest rate should be a positive value");
                }
                else
                {
                    interestRate = value;
                }
            }
        }

        // calculates the amount of interest earned by an account
        public decimal CalculateInterest()
        {
            decimal interest = InterestRate * Balance;
            return interest;
        }

        public override void DisplayAccount()
        {
            base.DisplayAccount();
            Console.WriteLine($"│ {"Interest Rate",-25} │ {InterestRate,50} │");
            Console.WriteLine($"│ {"Interest Amount",-25} │ {CalculateInterest(),50} │");
        }

        //public static void DrawLine()
        //{
        //    Console.Write("│");
        //    for (int i = 0; i < 80; i++)
        //    {
        //        Console.Write("─");

        //    }
        //    Console.WriteLine("│");
        //}

    }
}
