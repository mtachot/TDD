using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testGarden;

namespace tests
{
    internal class FizzBuzzTests
    {

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void FizzBuzzMe_ANumber_ReturnsAString(int number, string expected)
        {
            var instance = new FizzBuzz(new Printer());
            string result = instance.FizzBuzzMe(number);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(7, "7")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void FizzBuzzMeConsole_ANumber_PrintsAString(int number, string expected) 
        {
            Mock<Printer> mockedPrinter = new Mock<Printer>();
            var instance = new FizzBuzz(mockedPrinter.Object);
            instance.FizzBuzzMeConsole(number);
            mockedPrinter.Verify(x => x.Print(expected), Times.Once);
            mockedPrinter.VerifyNoOtherCalls();
        }
    }
}
