Feature: HomePage

Tests related to the functionalities on the home page

Background:
	Given the user is on the home page
	When the user enters valid credentials
	Then the user is successfully logged in

@sort_products_by_filter
Scenario: Sord products on the grid by filter drop down
	When the user selects <order> from the filter drop down
	Then the results are sorted correctly by <order>
Examples:
	| order               |
	| Name (Z to A)       |
	| Name (A to Z)       |
	| Price (low to high) |
	| Price (high to low) |


@redirect_to_official_website
Scenario: Redirect to the official SauceLabs website from about menu option
	When the user select About from the menu options
	Then the user is redirected to the official SauceLabs website

@purchase_product
Scenario: Purchase a product which was added to the cart
Given the user adds a Sauce Labs Backpack product to the cart
And the user navigates to Your Cart page
And the user proceeds with the checkout
When the user enters the mandatory personal info
And the user submits the form
And the user finishes the order
Then the product is purchased and the checkout is completed