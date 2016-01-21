using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Rooms
{
    class MagicRoom : Room
    {
        public MagicRoom(double width, double height, double x, double y) : base(width, height, x, y)
        {

        }
    }
}
