namespace Object_Adapter_Console
{
    public class Adapter:Target
    {
        private Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public override void Operation(string message)
        {
            _adaptee.SpecificOperation(message);
        }
    }
}