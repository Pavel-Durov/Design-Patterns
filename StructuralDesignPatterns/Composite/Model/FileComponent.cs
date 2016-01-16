using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.Model
{
    public abstract class FileComponent
    {
        public FileComponent(string name)
        {
            Name = name;
            CreationDate = DateTime.Now;
        }

        public virtual void Add(FileComponent component)
        {
            throw new Exception("Cannot add component to a file");
        }

        public virtual void Remove(FileComponent component)
        {
            throw new Exception("Cannot remove a component from a file");
        }

        public abstract void DisplayInfo();


        public string Name { get; private set; }

        public DateTime CreationDate { get; private set; }

        
    }
}
