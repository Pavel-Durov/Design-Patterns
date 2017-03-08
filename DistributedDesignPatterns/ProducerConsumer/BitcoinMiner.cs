using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedDesignPatterns.ProducerConsumer
{
    internal class BitcoinMiner
    {

        private const int MAX_CAPACITY = 10000;
        private const int PRODUCER_COINS_COUNT = 2;

        //Note: Check out IProducerConsumerCollection interface 
        //      under System.Collections.Concurrent namespace
        private readonly BlockingCollection<BitcoinResult> _workQueue;
        private readonly TaskFactory _taskFactory;
        private readonly Task[] _producers;
        private readonly Random _rnd;

        private int _producerDoneCount = 0;
        private Task<List<BitcoinResult>>[] _consumers;

        internal BitcoinMiner()
        {
            _workQueue = new BlockingCollection<BitcoinResult>(MAX_CAPACITY);
            _taskFactory = new TaskFactory(TaskCreationOptions.LongRunning, TaskContinuationOptions.None);
            _consumers = new Task<List<BitcoinResult>>[ConsumerCount];
            _producers = new Task[ProducersCount];
            Bitcoins = new List<BitcoinResult>();
            _rnd = new Random();
        }

        public int ProducersCount => Environment.ProcessorCount;
        public int ConsumerCount => Environment.ProcessorCount;

        internal List<BitcoinResult> Bitcoins { get; private set; }

        internal void ConsumersWaitOneByOne()
        {
            int completed = 0;

            while (completed < ConsumerCount)
            {
                int taskIndex = Task.WaitAny(_consumers);
                var completedConsumer = _consumers[taskIndex];
                var consumerResult = completedConsumer.Result;

                foreach (var result in consumerResult)
                {
                    Bitcoins.Add(result);
                }

                completed++;
                RemoveConsumer(completedConsumer);
            }
        }

        private void RemoveConsumer(Task completedConsumer)
        {
            _consumers = _consumers.Where((consumer) => consumer != completedConsumer)
                                   .ToArray();
        }

        internal void StartConsumers()
        {
            for (int i = 0; i < ConsumerCount; i++)
            {
                _consumers[i] = _taskFactory.StartNew(() =>
                {
                    List<BitcoinResult> result = new List<BitcoinResult>();
                    while (!_workQueue.IsCompleted)
                    {
                        try
                        {
                            Console.WriteLine($" - Consumer :: WAITING FOR PRODUCER DATA, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
                            result.Add(_workQueue.Take());
                            Console.WriteLine($" - Consumer :: PRODUCER DATA RECEIVED, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
                        }
                        catch (ObjectDisposedException e)
                        {/* ~ Ignore : This is a wake up call ~ */}
                        catch (InvalidOperationException e)
                        {/* ~ Ignore : This is a wake up call ~ */}
                    }

                    Console.WriteLine($" - Consumer :: DONE, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
                    return result;
                });
            }
        }

        internal void StartProducers()
        {
            for (int i = 0; i < ProducersCount; i++)
            {
                _producers[i] = _taskFactory.StartNew(async () => await ProducerRoutine());
            }
        }

        private async Task ProducerRoutine()
        {
            for (int j = 0; j < PRODUCER_COINS_COUNT; j++)
            {
                Console.WriteLine($"+ Producer :: MINING BITCOIN, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
                var result = await GenerateResult();
                _workQueue.Add(result);
            }

            Console.WriteLine($"+ Producer :: DONE, ThreadId : {Thread.CurrentThread.ManagedThreadId}");
            Interlocked.Add(ref _producerDoneCount, 1);

            if (_producerDoneCount == ProducersCount)
            {
                _workQueue.CompleteAdding();
            }
        }


        private async Task<BitcoinResult> GenerateResult()
        {
            //CPU intensive work simulation
            await Task.Delay(_rnd.Next(2000, 5000));
            return new BitcoinResult() { Hash = (new object().GetHashCode()) };
        }
    }
}
