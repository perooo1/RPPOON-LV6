using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Sheev Palpatine", "Osijek", 10000);
            BankAccount account2 = new BankAccount("Lucas Skywalker", "Donje Predrijevo", 9999);
            BankAccount account3 = new BankAccount("Xenophilius Lovegood", "London", 1500);

            BankWorker employee = new BankWorker();

            employee.AddState(account1.StoreState());
            employee.AddState(account2.StoreState());
            employee.AddState(account3.StoreState());

            Console.WriteLine("After storing:");
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

            Console.WriteLine("\nAfter restoring:");
            account3.RestoreState(employee.GetFirstState());
            account2.RestoreState(employee.GetState(1));
            account1.RestoreState(employee.GetLastState());

            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);

        }
    }
}
