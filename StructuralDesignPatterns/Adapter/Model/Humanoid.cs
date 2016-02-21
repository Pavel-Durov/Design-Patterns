using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    public class Humanoid 
    {
        public Humanoid(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }

        public void GoHome()
        {
            Console.WriteLine("I don't have a dock station cause I'm special");
        }

        public void SayHelloTo(string name)
        {
            Console.WriteLine($"Hello my nae is {Name}, what's yours?");
        }

        public void Turn()
        {
            Console.WriteLine("Don't tell me what to do");
        }

        public void Advance()
        {
            Console.WriteLine("I ahve my own will");
        }
    }
}
