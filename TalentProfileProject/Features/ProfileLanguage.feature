Feature: ProfileLanguage

Language is added,Updated and deleted sucessfully

Scenario: TC001_Add Language
	Given Logged in Sucessfully
	When Language is added
	Then Should be added sucessfully


Scenario Outline: TC002_Update Language
	Given Logged in Sucessfully
	When Language is Updated with '<Language>','<Level>' data
	Then Should be Updated with '<Language>','<Level>'  sucessfully


Examples: 
	| Language | Level |
	| English | Basic |
	| Spanish | Conversational |
	| German  | Fluent |


	Scenario Outline: TC003_Delete Language
	Given Logged in Sucessfully
	When Language is Deleted 
	Then Should be Deleted  sucessfully
