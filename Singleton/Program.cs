
namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SingletonBasicTest();
            //LazySingletonTest();
            //ThreadLazySingletonTest();
            //DoubleCheckedLockingTest();
            //DoubleCheckedLockingTest();
            ThreadedLazySingletonForLazyTest();
        }


        public static void SingletonBasicTest()
        {
            SingletonBasic s1 = SingletonBasic.Instance;
            SingletonBasic s2 = SingletonBasic.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("s1 and s2 are the same instance");
            }
            else
            {
                Console.WriteLine("s1 and s2 are different instances");
            }
        }
        
        public static void LazySingletonTest()
        {
            for (int i = 0; i < 100; i++)
            {
                LazySingleton s = LazySingleton.Instance;
                s.GetLazySingletonName();
            }
        }

        public static void ThreadLazySingletonTest()
        {
            void ThreadRun()
            {
                LazySingleton ls = LazySingleton.Instance;
                ls.GetLazySingletonName();
            }

            for (int i = 0; i < 11; i++)
            {
                Thread thr = new Thread(new ThreadStart(ThreadRun));
                thr.Start();
            }
        }

        public static void DoubleCheckedLockingTest()
        {
            void ThreadRun()
            {
                DoubleCheckedLocking ls = DoubleCheckedLocking.Instance;
                ls.GetDoubleCheckedLockingName();
            }

            for (int i = 0; i < 20; i++)
            {
                Thread thr = new Thread(new ThreadStart(ThreadRun));
                thr.Start();
            }
        }

        public static void ThreadedLazySingletonForLazyTest()
        {
            void ThreadRun()
            {
                ThreadedLazySingletonForLazy ls = ThreadedLazySingletonForLazy.Instance;
                ls.GetThreadedLazySingletonForLazyName();
            }

            for (int i = 0; i < 20; i++)
            {
                Thread thr = new Thread(new ThreadStart(ThreadRun));
                thr.Start();
            }
        }
    }
}
