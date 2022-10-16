Feature: RomanizingNumbers


@mytag
Scenario: Simple 2000
	Given input of 2000
	When converted to Roman numerals
	Then the result should be mm

Scenario: Expected Roman Numeral Output
	Given input of <number>
	When converted to Roman numerals
	Then the result should be <expectedRomanNumerals>

	Examples: 
		| number | expectedRomanNumerals |
		| 3      | iii                   |
		| 4      | iv                    |
		| 5      | v                     |
		| 6      | vi                    |
		| 8      | viii                  |
		| 9      | ix                    |
		| 10     | x                     |
		| 11     | xi                    |
		| 27     | xxvii                 |
		| 29     | xxix                  |
		| 30     | xxx                   |
		| 31     | xxxi                  |
		| 777    | dcclxxvii             |
		| 999    | cmxcix                |
		| 1999   | mcmxcix               |
		| 2021   | mmxxi                 |
		| 4000   | error			     |
		| 0      |		                 |
		| -1     | error			     |
		| -100   | error			     |