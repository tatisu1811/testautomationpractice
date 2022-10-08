Feature: Search
	In order to find products
	As a user
	I want to be able to search for a term
	
@mytag
Scenario: User can search for a term
	Given user enters 'dress' search term
	When user submits the search
	Then results for "dress" ssearch term are displayed
