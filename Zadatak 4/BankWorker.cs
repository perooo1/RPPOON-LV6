using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class BankWorker
    {
        private List<Memento> previousState = new List<Memento>();

        public Memento GetState(int index)
        {
            return previousState[index];
        }

        public void AddState(Memento state)
        {
            previousState.Add(state);
        }

        public Memento GetLastState()
        {
            return previousState[(previousState.Count) - 1];
        }

        public Memento GetFirstState()
        {
            return previousState[0];
        }
    }
}
