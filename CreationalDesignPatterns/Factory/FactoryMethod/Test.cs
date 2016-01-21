
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

            Console.WriteLine("Game's on");

            engine.Start();
            var magicMazeGame = new MagicMazeGame();

            Console.WriteLine("SWITCHING TO MAGIC MODE");
            engine.Switch(magicMazeGame);   
        }
    }
}
