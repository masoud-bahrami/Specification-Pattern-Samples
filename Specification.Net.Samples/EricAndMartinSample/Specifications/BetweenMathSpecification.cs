using Specification.Net.Samples.MathOperations;

namespace Specification.Net.Samples.EricAndMartinSample.Specifications
{
    /// <summary>
    /// We have to implement every specifation, whech we needed
    /// </summary>
    class BetweenMathSpecification : MathSpecification
    {
        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate > -1 && candidate < 20;
        }
    }
}
