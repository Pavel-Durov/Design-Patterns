using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    class Room
    {
        public Room()
        {
            ++_instanceCount;
        }

        protected static int _instanceCount;
    }
}
