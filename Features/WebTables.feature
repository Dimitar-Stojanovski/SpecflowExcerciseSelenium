Feature: WebTables

As a user this will be a demo of creating and verifying records in a webtable on DEMOQA

Background: 
Given I navigate to the webtables URL

@tag1
Scenario: As a user I want to create a record in the table
	Given I click add button
	When I enter all required inputs
	| firstname | lastname | email         | age | salary | department |
	| John      | Doe      | john@mail.com | 13  | 1500   | Marketing  |
	And I click submit button
	Then I want to verify that the user is created
