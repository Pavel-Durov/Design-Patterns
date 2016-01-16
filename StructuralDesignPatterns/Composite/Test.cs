using StructuralDesignPatterns.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite
{
    class Test
    {
        public static void Run()
        {
            SystemAdministrator admin = new SystemAdministrator();
            admin.DoYourJob();


            //admin.DoSomethingStupid();
        }
    }
}
