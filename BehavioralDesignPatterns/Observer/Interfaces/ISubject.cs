using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer.Interfaces
{
    interface ISubject
    {
        double UsaPrice { get; set; }
        double IsraelPrice { get; set; }

        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }
}
