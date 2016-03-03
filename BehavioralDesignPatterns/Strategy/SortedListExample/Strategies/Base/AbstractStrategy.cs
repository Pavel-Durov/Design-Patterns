using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Strategy.SortedListExample.Strategies.Base
{
    public abstract class AbstractStrategy 
    {
        public abstract List<int> Sort(List<int> list);
    }
}
