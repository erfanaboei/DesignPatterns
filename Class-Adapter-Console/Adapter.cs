namespace Class_Adapter_Console
{
    public class Adapter : Adaptee, ITarget
    {
        public void Operation(string message)
        {
            SpecificOperation(message);
        }
    }
}