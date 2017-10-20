using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    internal abstract class Specification
    {
        public abstract bool IsSatisfiedBy(Container container);
    }
}
