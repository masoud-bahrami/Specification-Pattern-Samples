namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    public class GreaterThanMathSpecification : LogicalCompositMathSpecification
    {
        private readonly int _criteria;

        public GreaterThanMathSpecification(int criteria)
        {
            _criteria = criteria;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate > _criteria;
        }
    }
}
