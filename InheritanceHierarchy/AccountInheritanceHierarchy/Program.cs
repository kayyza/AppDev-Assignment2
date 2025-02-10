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
            //Console.WriteLine("Please enter your Account Number: ");
            //string accNumber = Console.ReadLine();
            //Console.WriteLine("Please enter your current balance: ");
            //decimal currentBalance = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your last name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Please enter your first name: ");
            //string firstName = Console.ReadLine();

            //Account account = new Account(accNumber, currentBalance, lastName, firstName);
            //account.DisplayAccount();

            Console.WriteLine("Please enter your Account Number: ");
            string accNumber = Console.ReadLine();
            Console.WriteLine("Please enter your current balance: ");
            decimal currentBalance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter interest rate: ");
            decimal interestRate = decimal.Parse(Console.ReadLine());

            SavingsAccount savingsAccount = new SavingsAccount(accNumber, currentBalance, lastName, firstName, interestRate);
            savingsAccount.DisplayAccount();
        }
    }
}
