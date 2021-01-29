Feature: Login

Scenario: Go to Eaapp and login with valid credentials
	Given I am on the Eaapp Page
	When I click login
	And I enter the login credendtials
	Then I should see the employee details link

Scenario: Go to Eaapp and login with invalid credentials
	Given I am on the Eaapp Page
	When I click login
	And I enter invalid login credendtials
	Then I should not see the employee details link