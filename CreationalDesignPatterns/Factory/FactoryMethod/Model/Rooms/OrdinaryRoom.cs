using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    class OrdinaryRoom : Room
    {
        public OrdinaryRoom()
        {
            Console.WriteLine($"ORDINARY ROOM CREATED i = {_instanceCount}");
        }
    }
}
