using StructuralDesignPatterns.Proxy.BasicMathExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Proxy.BasicMathExample
{
    public class Test
    {
        public static void Run()
        {
            BasicMathProxy proxy = new BasicMathProxy();
            Console.WriteLine(proxy.Round(2.3));

        }
    }
}
