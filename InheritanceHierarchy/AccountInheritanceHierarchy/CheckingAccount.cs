using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceHierarchy
{
    internal class CheckingAccount : Account
    {
        private decimal transactionFee;

        public CheckingAccount (string accNumber, decimal initialBalance, string lastName, string firstName, decimal transactionFee)
            : base(accNumber, initialBalance, lastName, firstName)
        {
            TransactionFee = transactionFee;
        }

        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            }

            set
            {
                if (value > 0)
                {
                    transactionFee = value;
                }
                else
                {
                    Console.WriteLine("Transaction fee should be a positive value.");
                    transactionFee = 1.5m;
                }
            }
        }

        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= transactionFee;
        }

        public override bool Debit(decimal amount)
        {
            base.Debit(amount);
            Balance -= TransactionFee;
            return true;
        }

        public override void DisplayAccount()
        {

            string fee = "$" + TransactionFee;
            string balance = "$" + Balance;

            DrawLine();
            Console.WriteLine($"│ {"CHECKING ACCOUNT",45}  {"│",33}");
            DrawLine();
            Console.WriteLine($"│ {"Account Number",-25} │ {AccNumber,50} │");
            Console.WriteLine($"│ {"Balance Ammount",-25} │ {balance,50} │");
            Console.WriteLine($"│ {"Last Name",-25} │ {LastName,-50} │");
            Console.WriteLine($"│ {"First Name",-25} │ {FirstName,-50} │");
            Console.WriteLine($"│ {"Transaction Fee",-25} │ {fee,50} │");
            DrawLine();
        }
    }
}
