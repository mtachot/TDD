Feature: LeapYear


Scenario: a year not divisible by 4 is not leap
	Given a calendar I just opened
	When I search if the year 2001 is leap
	Then this year is not leap

Scenario: a year divisible by 4 is leap
	Given a calendar I just opened
	When I search if the year 2004 is leap
	Then this year is leap

Scenario: by exception, a year divisible by 100 is not leap
	Given a calendar I just opened
	When I search if the year 1900 is leap
	Then this year is not leap

Scenario: by exception, a year divisible by 400 is leap
	Given a calendar I just opened
	When I search if the year 2000 is leap
	Then this year is leap