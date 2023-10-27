using NUnit.Framework;
using testGarden;

namespace spacFlowTests.StepDefinitions
{
    [Binding]
    public class LeapYearSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private LeapYear _instance;
        private bool _isLeap;

        public LeapYearSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"a calendar I just opened")]
        public void GivenACalendarIJustOpened()
        {
            _instance = new LeapYear();
        }

        [When(@"I search if the year (.*) is leap")]
        public void WhenISearchIfTheYearIsLeap(int year)
        {
            _isLeap = _instance.IsLeap(year);
        }

        [Then(@"this year is not leap")]
        public void ThenThisYearIsNotLeap()
        {
            Assert.That(_isLeap, Is.False);
        }

        [Then(@"this year is leap")]
        public void ThenThisYearIsLeap()
        {
            Assert.That(_isLeap, Is.True);
        }
    }
}