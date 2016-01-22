using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralDesignPatterns.Flyweight.Model.Textures.Base;
using StructuralDesignPatterns.Flyweight.Model.Textures;

namespace StructuralDesignPatterns.Flyweight.Model.Trees
{
    class PsychodelicTree : Tree
    {
        public PsychodelicTree(double height = 0, double width = 0) 
            : base(new PointyTexture(), ConsoleColor.Red, ConsoleColor.Magenta, height, width)
        {

        }

        

        public override async Task Render()
        {
            if (!_alreadyRendered)
            {
                Console.WriteLine("PsychodelicTree - RENDER - START");
                await Task.Delay(356);
                Console.WriteLine("PsychodelicTree - RENDER - END");
                _alreadyRendered = true;
            }
            else
            {
                Console.WriteLine("PsychodelicTree : I'm already rendered - Flyweight is the best...");
            }
        }

    }
}
