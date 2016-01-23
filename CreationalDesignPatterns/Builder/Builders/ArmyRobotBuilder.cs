using CreationalDesignPatterns.Builder.Interfaces;
using CreationalDesignPatterns.Builder.Model;
using CreationalDesignPatterns.Builder.Model.RobotParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Builders
{
    class ArmyRobotBuilder : IRobotBuilder
    {
        public ArmyRobotBuilder()
        {
            _robot = new Robot();
        }

        public Robot _robot;

        public Robot Robot
        {
            get
            {
                return _robot;
            }
        }

        public void BuildRobotArms()
        {
            var left = new RobotArm("ArmyRobot - Left");
            var right = new RobotArm("ArmyRobot - Right");

            _robot.SetRobotArms(left, right);
        }

        public void BuildRobotHead()
        {
            _robot.SetRobotHead(new RobotHead("ArmyRobot"));
        }

        public void BuildRobotLegs()
        {
            var left = new RobotLeg("ArmyRobot - Left");
            var right = new RobotLeg("ArmyRobot - Right");

            _robot.SetRobotLegs(left, right);
        }

        public void BuildRobotTorso()
        {
            _robot.SetRobotTorso(new RobotTorso("ArmyRobot"));
        }

        public Robot Build()
        {
            return _robot;
        }
    }
}
