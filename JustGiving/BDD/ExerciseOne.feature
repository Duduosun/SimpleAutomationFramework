Feature: ExerciseOne
	As a Candidate completing JustGiving Recruitment Test
	I want to register 2 new user accounts using 1 SpecFlow feature file and scenario
	So as to verify the user is logged in

@exerciseone
Scenario: Exercise One
	Given JustGiving Recruitment Test Page
	When I register a new user account
	Then The new user is logged in
	Then I register a second new user account
	Then The second new user is logged in