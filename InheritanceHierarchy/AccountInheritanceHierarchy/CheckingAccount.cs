﻿using System;
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
                if (transactionFee < 0)
                {
                    transactionFee = 1.50m;
                    return transactionFee;
                }
                else
                {
                    return transactionFee;
                }
            }

            set
            {
                transactionFee = value;
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
            DrawLine();
            Console.WriteLine($"│ {"SAVINGS ACCOUNT",45}  {"│",33}");
            DrawLine();
            Console.WriteLine($"│ {"Account Number",-25} │ {AccNumber,50} │");
            Console.WriteLine($"│ {"Balance Ammount",-25} │ {Balance,50} │");
            Console.WriteLine($"│ {"Last Name",-25} │ {LastName,-50} │");
            Console.WriteLine($"│ {"First Name",-25} │ {FirstName,-50} │");
            Console.WriteLine($"│ {"Transaction Fee",-25} │ {TransactionFee,50} │");
        }
    }
}
