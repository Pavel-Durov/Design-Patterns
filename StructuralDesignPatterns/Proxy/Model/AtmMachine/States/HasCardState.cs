using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.State.Model;

namespace BehavioralDesignPatterns.State.States
{
    class HasCardState : AtmMachineState
    {
        public HasCardState(AtmMachine context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Ejecting Card");
            _context.SetState(new NoCardState(_context));
        }

        public override void EnterPinCode(int pinCode)
        {
            if (pinCode == 123)
            {
                Console.WriteLine("Correct PIN");
                _context.SetState(new HasPinState(_context));
            }
            else
            {
                Console.WriteLine("Wrong pin - try again");
            }
        }

        public override void InsertCard()
        {
            Console.WriteLine("Cannot accept multiple cards at the same time..");
        }

        public override void RequestCash(int amount)
        {
            Console.WriteLine("Please enter PIN first");
        }
    }
}
