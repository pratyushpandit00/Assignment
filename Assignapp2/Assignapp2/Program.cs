using System;
using System.Collections.Generic;
using System.Text;

namespace Assignapp2
{
    class Account
    {
        long AccNo;
        double bal;
        string[] payees;
        long[] payeesAccount;

        public Account(long AccNo, double bal)
        {
            this.AccNo = AccNo;
            this.bal = bal;
        }

        public Account(long AccNo, double bal, string[] payees, long[] payeesAccount)
        {
            this.AccNo = AccNo;
            this.bal = bal;
            this.payees = payees;
            this.payeesAccount = payeesAccount;
        }

        public bool DebitAmount(double Amount)
        {
            if (Amount <= this.bal)
            {
                this.bal = this.bal - Amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferMoney(long payeesAcc, double amount)
        {
            foreach (var item in payeesAccount)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }

        public bool TransferMoney(string payees, double amount)
        {
            foreach (var item in payees)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }
    
        static void Main(string[] args)

        {
            long accNo = 110;
            double bal = 1200;
            string[] payees = { "Dinesh", "lokki" };
            long[] payeesAcc = { 110, 200 };

            Account account = new Account(accNo, bal);
            new Account(accNo, bal, payees, payeesAcc);
            account.TransferMoney(accNo, 6000);
            account.TransferMoney("Dinesh", 100);

            
        }


        }
}
