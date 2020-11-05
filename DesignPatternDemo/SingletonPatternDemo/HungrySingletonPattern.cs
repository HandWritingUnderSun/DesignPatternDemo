using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDemo
{
    public class HungrySingletonPattern
    {
        public static HungrySingletonPattern instance = new HungrySingletonPattern();

        private HungrySingletonPattern() 
        { }

        public static HungrySingletonPattern GetInstance()
        {
            return instance;
        }
    }
}
