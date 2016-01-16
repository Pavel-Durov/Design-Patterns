using BehavioralDesignPatterns.State.States;
using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State.Model
{
    class AtmMachine
    {
        public AtmMachine(double balance)
        {
            Balance = balance;
            CurrentState = new NoCardState(this);
        }

        public double Balance { get; set; }

        public AtmMachineState CurrentState { get; private set; }

        public void SetState(AtmMachineState state)
        {
            CurrentState = state;
        }

        public void InsertCard()
        {
            CurrentState.InsertCard();
        }
        public void RequestCash(int amount)
        {
            CurrentState.RequestCash(amount);
        }
        public void EjectCard()
        {
            CurrentState.EjectCard();
        }
        public void EnterPinCode(int pinCode)
        {
            CurrentState.EnterPinCode(pinCode);
        }

    }
}
