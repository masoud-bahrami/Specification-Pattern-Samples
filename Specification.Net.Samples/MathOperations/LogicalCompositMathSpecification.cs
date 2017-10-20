namespace Specification.Net.Samples.MathOperations
{
    public abstract class LogicalCompositMathSpecification : MathSpecification
    {
        public abstract override bool IsSatisfiedBy(int candidate);
        public LogicalCompositMathSpecification And(MathSpecification specification)
        {
            return new AndMathSpecification(this, specification);
        }
        public LogicalCompositMathSpecification Or(MathSpecification specification)
        {
            return new OrMathSpecification(this, specification);
        }
        public LogicalCompositMathSpecification Not(MathSpecification specification)
        {
            return new NotMathSpecification( specification);
        }
    }

    class AndMathSpecification : LogicalCompositMathSpecification
    {
        private readonly MathSpecification _leftSpecification;
        private readonly MathSpecification _rightSpecification;

        public AndMathSpecification(MathSpecification leftSpecification, MathSpecification rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) && _rightSpecification.IsSatisfiedBy(candidate);
        }
    }
    class OrMathSpecification : LogicalCompositMathSpecification
    {
        private readonly MathSpecification _leftSpecification;
        private readonly MathSpecification _rightSpecification;

        public OrMathSpecification(MathSpecification leftSpecification, MathSpecification rightSpecification)
        {
            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return _leftSpecification.IsSatisfiedBy(candidate) || _rightSpecification.IsSatisfiedBy(candidate);
        }
    }
    class NotMathSpecification : LogicalCompositMathSpecification
    {
        private readonly MathSpecification _specification;

        public NotMathSpecification(MathSpecification specification)
        {
            _specification = specification;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return !_specification.IsSatisfiedBy(candidate);
        }
    }
}
