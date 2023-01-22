Feature: Login

Login and Logout tests

@login_with_valid_credentials
Scenario: Login with valid credentials
	Given the user is on the home page
	When the user enters valid credentials
	Then the user is successfully logged in

@try_to_login_with_invalid_credentials
Scenario: Unable to login with invalid credentials
	Given the user is on the home page
	When the user enters invalid credentials
	Then the user is not able to log in