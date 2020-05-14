using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoItem item1 = new ToDoItem("Title 1", "text 1", DateTime.Today.AddDays(3));
            ToDoItem item2 = new ToDoItem("Title 2", "text 2", DateTime.Today.AddDays(2));
            ToDoItem item3 = new ToDoItem("Title 3", "text 3", DateTime.Today.AddDays(1));

            CareTaker careTaker = new CareTaker();


            careTaker.AddState(item1.StoreState());
            careTaker.AddState(item2.StoreState());
            careTaker.AddState(item3.StoreState());

            Console.WriteLine("After storing:");
            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);

            Console.WriteLine("\nAfter resetoring:");
            item3.RestoreState(careTaker.GetFirstState());
            item2.RestoreState(careTaker.GetState(1));
            item1.RestoreState(careTaker.GetLastState());

            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
            
        }
    }
}
