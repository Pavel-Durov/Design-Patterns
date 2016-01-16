using BehavioralDesignPatterns.Observer.Model;
using BehavioralDesignPatterns.Observer.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Observer
{
    class Test
    {
        public static void Run()
        {
            PriceObserver observer = new PriceObserver();

            PriceGrabber grabber= new PriceGrabber(observer, 5, 4);

            observer.IsraelPrice = 56;
            observer.UsaPrice = 90;

            
            observer.UnRegister(grabber);


            observer.IsraelPrice = 89;
            observer.UsaPrice = 70;
        }
    }
}
