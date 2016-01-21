using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    abstract class Room
    {
        public Room(double width, double height, double x, double y)
        {
            Console.WriteLine($"MAGIC ROOM CREATED i = {_instanceCount}");
            X = x;
            Y = y;

            ++_instanceCount;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public double Width { get; private set; }
        public double Height { get; private set; }


        protected static int _instanceCount;
    }
}
