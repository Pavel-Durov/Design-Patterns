
using CreationalDesignPatterns.Factory.FactoryMethod.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod
{
    class Test
    {
        public static void Run()
        {
            
            var game = new OrdinaryMazeGame();
            //var game = new MagicMazeGame();

            var rooms = new List<Room>();

            for (int i = 0; i < 10; i++)
            {
                rooms.Add(game.MakeRoom());
            }

            Console.WriteLine("Game's on");
        }



    }
}
