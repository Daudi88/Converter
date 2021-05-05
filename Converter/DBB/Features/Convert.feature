Feature: Convert
	As an amateur baker 
	I want to be able to convert from American measurements to Swedish
	so that I can know what I can use
	

Scenario: Convert from american measurment to Swedish
	Given that I need an American cup
	And the decimals are rounded to 1
	When the amount of cups is 1
	Then the Swedish amount is 2.4 dl