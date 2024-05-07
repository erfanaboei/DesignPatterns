namespace Prototype_Console
{
    public class ConcretePrototypeSimple:IPrototype
    {
        public int Count { get; set; }
        public string Title { get; set; }

        public ConcretePrototypeSimple(int count, string title)
        {
            Count = count;
            Title = title;
        }
        
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}