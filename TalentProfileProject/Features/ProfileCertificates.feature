Feature: ProfileCertificates

Certificate is added,Updated and deleted sucessfully

Scenario: TC001_Add Certificate
	Given Logged in Sucessfully and goto Certificate tab
	When Certificate is added
	Then Certificate Should be added sucessfully


Scenario Outline: TC002_Update Certificate
	Given Logged in Sucessfully and goto Certificate tab
	When Certificate is Updated 
	Then  Certificate Should be Updated  sucessfully



Scenario Outline: TC003_Delete Certificate
	Given Logged in Sucessfully and goto Certificate tab
	When Certificate is Deleted 
	Then  Certificate Should be Deleted  sucessfully
