using BehavioralDesignPatterns.Strategy.Model.Animals;
using BehavioralDesignPatterns.Strategy.Model.Animals.Base;
using System;

namespace BehavioralDesignPatterns.Strategy.AnimalsExample
{
    class Test
    {
        public static void Run()
        {
            Animal cow = new Cow(80);
            Animal bear = new Bear(80);
            Animal duck = new Duck(100);

            Console.WriteLine(cow.Sound);
            Console.WriteLine(cow.TryToFly());

            Console.WriteLine(bear.Sound);
            Console.WriteLine(bear.TryToFly());

            Console.WriteLine(duck.Sound);
            Console.WriteLine(duck.TryToFly());

        }
    }
}
