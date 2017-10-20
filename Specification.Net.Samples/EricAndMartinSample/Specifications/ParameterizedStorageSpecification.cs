using Specification.Net.Samples.EricAndMartinSample.DomainObject;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    class ParameterizedStorageSpecification : Specification
    {
        private readonly int _maxWeight;
        private readonly int _maxTemp;
        public ParameterizedStorageSpecification(int maxTemp, int maxWeight)
        {
            _maxTemp = maxTemp;
            _maxWeight = maxWeight;
        }
        public override bool IsSatisfiedBy(Container container)
        {
            //Checking all criteria 
            return container.HasRefrigerator && container.InternalTemperature < _maxTemp
                && container.MaxWeight >= _maxWeight;
        }
    }
}