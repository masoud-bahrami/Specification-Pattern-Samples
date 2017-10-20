using System.Collections.Generic;
using System.Linq;

namespace Specification.Net.Samples.MathOperations.HardCodedSpec
{
    public class CompositMathSpecification : MathSpecification
    {
        private readonly List<MathSpecification> _specifications;

        public CompositMathSpecification()
        {
            _specifications = new List<MathSpecification>
            {
                new EqualMathSpecification(),
                new GreaterThanMathSpecification()
            };
        }
        public override bool IsSatisfiedBy(int candidate)
        {
            return _specifications.All(mathSpecification => mathSpecification.IsSatisfiedBy(candidate));
        }
    }
}
