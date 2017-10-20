using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    abstract class LogicalCompositeSpecification : Specification
    {
        public abstract override bool IsSatisfiedBy(Container container);

        public LogicalCompositeSpecification And(Specification specification)
        {
            return new AndSpecification(this, specification);
        }

        public LogicalCompositeSpecification Or(Specification specification)
        {
            return new OrSpecification(this, specification);
        }
        public LogicalCompositeSpecification Not()
        {
            return new NotSpecification(this);
        }
    }

    class AndSpecification : LogicalCompositeSpecification
    {
        private readonly Specification _leftSpecification;
        private readonly Specification _rigtSpecification;
        public AndSpecification(Specification lefSpecification, Specification rightSpecification)
        {
            _leftSpecification = lefSpecification;
            _rigtSpecification = rightSpecification;

        }
        public override bool IsSatisfiedBy(Container container)
        {
            return _leftSpecification.IsSatisfiedBy(container) && _rigtSpecification.IsSatisfiedBy(container);
        }
    }
    class OrSpecification : LogicalCompositeSpecification
    {
        private readonly Specification _leftSpecification;
        private readonly Specification _rigtSpecification;
        public OrSpecification(Specification lefSpecification, Specification rightSpecification)
        {
            _leftSpecification = lefSpecification;
            _rigtSpecification = rightSpecification;

        }
        public override bool IsSatisfiedBy(Container container)
        {
            return _leftSpecification.IsSatisfiedBy(container) || _rigtSpecification.IsSatisfiedBy(container);
        }
    }

    class NotSpecification : LogicalCompositeSpecification
    {
        private readonly Specification _specification;
        public NotSpecification(Specification specification)
        {
            _specification = specification;

        }
        public override bool IsSatisfiedBy(Container container)
        {
            return !_specification.IsSatisfiedBy(container);
        }
    }
}
