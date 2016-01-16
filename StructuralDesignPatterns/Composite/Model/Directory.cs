using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.Model
{
    class Directory : FileComponent
    {
        public Directory(string name) : base(name)
        {
            _fileList = new List<FileComponent>();
        }

        List<FileComponent> _fileList;

        public override void Add(FileComponent component)
        {
            _fileList.Add(component);
        }

        public override void Remove(FileComponent component)
        {
            _fileList.Remove(component);
        }

        public override void DisplayInfo()
        {
            
            Console.WriteLine($"Directory Name:  {Name}");
            Console.WriteLine($"Created at {CreationDate}");

            if (_fileList.Count > 0)
            {
                Console.WriteLine("Files : ");

                foreach (var item in _fileList)
                {
                    item.DisplayInfo();
                }
            }
            Console.WriteLine();
        }
    }
}
