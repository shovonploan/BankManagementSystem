using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    class Checkingaccount : Account
    {
        private String checking;

        public string checkingAccount
        {
            set { this.checking = value; }
            get { return this.checking; }
        }

    }
}
