using CreationalDesignPatterns.Builder.Builders;
using CreationalDesignPatterns.Builder.Interfaces;
using CreationalDesignPatterns.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder
{
    class Test
    {
        public static void Run()
        {
            IRobotBuilder armyBuilder = new ArmyRobotBuilder();
            IRobotBuilder homeKeeperBuilder = new HomeKeeperRootBuilder();

            RobotEngineer engineer = new RobotEngineer(homeKeeperBuilder);

            var robot = engineer.ReadyRobot;
        }
    }
}
