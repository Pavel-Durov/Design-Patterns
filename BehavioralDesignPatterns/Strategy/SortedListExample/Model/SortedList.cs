using BehavioralDesignPatterns.Strategy.SortedListExample.Strategies.Base;
using System.Collections.Generic;

namespace BehavioralDesignPatterns.Strategy.SortedListExample.Model
{
    public class SortedList 
    {
        private AbstractStrategy _currentStrategy;
        private List<int> _numbers;

        public SortedList(List<int> numbers, AbstractStrategy strategy)
        {
            _numbers = numbers;
            _currentStrategy = strategy;
        }

        public List<int> Sort()
        {
            return _currentStrategy.Sort(_numbers) ;
        }

        public void Add(int num)
        {
            _numbers.Add(num);
        }

        public void Remove(int num)
        {
            _numbers.Remove(num);
        }

    }
}
