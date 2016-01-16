using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer.Interfaces
{
    interface IObserver
    {
        void Update(double UsaPrice, double IsraelPrice);
    }
}
