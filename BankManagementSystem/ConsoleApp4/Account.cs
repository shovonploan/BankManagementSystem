using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Account
    {
        protected String accountname, date, address, accountnumber;
        protected double balance;
        protected int transaction = 0;

        public string Accountname
        {
            set { this.accountname = value; }
            get { return this.accountname; }
        }
        public string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public string Accountnumber
        {
            set { this.accountnumber = value; }
            get { return this.accountnumber; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public int AccountTransaction
        {

            get { return this.transaction; }
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= this.balance)
            {
                this.balance -= amount;//this.balance=this.balance-amount
                this.transaction++;
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;//this.balance=this.balance+amount
                this.transaction++;
            }
        }



        public void Transfer(Account receiver, double amount)
        {
            int a = this.transaction;
            this.Withdraw(amount);
            if (a != this.transaction)
            {
                receiver.Deposit(amount);
            }





        }



        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Name:{0}\nDate:{1}\nAddress:{2}\nAccount Number:{3}\nBalance:{4}", this.accountname, this.date, this.address, this.accountnumber, this.balance);
        }
    }




}


