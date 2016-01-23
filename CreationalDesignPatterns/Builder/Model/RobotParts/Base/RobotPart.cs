using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Builder.Model.RobotParts.Base
{
    abstract class RobotPart
    {
        public RobotPart(string type)
        {
            Console.WriteLine($"part of {type} was created");
        }
    }
}
