using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.State.Model;

namespace BehavioralDesignPatterns.State.States
{
    class NoCashState : AtmMachineState
    {
        public NoCashState(AtmMachine context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Ejecting the card");
            _context.SetState(new NoCardState(_context));    
        }

        public override void EnterPinCode(int pinCode)
        {
            Console.WriteLine("NO CASH!");
        }

        public override void InsertCard()
        {
            Console.WriteLine("NO CASH!");
        }

        public override void RequestCash(int amount)
        {
            Console.WriteLine("NO CASH!");
        }
    }
}
