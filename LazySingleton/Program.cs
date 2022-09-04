using System;
namespace Singleton
{
    public class Program
    {
        public class A
        {
            static A a = new A();
            private A() { }
        }

        static void Main()
        {

            for (int i = 0; i < 1000; i++)
            {
                Singleton s = Singleton.getInstance();
            }
        }
    }
}