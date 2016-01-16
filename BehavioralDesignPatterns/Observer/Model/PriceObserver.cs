using BehavioralDesignPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer.Model
{
    class PriceObserver : ISubject
    {
        public PriceObserver()
        {
            Observers = new List<IObserver>();
        }

        double _usaPrice;
        public double UsaPrice
        {
            get
            {
                return _usaPrice;
            }
            set
            {
                _usaPrice = value;
                Notify();
            }
        }
        double _israelPrice;
        public double IsraelPrice
        {
            get
            {
                return _israelPrice;
            }
            set
            {
                _israelPrice = value;
                Notify();
            }
        }

        private List<IObserver> Observers;

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update(UsaPrice, IsraelPrice);
            }
        }

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            Observers.Remove(observer);

        }
    }
}
