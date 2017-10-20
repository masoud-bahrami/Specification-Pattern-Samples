namespace Specification.Net.Samples.MathOperations.HardCodedSpec
{
    public class LowerThanMathSpecification : MathSpecification
    {
        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate < 5;
        }
    }
}
