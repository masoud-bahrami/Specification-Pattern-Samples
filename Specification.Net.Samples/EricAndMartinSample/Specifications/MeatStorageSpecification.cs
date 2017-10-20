using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    //Hard Coded Specification
    class MeatStorageSpecification : Specification
    {
        public override bool IsSatisfiedBy(Container container)
        {
            //Checking all criteria 
            return container.HasRefrigerator && container.InternalTemperature < 4
                && container.MaxWeight >= 20;
        }
    }
}
