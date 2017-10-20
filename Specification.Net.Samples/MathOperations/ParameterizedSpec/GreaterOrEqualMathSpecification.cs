namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    public class GreaterOrEqualMathSpecification:MathSpecification
    {
        private readonly int _criteria;

        public GreaterOrEqualMathSpecification(int criteria)
        {
            _criteria = criteria;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate >= _criteria;
        }
    }
}
