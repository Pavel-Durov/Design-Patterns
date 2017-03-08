using System;
using System.Diagnostics;

namespace DistributedDesignPatterns.ProducerConsumer
{
    internal class Test
    {
        internal static void Run()
        {
            var sw = Stopwatch.StartNew();

            var tm = new BitcoinMiner();
            tm.StartProducers();
            tm.StartConsumers();
            tm.ConsumersWaitOneByOne();

            Console.WriteLine("@@ Elapsed Time: {0:0.000} seconds", 
                                        sw.ElapsedMilliseconds / 1000.0);
            Console.ReadKey();
        }
    }
}
