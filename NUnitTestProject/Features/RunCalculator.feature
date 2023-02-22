Feature: RunCalc

A short summary of the feature

@tag1
Scenario: 01)Run the calculator
	Given I launch the Windows calculator application

	

	

	Given I divide two numbers
	Scenario:02) x multiple with x


Given I launch the Windows calculator application
Given exponent
Scenario: 03)something other with calculator
	Given the first number is 70
	And the second number is 60
	When the two numbers are substracted
	Then the result should be 10

Scenario Outline: 04)Add two numbers permutations
	Given the first number is <First number>
	And the second number is <Second number>
	When the two numbers are added
	Then the result should be <Expected result>

Examples:
	| First number | Second number | Expected result |
	| 0            | 0             | 0               |
	| -1           | 10            | 9             |
	| 6            | 9             | 15              |
	| 60            | 9             | 69             |
	| 66           | 1             | 67             |
	| 23            | 2            | 25              |
	| 65           | 9             | 74              |
	Scenario: 05)something with other app
	Given Given I launch the Windows loto application
	Scenario: 06)something with notepad app
	Given Given I launch the Windows notepad application
	Scenario: 08)something different from git
