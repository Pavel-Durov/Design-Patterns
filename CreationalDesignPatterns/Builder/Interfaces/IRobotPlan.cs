using CreationalDesignPatterns.Builder.Model.RobotParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Interfaces
{
    interface IRobotPlan
    {
        void SetRobotHead(RobotHead head);
        void SetRobotTorso(RobotTorso torso);
        void SetRobotArms(RobotArm leftArm, RobotArm rightArm);
        void SetRobotLegs(RobotLeg leftLeg, RobotLeg rightLeg);
    }
}
