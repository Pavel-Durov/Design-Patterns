using StructuralDesignPatterns.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter
{
    class Test
    {
        public static void Run()
        {
            RoombaRobot roomba = new RoombaRobot();
            Humanoid humanoidRobot = new Humanoid("Boris");


            RobotAdapter roombaAdapter = new RobotAdapter(roomba);

            roombaAdapter.TurnLeft();
            roombaAdapter.WalkForward();
            roombaAdapter.ReactToHuman("Shalom");
            roombaAdapter.GoToDock();

            Console.WriteLine("Roomba");

            RobotAdapter humanAdapter = new RobotAdapter(humanoidRobot);

            humanAdapter.TurnLeft();
            humanAdapter.WalkForward();
            humanAdapter.GoToDock();

            humanAdapter.ReactToHuman("Pavel");
        }
    }
}
