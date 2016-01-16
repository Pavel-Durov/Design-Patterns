using BehavioralDesignPatterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer.Model.Products
{
    class PriceGrabber : IObserver
    {
        public PriceGrabber(ISubject subject, double usaPrice, double israelPrice)
        {
            _subject = subject;
            _subject.Register(this);
            USAPrice = usaPrice;
            IsraelPrice = israelPrice;
        }

        ISubject _subject;

        public double IsraelPrice { get; set; }
        public double USAPrice { get; set; }

        public void Update(double UsaPrice, double IsraelPrice)
        {
            this.IsraelPrice = IsraelPrice;
            this.USAPrice = USAPrice;
            Console.WriteLine($"New Prices : Israel - {IsraelPrice} , Usa - {USAPrice}");
        }
    }
}
