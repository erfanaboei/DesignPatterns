using Builder_Console.Classes;

namespace Builder_Console.Builders
{
    public class ConcreteBuilder1: Builder
    {
        public override void BuildPart1()
        {
            _product.Part1 = "Build Part1 Success";
        }

        public override void BuildPart2()
        {
            _product.Part2 = "Build Part2 Success";
        }

        public override Product GetResult()
        {
            _product.Name = "TEST RESULT => ConcreteProduct1";
            return base.GetResult();
        }
    }
}