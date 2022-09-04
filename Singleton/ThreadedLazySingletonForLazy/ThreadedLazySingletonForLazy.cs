
namespace Singleton
{
    public class ThreadedLazySingletonForLazy
    {
        private static readonly Lazy<ThreadedLazySingletonForLazy> instance =
            new Lazy<ThreadedLazySingletonForLazy>(() => new ThreadedLazySingletonForLazy());

        private static int count;
        private readonly string threadName;

        private ThreadedLazySingletonForLazy()
        {
            count++;
            threadName = "ThreadedLazySingletonForLazy" + count;
        }

        public static ThreadedLazySingletonForLazy Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public void GetThreadedLazySingletonForLazyName() => Console.WriteLine(threadName);
    }
}
