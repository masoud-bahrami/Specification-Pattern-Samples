
namespace Specification.Net.Samples.EricAndMartinSample.DomainObject
{
    class Cargo
    {
        public Specifications.Specification StorageSpecification;
        //By using Strategy Pattern, each cargo use a specific storage specification
        public Cargo(Specifications.Specification specification)
        {
            StorageSpecification = specification;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
