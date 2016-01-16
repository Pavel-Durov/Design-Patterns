using CreationalDesignPatterns.Factory.FactoryMethod.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod
{
    class MagicMazeGame : MazeGame
    {
        public MagicMazeGame()
        {
            Console.WriteLine("Magic Game Mode Set");
        }
        
        public Room MakeRoom()
        {
            return new MagicRoom();
        }
    }
}
