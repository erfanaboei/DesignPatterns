using Builder_Console.Classes;

namespace Builder_Console.Builders
{
    public class ConcreteBuilder2:Builder
    {
        public override void BuildPart1()
        {
            _product.Part1 = "Set Part1";
        }

        public override void BuildPart2()
        {
            _product.Part2 = "Set Part2";
        }

        public override Product GetResult()
        {
            _product.Name = "TEST RESULT => ConcreteBuilder2";
            return base.GetResult();
        }
    }
}