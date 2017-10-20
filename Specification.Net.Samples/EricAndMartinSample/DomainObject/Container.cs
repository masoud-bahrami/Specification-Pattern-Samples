using System.Collections.Generic;

namespace Specification.Net.Samples.EricAndMartinSample.DomainObject
{
    class Container
    {
        public int Id { get; set; }
        public bool HasRefrigerator { get; set; }
        public int InternalTemperature { get; set; }
        public int MaxWeight { get; set; }
        public List<Cargo> Cargoes;
    }
}
