using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    internal class Account
    {
        private string accNumber;
        private decimal accBalance;
        private string lastName;
        private string firstName;

        public Account(string accNumber, decimal initialBalance, string lastName, string firstName)
        {
            AccNumber = accNumber;
            Balance = initialBalance;
            LastName = lastName;
            FirstName = firstName;
        }


        // property for accNumber
        public string AccNumber
        {
            get
            {
                return accNumber;

            }
            set
            {
                accNumber = value;
            }
        }

        // property for Balance, checking if it is positive
        public decimal Balance
        {
            get
            {
                return accBalance;
            }
            set
            {
                if (value < 0)
                {
                    accBalance = 0;
                    Console.WriteLine("Account initial balance amount should be a positive value");
                }
                else
                {
                    accBalance = value;
                    
                }
            }
        }

        // property for last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // property for first name 
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // adds a positive amount to the current balance
        public virtual void Credit (decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Credit of $" + (amount) + " was added.");
            }
        }



        // withdraws money from the Account
        public virtual bool Debit (decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Debit amount exceeded account balance");
                return false;
            } 
            else
            {
                Balance -= amount;
                return true;

            }
        }

        public virtual void DisplayAccount()
        {

            string balance = "$" + Balance;
            
            DrawLine();
            Console.WriteLine($"│ {"ACCOUNT",45}  {"│",33}");
            DrawLine();

            Console.WriteLine($"│ {"Account Number",-25} │ {AccNumber,50} │");
            Console.WriteLine($"│ {"Balance Ammount",-25} │ {balance,50} │");
            Console.WriteLine($"│ {"Last Name",-25} │ {LastName, -50} │");
            Console.WriteLine($"│ {"First Name",-25} │ {FirstName, -50} │");
           
            DrawLine();

        }

        public static void DrawLine()
        {
            Console.Write("│");
            for (int i = 0; i < 80; i++)
            {
                Console.Write("─");

            }
            Console.WriteLine("│");
        }

    }
}
