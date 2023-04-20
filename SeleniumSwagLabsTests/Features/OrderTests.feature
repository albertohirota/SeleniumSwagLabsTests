Feature: OrderTests

A short summary of the feature

@Sanity
Scenario: Complete Order
	Given Logged with user <userNames>
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Shopping Cart
	And Click checkout
	And Fillup user fields
	And Click Continue
	And Click Finish Order
	Then ValidateSucessOrderIcon
	Examples:
	| userNames       |
	| 'standard_user' |
	| 'problem_user'  |

@Regression
Scenario: Validate Order Total
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Shopping Cart
	And Click checkout
	And Fillup user fields
	And Click Continue
	Then Total Price should be '$10.79'

@Regression
Scenario: Validate Shipping Info
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Shopping Cart
	And Click checkout
	And Fillup user fields
	And Click Continue
	Then Shipping Information should be 'Free Pony Express Delivery!'

@Regression
Scenario: Validate Payment Info
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Shopping Cart
	And Click checkout
	And Fillup user fields
	And Click Continue
	Then Payment Information should be 'SauceCard #31337'

@Regression
Scenario: Total order with 2 items
	Given Logged with user 'standard_user'
	When Click Add to cart button of product 'Sauce Labs Backpack'
	When Click Add to cart button of product 'Sauce Labs Bike Light'
	And Click Shopping Cart
	And Click checkout
	And Fillup user fields
	And Click Continue
	Then Total Price should be '$43.18'
