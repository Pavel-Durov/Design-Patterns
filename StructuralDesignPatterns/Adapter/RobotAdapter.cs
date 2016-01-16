using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    class RobotAdapter : IRobot
    {
        
        public RobotAdapter(IRobot robot)
        {
            _robot = robot;
        }

        IRobot _robot;

        private RoombaRobot robot;

        public void WalkForward()
        {
            _robot.WalkForward();
        }

        public void GoToDock()
        {
            _robot.GoToDock();
        }

        
        public void TurnLeft()
        {
            _robot.TurnLeft();
        }

        public void ReactToHuman(string name)
        {
            _robot.ReactToHuman(name);
        }
    }
}
