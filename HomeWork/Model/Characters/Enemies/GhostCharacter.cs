

using System;

namespace HomeWork.Characters.Enemies
{
    class GhostCharacter : GameCharacter
    {
        public GhostCharacter(double startXCoordinate, double startYCoordinate, double step = 1, double damage = 2) : base(startXCoordinate, startYCoordinate, step, damage)
        {
        }


        public override void Death()
        {
            //TODO: Implement death logic
        }

        //TODO: Your logic here
    }
}
