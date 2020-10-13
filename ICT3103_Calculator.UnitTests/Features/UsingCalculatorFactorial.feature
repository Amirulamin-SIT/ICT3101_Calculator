Feature: UsingCalculatorFactorial
	In order to find factorials
	As a mathis
	I want to be told the factorial of a number

@Factorial
Scenario: Add 3 numbers
	Given a calculator
	When I enter "3"
	Then the result should be "6"

@Factorial
Scenario: Add 1 numbers
	Given a calculator
	When I enter "1"
	Then the result should be "1"