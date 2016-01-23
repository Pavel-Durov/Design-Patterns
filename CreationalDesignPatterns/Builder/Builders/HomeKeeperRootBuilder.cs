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
    class HomeKeeperRootBuilder : IRobotBuilder
    {
        public HomeKeeperRootBuilder()
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
            var left = new RobotArm("HomeKeeper - Left");
            var right = new RobotArm("HomeKeeper - Right");

            _robot.SetRobotArms(left, right);
        }

        public void BuildRobotHead()
        {
            _robot.SetRobotHead(new RobotHead("HomeKeeper"));
        }

        public void BuildRobotLegs()
        {
            var left = new RobotLeg("HomeKeeper - Left");
            var right = new RobotLeg("HomeKeeper - Right");

            _robot.SetRobotLegs(left, right);
        }

        public void BuildRobotTorso()
        {
            _robot.SetRobotTorso(new RobotTorso("HomeKeeper"));
        }

        
    }
}
