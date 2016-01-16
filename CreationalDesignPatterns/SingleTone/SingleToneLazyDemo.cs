using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SingleTone
{
    class SingleToneLazyDemo
    {
        public SingleToneLazyDemo() {   /* DO NOTHING */    }

        public static SingleToneLazyDemo GetInstance()
        {
            if (_instance == null)
            {//What can happe here?
                _instance = new SingleToneLazyDemo();
            }

            return _instance;
        }

        static SingleToneLazyDemo _instance;
    }
}
