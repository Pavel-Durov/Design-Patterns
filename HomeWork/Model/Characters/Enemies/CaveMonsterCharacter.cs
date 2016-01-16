

namespace HomeWork.Characters.Enemies
{
    class CaveMonsterCharacter : GameCharacter
    {
        public CaveMonsterCharacter(double startXCoordinate, double startYCoordinate, double step = 1, double damage = 2) 
            : base(startXCoordinate, startYCoordinate, step, damage)
        {
        }

        //TODO: Make your implementation
        //Reminder: Virtual methods can be overriden in the derived class



        public override void Death()
        {
            //TODO: Implement death logic
        }
    }
}
