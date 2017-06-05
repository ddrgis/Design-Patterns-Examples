namespace Singleton
{
    //Simple abstract singleton class
    public sealed class Sigleton
    {
        private static Sigleton instance;
        //private static readonly Singleton _instance = new Singleton();

        private Sigleton()
        {
        }

        public static Sigleton GetInstance()
        {
            if (instance == null)
                instance = new Sigleton();
            return instance;
        }
    }
}