namespace FactoryMethod_Console
{
    public abstract class Program
    {
        private static void Main(string[] args)
        {
            var product = new ConcreteCreator();
            var p = product.FactoryMethod(0);
            p.Execute();
            p = product.FactoryMethod(1);
            p.Execute();
            p = product.FactoryMethod(-4);
            p.Execute();
        }
    }
}