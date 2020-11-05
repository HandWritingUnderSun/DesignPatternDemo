using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public class LazySingletonPattern
    {
        private static LazySingletonPattern instance;

        private LazySingletonPattern() { }

        public static LazySingletonPattern GetInstance()
        {
            if (instance == null)
            {
                instance = new LazySingletonPattern();
            }
            return instance;
        }
    }
}
