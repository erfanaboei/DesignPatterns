using Builder_Console.Classes;

namespace Builder_Console.Builders
{
    public abstract class Builder
    {
        protected Product _product = new(); 

        public abstract void BuildPart1();
        public abstract void BuildPart2();

        public virtual Product GetResult()
        {
            return _product;
        }
    }
}