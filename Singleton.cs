using System;

namespace DemoApplicationForDesignPattern
{
    internal class Singleton
    {
        // Declare private static field
        private static Singleton instance;

        // Private constructor
        private Singleton() { }

        // GetInstance method which will be accessed from outside scope
        // will return instance always when invoked
        // if first time call create instance
        // else return already created
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance; // Corrected to return the instance
        }
    }
}