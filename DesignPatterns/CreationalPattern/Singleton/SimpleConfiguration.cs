﻿namespace DesignPatterns.CreationalPattern.Singleton
{
    public class SimpleConfiguration
    {
        private static SimpleConfiguration _instance;
        private static readonly object LockObject = new object();

        public string FirstValue => "FirstValue";

        public string LastValue => "LastValue";

        private SimpleConfiguration()
        {
            
        }

        public static SimpleConfiguration GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }
            lock (LockObject)
            {
                return _instance ?? (_instance = new SimpleConfiguration());
            }
        }
    }
}
