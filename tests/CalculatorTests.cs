using NUnit.Framework;
using testgarden;

namespace tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_GivesTheirSum()
        {
            var instance = new Calculator();
            int result = instance.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_NegativeFirstNumber_ThrowsBoom()
        {
            var instance = new Calculator();
            Exception? result = Assert.Throws<Exception>(() => instance.Add(-1, 2));
            Assert.That(result.Message, Is.EqualTo("Boom"));
        }

        [Test]
        public void Multiply_TwoNumbers_GivesTheirProduct()
        {
            var instance = new Calculator();
            int result = instance.Multiply(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ByZero_EqualsZero()
        {
            var instance = new Calculator();
            int result = instance.Multiply(0, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Soustract_TwoNumbers_GivesFirstNumberMinusSecondNumber()
        {
            var instance = new Calculator();
            var result = instance.Soustract(3, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Divide_TwoNumbers_GivesTheireQuotient()
        {
            var instance = new Calculator();
            decimal result = instance.Divide(6, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZero()
        {
            var instance = new Calculator();
            DivideByZeroException? result = Assert.Throws<DivideByZeroException>(() => instance.Divide(6, 0));
            Assert.That(result.Message, Is.EqualTo("Attempted to divide by zero."));
        }
    }
}