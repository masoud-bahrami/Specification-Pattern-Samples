namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    public class LowerThanMathSpecification : LogicalCompositMathSpecification
    {
        private readonly int _criteria;

        public LowerThanMathSpecification(int criteria)
        {
            _criteria = criteria;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate < _criteria;
        }
    }
}
