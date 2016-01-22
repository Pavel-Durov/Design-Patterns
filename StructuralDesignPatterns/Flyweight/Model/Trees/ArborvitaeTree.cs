using StructuralDesignPatterns.Flyweight.Model.Textures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight.Model.Trees
{
    class ArborvitaeTree : Tree
    {

        public ArborvitaeTree(double height = 0, double width = 0)
            : base(new SoftTexture(), ConsoleColor.Black, ConsoleColor.Green, height, width)
        {

        }
        bool _alreadyRendered;

        public override async Task Render()
        {
            if (!_alreadyRendered)
            {
                Console.WriteLine("ArborvitaeTree - RENDER - START");
                await Task.Delay(356);
                Console.WriteLine("ArborvitaeTree - RENDER - END");
                _alreadyRendered = true;
            }
            else
            {
                Console.WriteLine("ArborvitaeTree : I'm already rendered - Flyweight is the best...");
            }
        }
    }
}
