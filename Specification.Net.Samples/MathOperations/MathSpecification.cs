namespace Specification.Net.Samples.MathOperations
{
    public abstract class MathSpecification
    {
        public abstract bool IsSatisfiedBy(int candidate);

        /// <summary>
        /// this methods must be implemented in subclass
        /// 
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        public MathSpecification IsGeneralizationOf(MathSpecification specification) => null;
        public MathSpecification IsSpecialCaseOf(MathSpecification specification) => null;
        public MathSpecification ReminderUnsatisfiedBy() => null;
    }
}
