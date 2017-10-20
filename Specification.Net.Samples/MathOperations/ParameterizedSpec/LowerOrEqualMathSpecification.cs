namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    class LowerOrEqualMathSpecification:MathSpecification
    {
        private readonly int _criteria;

        public LowerOrEqualMathSpecification(int criteria)
        {
            _criteria = criteria;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate <= _criteria;
        }
    }
}
