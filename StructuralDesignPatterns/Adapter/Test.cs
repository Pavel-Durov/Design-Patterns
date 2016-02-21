using StructuralDesignPatterns.Adapter.Adapters;
using StructuralDesignPatterns.Adapter.Interfaces;
using StructuralDesignPatterns.Adapter.Model;
using StructuralDesignPatterns.Adapters;
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
            IRobot adapter = new HumanoidRobotAdapter(new Humanoid("BORIS"));


            IRobot adapter2 = new RoombaRobotAdapter(new RoombaRobot());

            SomeFunctionThatAcceptsRobot(adapter);
            Console.WriteLine(" ~~~~ ");
            SomeFunctionThatAcceptsRobot(adapter2);

        }

        private static void SomeFunctionThatAcceptsRobot(IRobot robot)
        {
            robot.ReactToHuman("Pavel");
            robot.TurnLeft();
            robot.GoToDock();
            
        }
    }
}
