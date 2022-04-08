Feature: ProfileSkill

Skill is added,Updated and deleted sucessfully

Scenario: TC001_Add Skill
	Given Logged in Sucessfully and goto skill tab
	When Skill is added
	Then Skill Should be added sucessfully


Scenario Outline: TC002_Update Skill
	Given Logged in Sucessfully and goto skill tab
	When Skill is Updated 
	Then  Skill Should be Updated  sucessfully



	Scenario Outline: TC003_Delete Skill
	Given Logged in Sucessfully and goto skill tab
	When Skill is Deleted 
	Then  Skill Should be Deleted  sucessfully
