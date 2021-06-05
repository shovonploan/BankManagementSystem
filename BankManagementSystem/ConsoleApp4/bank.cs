using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Bank
    {
        public int count = 0;


        Account[] accounts;
        public Bank(int size)
        {
            this.accounts = new Account[size];

        }







        public void CreateAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("\nYour account created successfully");
                    Console.WriteLine("your account number is:" + accounts[i].Accountnumber);
                    count++;
                    break;
                }
            }
        }


        public void PrintAccount(string accountNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accountNumber)
                {
                    accounts[i].PrintAccountDetails();
                    break;

                }

            }

        }
        public void Accdeposit(string accno, double ammount)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Deposit(ammount);
                    break;
                }
            }
        }
        public void Accwithdraw(string accno, double ammount)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Withdraw(ammount);
                    break;
                }
            }
        }
        public void Acctransfer(string accno, string accno2, double ammount)
        {
            int a = 0, b = 0;
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    a = i;
                    break;
                }
            }
            //   PrintAccount(accounts[i].Accountnumber);
            for (int j = 0; j < count; j++)
            {
                if (accounts[j].Accountnumber == accno2)
                {

                    b = j;

                    break;
                }
            }
            accounts[a].Transfer(accounts[b], ammount);


        }



        public void Accname(string accno, string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    accounts[i].Accountname = name;
                    break;
                }
            }
        }
        public void Accshow(string accno)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accno)
                {
                    PrintAccount(accounts[i].Accountnumber);
                    Console.WriteLine("Number of Transaction is :" + accounts[i].AccountTransaction);

                    break;
                }
            }
        }




    }
}
