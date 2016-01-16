using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.SingleTone
{
    class Test
    {
        public static void Run()
        {
            Console.WriteLine("Creating single tone");
            SingleTone.SingleToneDemo single = SingleToneDemo.GetInstance();

        }
    }
}
