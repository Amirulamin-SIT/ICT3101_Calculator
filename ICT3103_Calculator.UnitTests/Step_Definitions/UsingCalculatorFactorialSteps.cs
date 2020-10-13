using ICT3101_Calculator;
using System;
using TechTalk.SpecFlow;

namespace ICT3103_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private Calculator _calculator;

        public UsingCalculatorFactorialSteps(Calculator calc)
        {
            this._calculator = calc;
        }

        [Given(@"a calculator")]
        public void GivenACalculator()
        {
            _calculator = new Calculator();
        }
        
        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(int p0)
        {
            _result = _calculator.Factorial(p0);
        }
    }
}
