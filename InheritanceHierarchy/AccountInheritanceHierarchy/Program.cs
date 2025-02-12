using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Account Number: ");
            string accNumber = Console.ReadLine();
            Console.WriteLine("Please enter your current balance: ");
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the interest rate: ");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the transaction fee: ");
            decimal fee = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            // savings account before and after
            SavingsAccount savingsAccount = new SavingsAccount(accNumber, currentBalance, lastName, firstName, interestRate);
            savingsAccount.DisplayAccount();

            Console.WriteLine();
            decimal interestAmount = savingsAccount.CalculateInterest();
            savingsAccount.Credit(interestAmount);
            Console.WriteLine();

            savingsAccount.DisplayAccount();

            // checking account before and after
            CheckingAccount checkingAccount = new CheckingAccount(accNumber,currentBalance, lastName, firstName, fee);
            checkingAccount.DisplayAccount();
            Console.WriteLine();

            checkingAccount.Debit(100);
            Console.WriteLine();
            checkingAccount.DisplayAccount();
        }
    }
}
