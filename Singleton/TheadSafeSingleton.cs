namespace Singleton
{
    public sealed class TheadSafeSingleton
    {
        private static volatile TheadSafeSingleton instance;
        private static readonly object syncRoot = new object();

        private TheadSafeSingleton()
        {
        }

        public static TheadSafeSingleton GetInstance()
        {
            if (instance != null) return instance;
            lock (syncRoot)
            {
                instance = new TheadSafeSingleton();
            }
            return instance;
        }
    }
}