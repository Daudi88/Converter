Feature: Convert
	As an amateur baker 
	I want to be able to convert from American measurements to Swedish
	so that I can know what I can use
	

Scenario: Convert from american cup to Swedish dl
	Given that the decimals are rounded to <decimal>
	When the amount of cups are <cup>
	Then the Swedish amount is <dl> dl
	Examples: 
	| cup  | decimal | dl  |
	| 1    | 1       | 2.4 |
	| 2    | 1       | 4.8 |
	| 0.5  | 0       | 1   |
	| 0.25 | 1       | 0.6 |


Scenario: Convert from american measurment to Swedish
	Given that I need <tablespoon> American tablespoons
	And the decimals are rounded to <decimal>
	Then the Swedish amount is <dl> dl
	Examples: 
	| tablespoon  | decimal | dl   |
	| 1			  | 2       | 0.15 |