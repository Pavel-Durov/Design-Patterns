using CreationalDesignPatterns.Builder.Model.RobotParts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Model.RobotParts
{
    class RobotLeg : RobotPart
    {
        public RobotLeg(string type) : base($"Robot Leg - {type}")
        {

        }
    }
}
