Feature: This test suite contains test scenario for Time and Material page

A short summary of the feature

@tag1
Scenario: Create a Time and Material record
	Given User logs into TurnUp Portal
	And User navigates to Time and Material page
	When User creates a new Time and Material record
	Then TurnUp portal should save the new Time and material record
