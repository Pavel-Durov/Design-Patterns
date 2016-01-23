using CreationalDesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Model
{
    class RobotEngineer
    {
        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        private IRobotBuilder _robotBuilder;

        public Robot ReadyRobot
        {
            get
            {
                MakeRobot();

                return _robotBuilder.Robot;
            }
        }

        private void MakeRobot()
        {
            _robotBuilder.BuildRobotArms();
            _robotBuilder.BuildRobotHead();
            _robotBuilder.BuildRobotLegs();
            _robotBuilder.BuildRobotTorso();
        }
    }
}
