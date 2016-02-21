using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    class RoombaRobotAdapter : IRobot
    {
        
        public RoombaRobotAdapter(RoombaRobot robot)
        {
            _robot = robot;
        }

        private RoombaRobot _robot;

        public void GoToDock()
        {
            _robot.GoToSleep();
        }

        
        public void TurnLeft()
        {
            _robot.Turn();
        }

        public void ReactToHuman(string name)
        {
            _robot.DetectHuman(name);
        }

        public void WalkForward()
        {
            _robot.AdvanceForward();
        }
    }
}
