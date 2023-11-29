using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_BankLibrary
{
    public abstract class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract string Deposit(int amount);
        public string Withdrawl(int amount)
        {
            string res = null;
            if (balance > amount)
            {
                res = "Insuffient found.cannot withdrawl money! ";
            }
            else
            {
                res = "Amount withdrawl successfully, blance is " + balance.ToString();
            }
            return res;
        }
        public string Showbalance()
        {
            return "Balnce amount is : " + balance.ToString();
        }
    }
    public class Saving : Account
    {
        public override string Deposit(int amount)
        {
            int intrest = 300;
            balance = balance+ amount+intrest;
            return "Amount deposited successfully,balance is : "+ balance.ToString();
        }
    }
    public class Current : Account
    {
        public override string Deposit(int amount)
        {
            balance = balance+ amount;
            return "Amount deposited successfully balance is :  "+ balance.ToString();
        }
    }
}
