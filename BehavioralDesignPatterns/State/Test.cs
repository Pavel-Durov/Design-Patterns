using BehavioralDesignPatterns.State.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.State
{
    class Test
    {
        public static void Run()
        {
            AtmMachine atm = new AtmMachine(1000);

            Console.WriteLine("Testing state with right pin");

            atm.InsertCard();
            atm.EnterPinCode(123);
            atm.RequestCash(600);
            atm.EjectCard();

            //Wrong pin
            Console.WriteLine("Testing state with wrong pin");
            atm.InsertCard();
            atm.EnterPinCode(890);
            atm.RequestCash(600);
            atm.EjectCard();



        }
    }
}
