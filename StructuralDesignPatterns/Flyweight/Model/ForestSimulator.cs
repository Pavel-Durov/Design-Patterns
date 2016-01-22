using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight.Model
{
    class ForestSimulator
    {
        public ForestSimulator(TreesFlyweight forestCreator)
        {
            _rnd = new Random();
            _forestCreator = forestCreator;
        }

        Random _rnd;
        TreesFlyweight _forestCreator;
        const int TREES_COUNT = 12;

        const int EARTH_MIN_X = 0;
        const int EARTH_MIN_Y = 0;
        const int EARTH_MAX_X = 1000;
        const int EARTH_MAX_Y = 1000;

        public async Task Render()
        {
            await _forestCreator.Init();
            var treesList = _forestCreator.Generate(TREES_COUNT);

            foreach (var tree in treesList)
            {
                PlaceTreeOnEarth(tree);
            }
        }

        private void PlaceTreeOnEarth(Tree tree)
        {
            int x = _rnd.Next(EARTH_MIN_X, EARTH_MAX_X);
            int y = _rnd.Next(EARTH_MIN_Y, EARTH_MAX_Y);

            Console.WriteLine($"Planting tree on ({x},{y})");
        }
    }
}
