using System;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                new Thread(()->{
                Console.WriteLine(LazySingletonPattern.GetInstance());
            }).start();
        }
    }
    }
}
