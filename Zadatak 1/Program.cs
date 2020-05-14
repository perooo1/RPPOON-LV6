using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Test title1", "test,test!"));
            notebook.AddNote(new Note("Test title2", "test,test!"));
            notebook.AddNote(new Note("Test title3", "test,test!"));

            IAbstractIterator iterator = notebook.GetIterator();

            for (Note note=iterator.First() ; iterator.IsDone==false ; note=iterator.Next())
            {
                note.Show();
            }
            
        }
    }
}
