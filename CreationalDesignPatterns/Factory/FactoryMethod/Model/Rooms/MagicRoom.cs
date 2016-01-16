using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    class MagicRoom : Room
    {
        public MagicRoom()
        {
            Console.WriteLine($"MAGIC ROOM CREATED i = {_instanceCount}");
        }
    }
}
