using NUnit.Framework;
using testGarden;

namespace tests
{
    public class StringCalculatorTests
    {
        [Test]
        public void Add_VoidString_ReturnsZero()
        {
            var instance = new StringCalculator();
            int result = instance.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_OneNumberString_ReturnsNumber()
        {
            var instance = new StringCalculator();
            int result = instance.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }

        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4", 10)]
        [TestCase("1,2,3,4,5", 15)]
        public void Add_SeveralNumbersString_ReturnsTheirSum(string args, int expected)
        {
            var instance = new StringCalculator();
            int result = instance.Add(args);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("//;\n1;2", 3)]
        [TestCase("//noot\n1noot2noot3", 6)]
        public void Add_SeveralNumbersWithDefinedSeparator_ReturnsTheirSum(string args, int expected)
        {
            var instance = new StringCalculator();
            int result = instance.Add(args);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Add_SeveralNumbersWithNegatives_RaisesExceptionAndShowNegatives()
        {
            var instance = new StringCalculator();
            Exception? result = Assert.Throws<Exception>(() => instance.Add("1,-2,3"));
            Assert.That(result.Message, Is.EqualTo("Negatives not allowed: -2"));
        }

        [Test]
        public void SplitArgs_CommaSeparatedArgs_ReturnsListOfArgs()
        {
            var instance = new StringCalculator();
            List<string> expectedList = new List<string>();
            expectedList.Add("1");
            expectedList.Add("2");
            List<string> resultList = instance.SplitArgs("1,2", ",");
            Assert.That(resultList, Is.EquivalentTo(expectedList));
        }

        [Test]
        public void SplitArgs_DifferentSeparatorsArgs_ReturnsListOfArgs()
        {
            var instance = new StringCalculator();
            List<string> expectedList = new List<string>();
            expectedList.Add("1");
            expectedList.Add("2");
            expectedList.Add("3");
            List<string> resultList = instance.SplitArgs("1\n2,3", "");
            Assert.That(resultList, Is.EquivalentTo(expectedList));
        }

        [Test]
        public void SplitArgs_DefinedSeparatorArgs_ReturnsListOfArgs()
        {
            var instance = new StringCalculator();
            List<string> expectedList = new List<string>();
            expectedList.Add("1");
            expectedList.Add("2");
            List<string> resultList = instance.SplitArgs("//;\n1;2", ";");
            Assert.That(resultList, Is.EquivalentTo(expectedList));
        }

        [Test]
        public void ParseDelimiter_FromStringArgs_ReturnsTheDelimiter()
        {
            var instance = new StringCalculator();
            string result = instance.ParseDelimiter("//;\n1;2");
            Assert.That(result, Is.EqualTo(";"));
        }

        [Test]
        public void ParseList_StringList_ReturnsIntList()
        {
            var instance = new StringCalculator();
            List<string> argsList = new List<string>();
            argsList.Add("1");
            argsList.Add("2");
            List<int> expectedList = new List<int>(); ;
            expectedList.Add(1);
            expectedList.Add(2);
            List<int> resultList = instance.ParseList(argsList);
            Assert.That(resultList, Is.EquivalentTo(expectedList));
        }
    }
}
