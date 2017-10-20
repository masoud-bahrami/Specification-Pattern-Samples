
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specification.Net.Samples.MathOperations;
using Specification.Net.Samples.MathOperations.HardCodedSpec;
using Specification.Net.Samples.MathOperations.ParameterizedSpec;
using EqualMathSpecification = Specification.Net.Samples.MathOperations.HardCodedSpec.EqualMathSpecification;
using GreaterThanMathSpecification = Specification.Net.Samples.MathOperations.HardCodedSpec.GreaterThanMathSpecification;
using LowerThanMathSpecification = Specification.Net.Samples.MathOperations.HardCodedSpec.LowerThanMathSpecification;

namespace Specification.Net.Samples.Tests
{
    [TestClass]
    public class MathSpecificationTests
    {
        private readonly List<int> _numbers = new List<int>();
        [TestMethod]
        public void TestHardCodedSpecifications()
        {
            GenerateFakeNumbers();

            var result = Filter(new EqualMathSpecification());
            Assert.AreEqual(result.Count , 1);
            Assert.AreEqual(result.FirstOrDefault() , 5);

            result = Filter(new GreaterThanMathSpecification());
            Assert.AreEqual(result.Count, 24);
            Assert.IsFalse(result.Contains(5));

            result = Filter(new MathOperations.HardCodedSpec.GreaterOrEqualMathSpecification());
            Assert.AreEqual(result.Count, 25);
            Assert.IsTrue(result.Contains(5));

            result = Filter(new LowerThanMathSpecification());
            Assert.AreEqual(result.Count, 15);
            Assert.IsFalse(result.Contains(5));

            result = Filter(new LowerOrEqualMathSpecification());
            Assert.AreEqual(result.Count, 16);
            Assert.IsTrue(result.Contains(5));
        }

        [TestMethod]
        public void TestParameterizedSpecifications()
        {
            GenerateFakeNumbers();
            var result = Filter(new BetweenMathSpecification(-5, 5));
            Assert.AreEqual(result.Count, 9);
            Assert.IsTrue(result.Contains(-4));
            Assert.IsFalse(result.Contains(-5));
        }

        [TestMethod]
        public void TestCompositSpecifications()
        {
            GenerateFakeNumbers();

            var specification = new
                MathOperations.ParameterizedSpec.GreaterThanMathSpecification(-5)
                .And(new MathOperations.ParameterizedSpec.LowerThanMathSpecification(5));

            var result = Filter(specification);
            Assert.AreEqual(result.Count, 9);
            Assert.IsTrue(result.Contains(-4));
            Assert.IsFalse(result.Contains(-5));
        }
        private List<int> Filter(MathSpecification specification)
        {
            return _numbers.Where(specification.IsSatisfiedBy).ToList();
        }

        private void GenerateFakeNumbers()
        {
            for (var i = -10; i < 30; i++)
            {
                _numbers.Add(i);
            }
        }
    }
}
