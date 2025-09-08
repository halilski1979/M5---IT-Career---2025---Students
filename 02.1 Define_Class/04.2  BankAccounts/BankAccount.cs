using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2__BankAccounts
{
    public class BankAccount
    {
       

        public int ID { get;private set; }
        public double Balance { get;private set; }


        public BankAccount(int iD, double balance)
        {
            ID = iD;
            Balance = balance;
        }


        public override string ToString()
        {
            return $"ID:{this.ID} => {this.Balance} lv.";
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new ArgumentException("Error. Balance<Amout to withdraw");
            }
            Balance -= amount;
        }
    }
}
