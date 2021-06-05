using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            string input, input2, nam, num, balance0, checkbrk0, account_number, dob0, add, ammount0, reciver_number;
            int j = 0, balance1 = 0, typ = 0, m = 0, ran = 1000, ammount1;


            Bank bank = new Bank(3);
            Console.WriteLine("**Welcome to Bank**");

        page1:
            Console.WriteLine();
            Console.WriteLine("Welcome to our Services:\n Write 'open' for new account\n Write 'account' for existing account information\n quit");
            Console.WriteLine();
            Console.WriteLine("Enter your service:");
            input = Console.ReadLine();

            switch (input)
            {
                case "open":
                    {
                        Console.WriteLine();
                        Console.WriteLine(" savings\n checking\n quit");
                        Console.WriteLine();
                        Console.WriteLine("enter your service:");
                        input2 = Console.ReadLine();


                        if (input2 == "quit")
                        {
                            goto page1;
                        }
                        else if (input2 == "savings" || input2 == "checking")
                        {


                            Console.Write("Enter your name:");
                            nam = Console.ReadLine();

                            Console.WriteLine();

                            Console.Write("Enter your Date of birth:");
                            dob0 = Console.ReadLine();



                            Console.WriteLine();
                            Console.WriteLine("Enter your address:");
                            add = Console.ReadLine();



                            ran++;
                            num = ran.ToString();

                            Console.WriteLine();

                            Console.Write("Enter 1st Entry balance:");
                            balance0 = Console.ReadLine();
                            balance1 = Convert.ToInt32(balance0);

                            if (input2 == "savings")
                            {
                                Savingsaccount acc = new Savingsaccount(500);
                                acc.Accountname = nam;
                                acc.Date = dob0;
                                acc.Address = add;
                                acc.Accountnumber = num;
                                acc.Balance = +balance1;
                                bank.CreateAccount(acc);
                                goto page1;
                            }
                            else if (input2 == "checking")
                            {
                                Checkingaccount ac = new Checkingaccount();
                                ac.Accountname = nam;
                                ac.Date = dob0;
                                ac.Address = add;
                                ac.Accountnumber = num;
                                ac.Balance = +balance1;
                                bank.CreateAccount(ac);
                                goto page1;
                            }



                        }
                        else
                        {
                            break;
                        }
                        goto page1;
                        break;

                    }
                case "account":
                    {
                        Console.Write("Enter your Account Number:");
                        account_number = Console.ReadLine();

                    page2:



                        Console.WriteLine();

                        Console.WriteLine(" deposit\n withdraw\n transfer\n change\n show\n quit");
                        Console.WriteLine();
                        Console.WriteLine("enter your command :");
                        checkbrk0 = Console.ReadLine();
                        Console.WriteLine();
                        switch (checkbrk0)
                        {



                            case "quit":
                                break;

                            case "deposit":
                                Console.WriteLine("Enter your ammount");
                                ammount0 = Console.ReadLine();
                                ammount1 = Convert.ToInt32(ammount0);
                                bank.Accdeposit(account_number, ammount1);
                                goto page2;

                            case "withdraw":
                                Console.WriteLine("Enter your ammount");
                                ammount0 = Console.ReadLine();
                                ammount1 = Convert.ToInt32(ammount0);
                                bank.Accwithdraw(account_number, ammount1);
                                goto page2;


                            case "transfer":
                                Console.WriteLine("Enter receiver account number:");
                                reciver_number = Console.ReadLine();
                                Console.WriteLine("Enter your ammount");
                                ammount0 = Console.ReadLine();
                                ammount1 = Convert.ToInt32(ammount0);
                                bank.Acctransfer(account_number, reciver_number, ammount1);
                                goto page2;


                            case "change":
                                Console.WriteLine("Enter account name:");
                                reciver_number = Console.ReadLine();
                                bank.Accname(account_number, reciver_number);
                                goto page2;



                            case "show":
                                bank.Accshow(account_number);
                                goto page2;
                            default:
                                break;

                        }
                    }
                    goto page1;
                    break;
                case "quit":
                    break;





            }
        }



    }
}



