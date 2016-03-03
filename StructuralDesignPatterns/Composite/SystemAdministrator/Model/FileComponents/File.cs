using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.Model
{
    public class File : FileComponent
    {
        public File(string name) : base(name)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"FileName:  {Name}");
            Console.WriteLine($"Created at {CreationDate}");
        }
    }
}
