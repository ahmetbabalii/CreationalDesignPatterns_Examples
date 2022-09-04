namespace Singleton
{
    public class LazySingleton
    {

        private static LazySingleton singleton;

        private static int sCount;
        private string sname;
            

        private LazySingleton()
        {
            sCount++;
            sname = "LazySingleton" + sCount;
        }

        public static LazySingleton Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new LazySingleton();
                return singleton;
            }
        }
        
        public void GetLazySingletonName()
        {
            Console.WriteLine(sname);
        }
    }
}
