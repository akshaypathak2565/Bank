using System;

namespace ProgChallenge
{
    public class BankAccount {
        private string firstname;
        private string lastname;

        public decimal Balance {
            get; set;
        }

        public BankAccount(string fname, string lname, decimal initial=0.0m) {
            firstname = fname;
            lastname = lname;
            Balance = initial;
        }

        public string AccountOwner {
            get => $"{firstname} {lastname}";
        }

        public virtual void Deposit(decimal amount) {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }
}
