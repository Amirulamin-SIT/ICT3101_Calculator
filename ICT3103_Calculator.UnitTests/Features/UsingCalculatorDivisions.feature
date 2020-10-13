Feature: UsingCalculatorDivisions
	In order to conquer divisions
	As a division enthusiast
	I want to understand a variety of division operations

@Divisions
Scenario Outline: Dividing two numbers
	Given I have a calculator
	When I have entered "<value1>" and "<value2>" into the calculator and pressed divide
	Then the division result should be "<value3>"

	Examples:
		| value1 | value2 | value3 |
		| 1      | 2      | 0.5    |
		| 0      | 15     | 0      |
		| 0      | 0      | 1      |

@Divisions
Scenario: Dividing zero by a number
	Given I have a calculator
	When I have entered "15" and "0" into the calculator and pressed divide
	Then the division result should be positive infinity


@Divisions
Scenario: Dividing by another numberino
	Given I have a calculator
	When I have entered "15"
	And I have entered another number "10"
	Then the result should be "1.5"