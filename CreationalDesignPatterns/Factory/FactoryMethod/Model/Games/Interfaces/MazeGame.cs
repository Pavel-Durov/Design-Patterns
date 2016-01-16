using CreationalDesignPatterns.Factory.FactoryMethod.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod
{
    interface MazeGame
    {
        Room MakeRoom();
    }
}
