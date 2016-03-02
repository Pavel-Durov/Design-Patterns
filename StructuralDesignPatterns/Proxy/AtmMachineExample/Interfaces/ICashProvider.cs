using BehavioralDesignPatterns.State.States.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.Interfaces
{
    interface ICashProvider
    {
        void InsertCard();
        void RequestCash(int amount);
        void EjectCard();
        void EnterPinCode(int pinCode);
    }
}
