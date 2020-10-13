﻿Feature: UsingCalculatorAdditions
	In order to avoid mistakes
	As a calculator user
	I want to be told the sum of two numbers

@Addition
Scenario: Add two numbers
	Given I have a calculator
	When I have entered "50" and "70" into the calculator and pressed add
	Then the result should be "120"

@Addition
Scenario Outline: Add zeroes for special cases
	Given I have a calculator
	When I have entered "<value1>" and "<value2>" into the calculator and pressed add
	Then the result should be "<value3>"

	Examples:
		| value1 | value2 | value3 |
		| 0      | 20     | 2      |
		| 20     | 0      | 200    |
		| 0      | 0      | 666    |