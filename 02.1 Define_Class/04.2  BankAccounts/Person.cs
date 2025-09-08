using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2__BankAccounts
{
    public class Person
    {   

        public string Name { get;private set; }
        public int Age { get;private set; }

        public List<BankAccount> bankAccounts { get; set; }

        public Person(string name, int age, List<BankAccount> bankAccounts)
        {
            Name = name;
            Age = age;
            this.bankAccounts = bankAccounts;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public double GetBalance()
        {
            double totalSum = 0.0;
            foreach (BankAccount bankAccount in bankAccounts)
            {
                totalSum += bankAccount.Balance;
            }

            return totalSum;
        }


    }
}
