using System;
using TechTalk.SpecFlow;
using ICT3101_Calculator;
using NUnit.Framework;

namespace ICT3103_Calculator.UnitTests.Step_Definitions
{
    public class CalcDummy
    {
        public Calculator calculator = new Calculator();
    }

    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private readonly CalcDummy calcDummy;
        private double _result;
        public UsingCalculatorAdditionsSteps(CalcDummy calc)
        {
            this.calcDummy = calc;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calcDummy.calculator = new Calculator();
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and pressed add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressedAdd(int p0, int p1)
        {
            _result = calcDummy.calculator.Add(p0, p1);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
