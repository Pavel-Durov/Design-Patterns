
namespace CreationalDesignPatterns.SingleTone
{
    class SingleToneDemo
    {
        private SingleToneDemo() { /* DO NOTHING */ }

        public static SingleToneDemo GetInstance()
        {
            //What if the object takes a lot of time to build but it used rarely? 
            if (_instance == null)
            {
                _instance = new SingleToneDemo();
            }

            return _instance;
        }

        private static SingleToneDemo _instance = null;

    }
}
