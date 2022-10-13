using System;
using bytebank.MainAccountHolder;

namespace bytebank
{
    public class CurrentAccount
    {
        public Customer accountHolder;
        public string account;
        public int branchNumber;
        public string branchName;
        public double balance;

        public bool Withdrawal(double value)
        {
            if(balance < value)
            {
                return false;
            }
            else
            {
                balance = balance - value;
                return true;
            }
        }

        public void Lodgement(double value)
        {
            balance = balance + value;
        }

        public bool Transfer(double value, CurrentAccount to)
        {
            if(value > balance)
            {
                return false;
            }
            else if (value == 0)
            {
                return false;
            }
            else
            {
                balance = balance - value;
                to.balance = to.balance + value;
                return true;
            }
        }
    }
}
