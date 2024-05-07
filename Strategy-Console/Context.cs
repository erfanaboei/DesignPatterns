namespace Strategy_Console
{
    public class Context
    {
        private readonly Strategy _strategy;

        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void LogFullName(string fullName)
        {
            _strategy.LogAnything(fullName);
        }
    }
}