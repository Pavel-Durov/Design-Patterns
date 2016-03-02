using BehavioralDesignPatterns.Strategy.SortedListExample.Strategies.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.SortedListExample.Strategies
{
    class BubbleSortStrategy : AbstractStrategy
    {
        public override List<int> Sort(List<int> list)
        {
            Console.WriteLine("Bubble Sorting the List");
            return list; 
        }
    }
}
