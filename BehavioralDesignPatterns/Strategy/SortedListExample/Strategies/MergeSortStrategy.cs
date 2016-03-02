using BehavioralDesignPatterns.Strategy.SortedListExample.Strategies.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.SortedListExample.Strategies
{
    class MergeSortStrategy : AbstractStrategy
    {
        public override List<int> Sort(List<int> list)
        {
            Console.WriteLine("Merge Sorting the List!! :)");
            return list;
        }
    }
}
