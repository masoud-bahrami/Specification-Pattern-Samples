namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    public class EqualMathSpecification : MathSpecification
    {
        private readonly int _criteria;

        public EqualMathSpecification(int criteria)
        {
            _criteria = criteria;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return _criteria == candidate;
        }
    }
}