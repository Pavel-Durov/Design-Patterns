using BehavioralDesignPatterns.State.Model;
using StructuralDesignPatterns.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BehavioralDesignPatterns.State.States.Base;

namespace StructuralDesignPatterns.Proxy.Model
{
    class AtmMachineProxy : ICashProvider
    {
        public AtmMachineProxy()
        {
            _machine = new AtmMachine(1000);
        }

        AtmMachine _machine;

        public void InsertCard()
        {
            _machine.InsertCard();
        }

        public void RequestCash(int amount)
        {
            _machine.RequestCash(amount);
        }

        public void EjectCard()
        {
            _machine.EjectCard();
        }

        public void EnterPinCode(int pinCode)
        {
            _machine.EnterPinCode(pinCode);
        }
    }
}
