using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class GameManager
    {

        public GameManager()
        {
            //TODO: set me as thread safe singletone!
        }

        /// <summary>
        /// Enemy generation delay (Milliseconds)
        /// </summary>
        public const int ENEMY_GENERATION_DELAY = 5000;

        Task _gameTak;
        
        public void Init()
        {

            //TODO: _gameTask will instantiate enemies every ENEMY_GENERATION_DELAY 
            //TODO: _gameTask will check characters collsion and call a Hit function accordingly
        }
    }
}
