using BehavioralDesignPatterns.Strategy.Model.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy
{
    class Test
    {
        public static void Run()
        {
            Cow cow = new Cow(80);
            Bear bear = new Bear(80);
            Duck duck = new Duck(100);

            Console.WriteLine(cow.TryToFly());
            Console.WriteLine(bear.TryToFly());
            Console.WriteLine(duck.TryToFly());
            
        }
    }
}
