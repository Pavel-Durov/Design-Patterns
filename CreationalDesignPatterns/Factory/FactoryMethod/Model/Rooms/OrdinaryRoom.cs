using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    class OrdinaryRoom : Room
    {
        public OrdinaryRoom(double width, double height, double x, double y) : base(width, height, x, y)
        {
            Console.WriteLine($"ORDINARY ROOM CREATED i = {_instanceCount}");
        }
    }
}
