using StructuralDesignPatterns.Proxy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.AtmMachineExample
{
    public class Test
    {
        public static void Run()
        {
            AtmMachineProxy proxy = new AtmMachineProxy();

            Console.WriteLine("Testing state with right pin");

            proxy.InsertCard();
            proxy.EnterPinCode(123);
            proxy.RequestCash(600);
            proxy.EjectCard();

            //Wrong pin
            Console.WriteLine("Testing state with wrong pin");
            proxy.InsertCard();
            proxy.EnterPinCode(890);
            proxy.RequestCash(600);
            proxy.EjectCard();

        }
    }
}
