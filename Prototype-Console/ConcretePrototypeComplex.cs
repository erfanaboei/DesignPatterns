namespace Prototype_Console
{
    public class ConcretePrototypeComplex: IPrototype
    {
        public ConcretePrototypeSimple MyService { get; set; }

        public ConcretePrototypeComplex(ConcretePrototypeSimple myService)
        {
            MyService = myService;
        }
        
        public IPrototype Clone()
        {
            var result = (ConcretePrototypeComplex)this.MemberwiseClone();
            result.MyService = (ConcretePrototypeSimple)this.MyService.Clone();
            return result;
        }
    }
}