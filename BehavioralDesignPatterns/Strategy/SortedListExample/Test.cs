using BehavioralDesignPatterns.Strategy.SortedListExample.Model;
using BehavioralDesignPatterns.Strategy.SortedListExample.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.SortedListExample
{
    public class Test
    {
        public static void Run()
        {
            var list = new List<int>() { 1, 2, 3, 5, 2, 8, 5, 3, 2 };
            SortedList sorted = new SortedList(list, new BubbleSortStrategy());
            SortedList quick_sorted = new SortedList(list, new QuickSortStrategy());
            SortedList merge_sorted = new SortedList(list, new MergeSortStrategy());

        }
    }
}
