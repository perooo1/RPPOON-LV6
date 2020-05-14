using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    class CareTaker
    {
        private List<Memento> PreviousState = new List<Memento>();
        
        public Memento GetState(int index)
        {
            return PreviousState[index];
        }

        public void AddState(Memento state)
        {
            PreviousState.Add(state);
        }

        public Memento GetLastState()
        {
            return PreviousState[(PreviousState.Count)-1];
        }

        public Memento GetFirstState()
        {
            return PreviousState[0];
        }
        
    }
}
