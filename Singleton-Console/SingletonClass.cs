namespace Singleton_Console
{
    public class SingletonClass
    {
        private static readonly SingletonClass uniqeInstance = new SingletonClass();
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public int Count { get; set; }
        
        private SingletonClass()
        {
            
        }

        public static SingletonClass GetInstance()
        {
            return uniqeInstance;
        }
    }
}