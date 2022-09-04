namespace Singleton
{
    public class SingletonBasic
    {
        private static SingletonBasic instance = new SingletonBasic();

        private SingletonBasic() { }

        public static SingletonBasic Instance
        {
            get
            {
                return instance;
            }
        }
    }
}