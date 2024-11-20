 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 
 namespace Project.src.OopPrinciples.Encapsulation
 {
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposit Amount should be positive");
            }

            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Withdraw amount should be positive");
            }

            if(amount > balance){
                throw new ArgumentException("Insufficient funds");
            }

            this.balance -= amount;
        }
    }
 }
