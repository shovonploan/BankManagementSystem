using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Savingsaccount : Account
    {
        public double minamount;



        public Savingsaccount(double a)
        {
            this.minamount = a;
        }



        public override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (this.minamount < base.balance - amount)
                {
                    base.balance -= amount;
                    base.PrintAccountDetails();
                    base.transaction++;
                }
                else
                {

                    Console.WriteLine("ERROR");
                    base.PrintAccountDetails();
                }
            }
        }

    }
}

