Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As a mathifyer
	I want to be able to use a calc to do this shit

@availability
Scenario: Calcculating MTBF
	Given I have a calculator
	When I have entered "?" and "?" into the calculator and MTBF
	Then the MTBF result should be "?"

	@availability
	Scenario: Calculating Availability
	Given I hava a calculator
	When I have entered "?" and "?" into the calculator and pressed Availability
	Then the availability result should be "?"