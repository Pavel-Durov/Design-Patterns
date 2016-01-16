using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    class Humanoid : IRobot
    {
        public Humanoid(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public void GoToDock()
        {
            Console.WriteLine("I don't have a dock station cause I'm special");
        }

        public void ReactToHuman(string name)
        {
            Console.WriteLine($"Hello my nae is {Name}, what's yours?");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"My name is {Name} and I am turning left");
        }

        public void WalkForward()
        {
            Console.WriteLine($"My name is {Name} and I am walking farward");
        }
    }
}
