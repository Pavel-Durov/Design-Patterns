using CreationalDesignPatterns.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Builder.Model.RobotParts;

namespace CreationalDesignPatterns.Builder.Model
{
    class Robot : IRobotPlan
    {
        public RobotArm LeftArm { get; private set; }
        public RobotArm RightArm { get; private set; }
        public RobotHead Head { get; private set; }
        public RobotLeg LeftLeg { get; private set; }
        public RobotLeg RightLeg { get; private set; }
        public RobotTorso Torso { get; private set; }

        public void SetRobotArms(RobotArm leftArm, RobotArm rightArm)
        {
            LeftArm = leftArm;
            RightArm = rightArm;
        }

        public void SetRobotHead(RobotHead head)
        {
            Head = head;
        }

        public void SetRobotLegs(RobotLeg leftLeg, RobotLeg rightLeg)
        {
            LeftLeg = leftLeg;
            RightLeg = rightLeg;
        }

        public void SetRobotTorso(RobotTorso torso)
        {
            Torso = torso;
        }
    }
}
