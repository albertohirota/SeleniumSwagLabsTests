Feature: LoginTests

A short summary of the feature
@Sanity
Scenario Outline: Login with different userNames
	Given Enter password with <userNames> 
	When user performance login page should be less than 2 seconds
	Then user should be logged

	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |
	| 'performance_glitch_user' |
	| 'locked_out_user'         |

@Sanity
Scenario: Validate Swag logo
	Then valid logo	
	
@Sanity
Scenario: Logout with valid user
	Given Enter user 'standard_user' and password
	When click button Login
	And click logout
	Then user should be not logged

@Regression
Scenario: Login with locked user
	Given Enter user 'locked_out_user' and password
	When click button Login
	Then user locked error

@Regression
Scenario: Login with problem user
	Given Enter user 'problem_user' and password
	When click button Login
	Then user problem error
