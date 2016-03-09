
namespace HomeWork.Characters
{
    public enum AngleDirection
    {
        North = 0,
        East = 90,
        South= 180,
        West = 270
    }

    public abstract class GameCharacter
    {
        public GameCharacter(double startXCoordinate, double startYCoordinate, double step = 1, double damage = 2)
        {
            this.X = startXCoordinate;
            this.Y = startYCoordinate;
            Step = step;
            Damage = damage;
            Direction = 0;
            IsAlive = true;
        }
        /// <summary>
        /// X coorinate of our 2D world
        /// </summary>
        public double X { get; private set; }
        /// <summary>
        /// Y coorinate of the 2D world
        /// </summary>
        public double Y { get; private set; }
        /// <summary>
        /// Moovement step
        /// </summary>
        public readonly double Step;
        /// <summary>
        /// Character damage amount
        /// </summary>
        public readonly double Damage;
        /// <summary>
        /// Current direction of the enemy (in our 2D world)
        /// </summary>
        public AngleDirection Direction { get; set; }
        /// <summary>
        /// Life of the character
        /// </summary>
        public double Life { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsAlive { get; set; }

        public abstract void Death();

        public virtual void MoveForward()
        {
            //TODO: Calculate new position
            //Reminder: Virtual methods can be overriden in the derived class
        }

        public virtual void TurnLeft()
        {
            //TODO: Calculate angle
            //Reminder: Virtual methods can be overriden in the derived class
        }

        public virtual void TurnRight()
        {
            //TODO: Calculate angle
            //Reminder: Virtual methods can be overriden in the derived class
        }

        public virtual void Hit(double charecterDamage)
        {
            //Reminder: Virtual methods can be overriden in the derived class
            this.Life -= charecterDamage;

            if(Life <= 0)
            {
                IsAlive = false;
                Death();
            }
        }
    }
}
