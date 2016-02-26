
using StructuralDesignPatterns.Composite.Model;

namespace StructuralDesignPatterns.Composite.SystemAdministrator
{
    class Test
    {
        public static void Run()
        {
            Model.SystemAdministrator admin = new Model.SystemAdministrator();
            admin.DoYourJob();
            admin.DoSomethingStupid();
        }
    }
}
