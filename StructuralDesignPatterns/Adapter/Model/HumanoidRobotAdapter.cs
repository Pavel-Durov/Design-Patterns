using StructuralDesignPatterns.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Adapter.Model
{
    class HumanoidRobotAdapter : IRobot
    {
        public HumanoidRobotAdapter(Humanoid robot)
        {
            _robot = robot;
        }
        Humanoid _robot;

        public void GoToDock()
        {
            _robot.GoHome();
        }

        public void ReactToHuman(string name)
        {
            _robot.SayHelloTo(name);
        }

        public void TurnLeft()
        {
            _robot.Turn();
        }

        public void WalkForward()
        {
            _robot.Advance();
        }
    }
}
