Feature: ItemTests

A short summary of the feature

@Sanity
Scenario: Show correct name of item clicked
	Given Logged with user <userNames>
	When Click product 'Sauce Labs Bolt T-Shirt'
	Then product expected 'Sauce Labs Bolt T-Shirt'
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |

@Regression
Scenario: Show correct price of item clicked
	Given Logged with user <userNames>
	When Click product 'Sauce Labs Bike Light'
	Then price expected '$9.99'
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |

@Regression
Scenario: Show correct description of item clicked
	Given Logged with user <userNames>
	When Click product 'Sauce Labs Bike Light'
	Then description expected ' desired state in testing but'
	Examples:
	| userNames       |
	| 'standard_user' |
	| 'problem_user'  |

@Regression
Scenario: Show correct button text of item clicked
	Given Logged with user <userNames>
	When Click product 'Sauce Labs Bike Light'
	And Click Add Button in Items Details
	Then Button description 'Remove'
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |


