using ICT3101_Calculator;
using System;
using TechTalk.SpecFlow;

namespace ICT3103_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"I hava a calculator")]
        public void GivenIHavaACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndMTBF(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and pressed Availability")]
        public void WhenIHaveEnteredAndIntoTheCvalculatorAndPressedAvailability(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
