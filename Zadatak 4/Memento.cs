using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAdress { get; private set; }
        public decimal Balance { get; private set; }

        public Memento(string ownerName, string ownerAdress,decimal balance)
        {
            OwnerName = ownerName;
            OwnerAdress = ownerAdress;
            Balance = balance;
        }
    }
}
