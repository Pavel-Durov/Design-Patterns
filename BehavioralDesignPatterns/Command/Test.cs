using BehavioralDesignPatterns.Command.Model;

namespace BehavioralDesignPatterns.Command
{
    class Test
    {
        public static void Run()
        {
            TvRemote remote = new TvRemote(new Television());

            remote.VolumeUp.Press();
            remote.VolumeDown.Press();
            remote.On.Press();
            remote.Off.Press();
        }
    }
}
