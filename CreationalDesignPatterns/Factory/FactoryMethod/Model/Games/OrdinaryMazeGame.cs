using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Factory.FactoryMethod.Rooms;

namespace CreationalDesignPatterns.Factory.FactoryMethod
{
    class OrdinaryMazeGame : MazeGame
    {
        public OrdinaryMazeGame()
        {
            Console.WriteLine("Ordinary Game Mode Set");
        }
        public Room MakeRoom()
        {
            return new OrdinaryRoom();
        }
    }
}
