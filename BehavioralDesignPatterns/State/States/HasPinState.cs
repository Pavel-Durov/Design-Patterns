using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.State.Model;

namespace BehavioralDesignPatterns.State.States
{
    class HasPinState : AtmMachineState
    {
        public HasPinState(AtmMachine context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Ejecting the card");
            _context.SetState(new NoCardState(_context));
        }

        public override void EnterPinCode(int pinCode)
        {
            Console.WriteLine("ERROR - I have a pin already");
        }

        public override void InsertCard()
        {
            Console.WriteLine("Cannot have multiple cards...");
        }

        public override void RequestCash(int amount)
        {
            if (_context.Balance - amount > 0)
            {
                Console.WriteLine($"Got cash... Ejecting {amount}$");
                _context.Balance -= amount;
            }
            else
            {
                Console.WriteLine($"Cannot perform the request of {amount}");
            }
            Console.WriteLine($" Current balance : {_context.Balance}");

        
        }
    }
}
