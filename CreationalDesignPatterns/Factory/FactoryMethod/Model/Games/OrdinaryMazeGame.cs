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

        OrdinaryRoom _prevRoom;
        public Room MakeRoom()
        {
            OrdinaryRoom result = null;
            if (_prevRoom != null)
            {
                result = new OrdinaryRoom(result.Width, result.Height, result.X + 1, result.Y + 1);
                _prevRoom = result;
            }
            else {

                result = new OrdinaryRoom(100, 100, 0, 0);
            }
            return result;
        }
    }
}
