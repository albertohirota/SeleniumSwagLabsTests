Feature: ShoppingTests

A short summary of the feature

@Sanity
Scenario: Filter in descendant name
	Given Logged with user 'standard_user'
	When Select filter 'za'
	Then products should be in descendant name

@Sanity
Scenario: Price of Product
	Given Logged with user 'standard_user'
	Then price '$49.99' of product 'Sauce Labs Fleece Jacket'

@Sanity
Scenario: Description of the Product
	Given Logged with user 'standard_user'
	Then part of text 'quarter-zip fleece jacket' of product 'Sauce Labs Fleece Jacket'

@Sanity
Scenario: Add to Cart Text of Button
	Given Logged with user 'standard_user'
	Then Button text 'Add to cart' of product 'Sauce Labs Bike Light'

@Sanity
Scenario: Remove Text of Button
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	Then Remove Button text 'Remove' of product 'Sauce Labs Bike Light'

@Sanity
Scenario: Picture on item with different userNames
	Given Logged with user <userNames>
	Then Picture '/static/media/bike-light-1200x1500.37c843b0.jpg' of 'Sauce Labs Bike Light'
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |

@Regression
Scenario: Filter in ascendant name
	Given Logged with user 'standard_user'
	When Select filter 'za'
	And Select filter 'az'
	Then products should be in ascendant name

@Regression
Scenario: Filter in ascendant price
	Given Logged with user 'standard_user'
	When Select filter 'lohi'
	Then products should be in ascendant price

@Regression
Scenario: Filter in descendant price
	Given Logged with user 'standard_user'
	When Select filter 'hilo'
	Then products should be in descendant price

@Regression
Scenario: Add with Problem User
	Given Logged with user <userNames>
	When Click Add to cart button of product 'Sauce Labs Bolt T-Shirt'
	Then Remove Button text 'Remove' of product 'Sauce Labs Bolt T-Shirt'
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |