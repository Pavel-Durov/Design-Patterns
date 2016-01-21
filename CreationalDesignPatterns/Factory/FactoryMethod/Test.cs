
using CreationalDesignPatterns.Factory.FactoryMethod.Model;
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
            var ordinaryGame = new OrdinaryMazeGame();
            GameEngine engine = new GameEngine(ordinaryGame);

            engine.Start();
            var magicMazeGame = new MagicMazeGame();

            engine.Switch(magicMazeGame);
            
            Console.WriteLine("Game's on");
        }
        



    }
}
