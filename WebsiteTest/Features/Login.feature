Feature: Login
	Check if login funtionality working fine

@mytag
Scenario: Verify login functionality
	Given I have navigated to application
	And I see application opened
	When I click login link
	And I enter username and password
	|Key			|Value				  |
	| UserName      | jpatil.14@gmail.com |
	| Password		| testtest			  |
	And I click login button
	Then I should be navigated to My Account page
	When I click Women link
	Then I should be navigated to Women Home page
	
