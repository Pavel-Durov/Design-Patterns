using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.Model
{
    class ZipFileComponent : FileComponent
    {
        public ZipFileComponent(string name) : base(name)
        {
            _zippedFiles = new List<FileComponent>();
        }

        List<FileComponent> _zippedFiles;

        public override void Add(FileComponent component)
        {
            _zippedFiles.Add(component);
        }
        public override void Remove(FileComponent component)
        {
            _zippedFiles.Remove(component);
        }
        
        public override void DisplayInfo()
        {
            Console.WriteLine($"I'm ZIP , {Name}, with {_zippedFiles.Count} number of files");
        }
    }
}
