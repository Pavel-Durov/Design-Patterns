using BehavioralDesignPatterns.Strategy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.Strategies
{
    class CanFly : IFly
    {
        public string Fly()
        {
            return "I can and I am flying!";
        }
    }
}
