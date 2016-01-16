using BehavioralDesignPatterns.Strategy.Model.Interfaces;

namespace BehavioralDesignPatterns.Strategy.Strategies
{
    class CannotFly : IFly
    {
        public string Fly()
        {
            return "Sorry, cannot fly..";
        }
    }
}
