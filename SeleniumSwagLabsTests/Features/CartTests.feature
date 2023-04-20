Feature: CartTests

A short summary of the feature

@Sanity
Scenario: Show cart added items from list
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	Then Cart Icon Show 1

@Sanity
Scenario: Show cart added items from details item
	Given Logged with user 'standard_user'
	When Click product 'Sauce Labs Bike Light'
	And Click Add Button in Items Details
	Then Cart Icon Show 1

@Regression
Scenario: Show cart with items added from the list
	Given Logged with user <userNames>
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Add to cart button of product 'Sauce Labs Fleece Jacket'
	Then Cart Icon Show 2
	Examples:
	| userNames       |
	| 'standard_user' |
	| 'problem_user'  |

@Regression
Scenario: Update Shopping Cart
	Given Logged with user <userNames>
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Add to cart button of product 'Sauce Labs Fleece Jacket'
	And Click Shopping Cart
	And Remove item 'Sauce Labs Bike Light'
	Then Cart Icon Show 1
	Examples:
	| userNames                |
	| 'standard_user'           |
	| 'problem_user'            |

@Regression
Scenario: Validate product price in Cart
	Given Logged with user <userNames>
	When Click Add to cart button of product 'Sauce Labs Backpack'
	And Click Shopping Cart
	Then Cart show price '$29.99' of item 'Sauce Labs Backpack'
	Examples:
	| userNames       |
	| 'standard_user' |
	| 'problem_user'  |

@Regression
Scenario: Validate description in Cart
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Onesie'
	And Click Shopping Cart
	Then Cart show description 'Sauce Labs Onesie' of item 'Sauce Labs Onesie'

@Regression
Scenario: Validate the Back button text
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Onesie'
	And Click Shopping Cart
	Then The button back text is 'Continue Shopping'

@Regression
Scenario: Validate the Checkout button text
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Onesie'
	And Click Shopping Cart
	Then The button checkout text is 'Checkout'