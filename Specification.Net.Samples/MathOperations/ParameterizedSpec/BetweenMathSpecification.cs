namespace Specification.Net.Samples.MathOperations.ParameterizedSpec
{
    /// <summary>
    /// We have to implement every specifation, whech we needed
    /// </summary>
    public class BetweenMathSpecification : MathSpecification
    {
        private readonly int _left, _right;
        public BetweenMathSpecification(int left, int rigth)
        {
            _left = left;
            _right = rigth;
        }

        public override bool IsSatisfiedBy(int candidate)
        {
            return candidate > _left && candidate < _right;
        }
    }
}
