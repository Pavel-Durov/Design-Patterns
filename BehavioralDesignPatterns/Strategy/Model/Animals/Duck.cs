using BehavioralDesignPatterns.Strategy.Model.Animals.Base;
using BehavioralDesignPatterns.Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.Model.Animals
{
    class Duck : Animal
    {
        public Duck(double wight) : base(wight, "Small fish and fish eggs", "Cwack", new CanFly())
        {
        }

        public override void Sleep()
        {
            Sound = "ZZZZZZ";
            Console.WriteLine($"Duck {Sound}");
        }

        public override void WakeUp()
        {
            Sound = "Cwack";
            Console.WriteLine("Duck is waked up");
        }
    }
}
