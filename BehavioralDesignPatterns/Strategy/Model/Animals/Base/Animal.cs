using BehavioralDesignPatterns.Strategy.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.Model.Animals.Base
{
    public abstract class Animal
    {
        public Animal(double wight, string favoriteFood, string sound, IFly type)
        {
            Sound = sound;
            Weight = Weight;
            FavoriteFood = favoriteFood;
            FlyingStrategy = type;
        }

        public IFly FlyingStrategy{ get; private set; }
        public int Weight { get; private set; }
        public string Sound { get; protected set; }
        public string FavoriteFood { get; private set; }
      
        public string TryToFly()
        {
            return FlyingStrategy.Fly();
        }

        public virtual void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        public abstract void Sleep();

        public abstract void WakeUp();


    }
}
