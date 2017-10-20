namespace Specification.Net.Samples.MathOperations.HardCodedSpec
{
    public class EqualMathSpecification : MathSpecification
    {
        public override bool IsSatisfiedBy(int candidate)
        {
            return 5 == candidate;
        }
    }
}