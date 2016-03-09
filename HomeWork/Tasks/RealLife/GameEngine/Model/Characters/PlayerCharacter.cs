using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Characters
{
    class PlayerCharacter : GameCharacter
    {
        public PlayerCharacter(double startXCoordinate, double startYCoordinate, double step = 1, double damage = 2) 
            : base(startXCoordinate, startYCoordinate, step, damage)
        {
        }

        public override void Death()
        {
            //TODO: Implement death logic
        }

        /// <summary>
        /// That's a special feature of our Player: 
        /// </summary>
        /// <param name="x">teleport x coordinate destination</param>
        /// <param name="y">teleport y coordinate destination</param>
        public void Teleport(double x, double y) 
        {
            //TODO: teleport implementation
        }

        
    }
}
