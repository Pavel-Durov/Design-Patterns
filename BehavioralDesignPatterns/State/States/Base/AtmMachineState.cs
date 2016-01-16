using BehavioralDesignPatterns.State.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State.States.Base
{
    abstract class AtmMachineState
    {
        public AtmMachineState(AtmMachine context)
        {
            _context = context;
        }

        protected AtmMachine _context;

        public abstract void InsertCard();
        public abstract void RequestCash(int amount);
        public abstract void EjectCard();
        public abstract void EnterPinCode(int pinCode);

    }
}
