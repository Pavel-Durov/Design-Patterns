using StructuralDesignPatterns.Flyweight.Model.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Flyweight.Model
{
    class TreesFlyweight
    {
        public TreesFlyweight()
        {
            _rnd = new Random();
        }

        public async Task Init()
        {
            _treeCollection = new Tree[]
            {
                new PsychodelicTree(_rnd.Next(100, 500), _rnd.Next(50, 100)),
                new HawthornTree(_rnd.Next(100, 500), _rnd.Next(50, 100)),
                new ArborvitaeTree(_rnd.Next(100, 500), _rnd.Next(50, 100))
            };
            foreach (var tree in _treeCollection)
            {
                await tree.Render();
            }
        }

        Random _rnd;

        Tree[] _treeCollection;
        public Tree GetRandomTree()
        {
            int index = _rnd.Next(0, 2);
            var result = _treeCollection[index];

            return result;
        }

        public List<Tree> Generate(int amount)
        {
            List<Tree> result = new List<Tree>();

            for (int i = 0; i < amount; i++)
            {
                var tree = GetRandomTree();
                tree.Render();
                result.Add(GetRandomTree());
            }

            return result;
        }
    }
}
