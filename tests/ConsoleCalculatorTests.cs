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
    public class ConsoleCalculatorTests
    {
        [Test]
        public void Add_TwoNumbers_PrintsTheirSum()
        {
            Mock<Printer> mock = new Mock<Printer>();
            var instance = new ConsoleCalculator(mock.Object);
            instance.Add(1, 2);
            mock.Verify(x => x.Print("1 + 2 = 3"), Times.Once);
            mock.VerifyNoOtherCalls();
        }
    }
}
