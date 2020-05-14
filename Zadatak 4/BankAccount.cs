using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAdress;

        private decimal balance;

        public BankAccount(string ownerName, string ownerAdress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAdress = ownerAdress;
            this.balance = balance;             //in HRK
        }

        public void ChangeOwnerAdress(string adress)
        {
            this.ownerAdress = adress;
        }

        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAdress{ get { return this.ownerAdress; } }
        public decimal Balance { get { return this.balance; } }

        public Memento StoreState()
        {
            return new Memento(this.ownerName, this.OwnerAdress,this.balance);
        }

        public void RestoreState(Memento previous)
        {
            this.ownerName = previous.OwnerName;
            this.ownerAdress = previous.OwnerAdress;
            this.balance = previous.Balance;
        }


        public override string ToString()
        {
            return "Owner: " + this.ownerName + "\nAdress: " + this.OwnerAdress + "\nBalance: " + this.balance + "\n";
        }

    }

}
