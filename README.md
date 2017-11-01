# Specification-Pattern-Samples
Specification Pattern(Hard coded, Parameterized and Composite) samples, included Eric Evans and Martin Fowler samples 

[Wikipedia](https://en.wikipedia.org/wiki/Specification_pattern) defines  **__Specification__**  as follows :

"In computer programming, the specification pattern is a particular software design pattern, whereby business rules can be recombined 
by chaining the business rules together using boolean logic. The pattern is frequently used in the context of domain-driven design.

A specification pattern outlines a business rule that is combinable with other business rules.
In this pattern, a unit of business logic inherits its functionality from the abstract aggregate Composite Specification class. 
The Composite Specification class has one function called IsSatisfiedBy that returns a boolean value. 
After instantiation, the specification is "chained" with other specifications, making new specifications easily maintainable, 
yet highly customizable business logic. Furthermore, upon instantiation the business logic may, 
through method invocation or inversion of control, have its state altered in order to become a delegate of other classes such as a 
persistence repository."

There are various implementations of the _specification pattern_

1. **Hard Coded Specification**
2. **Parameterized Specification**
3. **Composite Specification**

Here I tried to implemented all of them with a simple example of mathematical operators based on **C#** .

This pattern was introduced first by **_[Eric Evans](https://www.linkedin.com/in/ericevansddd/)_** and **_[Martin Fowler](https://martinfowler.com/)_** When they worked at **_Silicon Valley_**.

In their original article, they use several examples, including cargoes and containers.Some peace of their's example has been implemented here.

I also use a very simple example to show hard coded and parameterized specification, and also how we can combine each specifications using the logical opertors and composite pattern.

For example we have two svery simple **_MathSpecification_**

1. **_GreaterThanMathSpecification_**
2. **_LowerThanMathSpecification_**

Without for _Between_ operator, we have to implemented a new **_specification_**, for example :

``` 
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
```

But by using **_CompositeSpecification_** we can combine this simple operator and create **_Between_** without we have to implement a new specification
```
var specification = new
                MathOperations.ParameterizedSpec.GreaterThanMathSpecification(-5)
                .And(new MathOperations.ParameterizedSpec.LowerThanMathSpecification(5));
```

