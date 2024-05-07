using System;

namespace Singleton_Console
{
    public class LazySingletonClass
    {
        // private static LazySingletonClass UniqueClass;
        
        private static readonly Lazy<LazySingletonClass> UniqueClass = new Lazy<LazySingletonClass>();

        private LazySingletonClass()
        {
            
        }

        public static LazySingletonClass GetInstance()
        {
            // if (uniqueClass == null) UniqueClass = new LazySingletonClass();

            return UniqueClass.Value;
        }
        
    }
}