using CreationalDesignPatterns.Factory.FactoryMethod.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory.FactoryMethod.Model
{
    class GameEngine
    {
        public GameEngine(MazeGame gameMode)
        {
            _gameMode = gameMode;
            Room = new List<Rooms.Room>();
        }

        MazeGame _gameMode;
        public List<Room> Room { get; set; }
        public void Start()
        {
            GenerateRooms();
        }


        public void Switch(MazeGame anotherMode)
        {
            _gameMode = anotherMode;
            Room.Clear();
            GenerateRooms();
        }

        private void GenerateRooms()
        {
            for (int i = 0; i < 10; i++)
            {
                Room.Add(_gameMode.MakeRoom());
            }

            Console.WriteLine("Game's on");
        }
    }
}
