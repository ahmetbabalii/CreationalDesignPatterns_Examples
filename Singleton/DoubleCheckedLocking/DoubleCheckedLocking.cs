
namespace Singleton
{
    public class DoubleCheckedLocking
    {
        private static volatile DoubleCheckedLocking singleton;
        private static readonly object lockObject = new object();

        private static int singletonCount;
        private readonly string singletonName;

        private DoubleCheckedLocking()
        {
            singletonName = "DoubleCheckedLocking" + singletonCount;
            singletonCount++;
        }

        public static DoubleCheckedLocking Instance
        {
            get
            {
                if (singleton == null)
                {
                    lock (lockObject)
                    {
                        singleton ??= new DoubleCheckedLocking();
                    }
                }
                return singleton;

            }
        }

        public void GetDoubleCheckedLockingName() =>  Console.WriteLine(singletonName);
    }
}
