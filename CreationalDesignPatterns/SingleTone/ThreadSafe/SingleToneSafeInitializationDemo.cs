using System;

namespace CreationalDesignPatterns.SingleTone.ThreadSafe
{
    class SingleToneSafeInitializationDemo
    {
        private SingleToneSafeInitializationDemo() { /* DO NOTHING */ }

        public static SingleToneSafeInitializationDemo getInstance()
        {
            try
            {//Why we se try-catch?
                lock (_sync)//Why we use lock?
                {
                    if (_instance == null)
                    {
                        _instance = new SingleToneSafeInitializationDemo();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("failed to set instance...", e);
            }

            

            return _instance;
        }

        private static SingleToneSafeInitializationDemo _instance = null;
        static object _sync = new object();
    }
}
