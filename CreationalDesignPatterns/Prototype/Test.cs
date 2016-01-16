
using CreationalDesignPatterns.Prototype.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Prototype
{
    class Test
    {
        public static void Run()
        {
            Computer cp = new Computer()
            {
                AmountOfCores = 4
            };

            Computer cp2 = (Computer)cp.Clone();

            if (cp == cp2)
            {
                Console.WriteLine($"cp & cp2 are same instances");
            }

            if (cp.AmountOfCores == cp2.AmountOfCores)
            {
                Console.WriteLine($"cp.AmountOfCores & cp2.AmountOfCores are same value");
            }


            if (cp.GPU == cp2.GPU)
            {
                Console.WriteLine($"cp.GPU & cp2.GPU are same instances");
            }

            if (cp.GPU.AmountOfRam == cp.GPU.AmountOfRam)
            {
                Console.WriteLine($"both computer has the same amunt og RAM");
            }

            cp.GPU.AmountOfRam =  8;

            if (cp.GPU.AmountOfRam == cp.GPU.AmountOfRam)
            {
                Console.WriteLine($"both computer has the same amunt og RAM");
            }

        }
    }
}
