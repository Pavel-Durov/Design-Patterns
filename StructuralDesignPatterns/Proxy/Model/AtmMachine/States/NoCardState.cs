using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.State.Model;

namespace BehavioralDesignPatterns.State.States
{
    class NoCardState : AtmMachineState
    {
        public NoCardState(AtmMachine context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Please enter a card first");
        }

        public override void EnterPinCode(int pinCode)
        {
            Console.WriteLine("Enter a card first");
        }

        public override void InsertCard()
        {
            Console.WriteLine("Card accepted");
            _context.SetState(new HasCardState(_context));
        }

        public override void RequestCash(int amount)
        {
            Console.WriteLine("Enter a card first");
        }
    }
}
