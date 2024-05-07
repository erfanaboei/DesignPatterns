namespace Builder_Console.Builders
{
    public class Director
    {
        private Builder _builder;

        public void SetBuilder(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();
        }
    }
}