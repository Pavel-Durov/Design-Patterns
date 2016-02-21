using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Composite.Model
{
    class SystemAdministrator
    {
        public void DoYourJob()
        {
            Console.WriteLine("I am a System Administrator and I am doing my JOB");

            Directory tempDir = new Directory("Temp Folder");
            Directory emptyDir = new Directory("Music");
            Directory documents= new Directory("Documents");


            documents.Add(new File("very-important-file.cyper"));
            documents.Add(new File("presentation.rtf"));
            documents.Add(new File("todo list.rtf"));

            
            File f = new File("test.txt");
            File f2 = new File("test.txt");

            tempDir.Add(f);
            tempDir.Add(f2);


            Directory driveC = new Directory("C:\\");
            driveC.Add(tempDir);
            driveC.Add(emptyDir);
            driveC.Add(documents);
            
            Console.WriteLine("Thats what I've done");

            driveC.DisplayInfo();

        }

        internal void DoSomethingStupid()
        {
            File f = new File("test.txt");
            File f2 = new File("test.txt");
            f.Add(f2);
        }
    }
}
