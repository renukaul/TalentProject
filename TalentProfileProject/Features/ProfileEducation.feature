Feature: ProfileEducation

Education is added,Updated and deleted sucessfully

Scenario: TC001_Add Education
	Given Logged in Sucessfully and goto Education tab
	When Education is added
	Then Education  Should be added sucessfully


Scenario Outline: TC002_Update Education
	Given Logged in Sucessfully and goto Education tab
	When Education is Updated 
	Then  Education Should be Updated  sucessfully



	Scenario Outline: TC003_Delete Education
	Given Logged in Sucessfully and goto Education tab
	When Education is Deleted 
	Then  Education Should be Deleted  sucessfully
