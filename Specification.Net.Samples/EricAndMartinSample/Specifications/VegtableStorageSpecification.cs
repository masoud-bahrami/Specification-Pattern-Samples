using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    //Hard Coded Specification
    class VegtableStorageSpecification : Specification
    {
        public override bool IsSatisfiedBy(Container container)
        {
            //Checking all criteria 
            return container.InternalTemperature > 5
                && container.MaxWeight >= 1;
        }
    }
}
