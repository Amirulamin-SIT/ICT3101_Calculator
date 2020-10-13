using System;
using TechTalk.SpecFlow;
using ICT3101_Calculator;
using NUnit.Framework;

namespace ICT3103_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private readonly CalcDummy calcDummy;
        public double _result;

        public UsingCalculatorDivisionsSteps(CalcDummy calc)
        {
            this.calcDummy = calc;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and pressed divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressedDivide(int p0, int p1)
        {
            _result = calcDummy.calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }


        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered ""(.*)""")]
        public void WhenIHaveEntered(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        [When(@"I have entered another number ""(.*)""")]
        public void WhenIHaveEnteredAnotherNumber(int p0)
        {
            ScenarioContext.Current.Pending();
        }


    }
}
