﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Interface
{
    class OverdraftAcc:IBasicBanking
    {
        public int balance  { get; set; }
        public readonly int limit = 500;

        public OverdraftAcc()
        {

        }

        

        public bool Deposite(int amount)
        {
            balance += amount; 
            Console.WriteLine("New balance after deposite is:" + balance);
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= (balance + limit))
            {

                balance -= amount;
                Console.WriteLine("New balance after withdraw is:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
            return true;
        }
    }
}
