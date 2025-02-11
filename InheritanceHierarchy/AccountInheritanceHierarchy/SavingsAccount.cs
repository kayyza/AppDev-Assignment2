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
                if (value > 0)
                {
                    interestRate = value;
                }
                else
                {
                    Console.WriteLine("Interest rate should be a positive value");
                    interestRate = 0.05m;
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
            DrawLine();
            Console.WriteLine($"│ {"SAVINGS ACCOUNT",45}  {"│",33}");
            DrawLine();
            Console.WriteLine($"│ {"Account Number",-25} │ {AccNumber,50} │");
            Console.WriteLine($"│ {"Balance Ammount",-25} │ {Balance,50} │");
            Console.WriteLine($"│ {"Last Name",-25} │ {LastName,-50} │");
            Console.WriteLine($"│ {"First Name",-25} │ {FirstName,-50} │");
            Console.WriteLine($"│ {"Interest Rate",-25} │ {InterestRate,50} │");
            Console.WriteLine($"│ {"Interest Amount",-25} │ {CalculateInterest(),50} │");
        }
    }
}
