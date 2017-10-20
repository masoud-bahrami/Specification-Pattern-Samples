using System.Collections.Generic;
using System.Linq;
using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    class CompositeSpecification : Specification
    {
        readonly List<Specification> _specifications;

        public CompositeSpecification()
        {
            _specifications = new List<Specification>
            {
                new SanitaryForMeatSpecification(),
                new MaxWeightSpecification()
            };
        }
        public override bool IsSatisfiedBy(Container container)
        {
            return _specifications.All(specification => specification.IsSatisfiedBy(container));
        }

        public void AddSpecification(Specification specification)
        {
            _specifications.Add(specification);
        }
    }

    class MaxWeightSpecification : Specification
    {
        public override bool IsSatisfiedBy(Container container)
        {
            return container.MaxWeight > 5;
        }
    }

    class SanitaryForMeatSpecification : Specification
    {
        public override bool IsSatisfiedBy(Container container)
        {
            return container.HasRefrigerator;
        }
    }
}
