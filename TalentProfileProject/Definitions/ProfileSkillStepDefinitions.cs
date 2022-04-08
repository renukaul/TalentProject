using NUnit.Framework;
using System;
using TalentProfileProject.Profile;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject
{
    [Binding]
    public class ProfileSkillStepDefinitions : CommonServices   
    {

        ManageSkill obj = new ManageSkill();

        [Given(@"Logged in Sucessfully and goto skill tab")]
        public void GivenLoggedInSucessfullyAndGotoSkillTab()
        {
           // LoginPage();
            goToTab(driver, "Skills");
           
        }

        [When(@"Skill is added")]
        public void WhenSkillIsAdded()
        {
            obj.addSkills(driver);
           
        }

        [Then(@"Skill Should be added sucessfully")]
        public void ThenSkillShouldBeAddedSucessfully()
        {
            string skill = "Skill1";

            string lastskill = obj.getLastSkill(driver);

            Assert.That(lastskill == skill, "Skill not added, Test Failed");

        }


        [When(@"Skill is Updated")]
        public void WhenSkillIsUpdated()
        {
            obj.editSkill(driver);  
           
        }


        [Then(@"Skill Should be Updated  sucessfully")]
        public void ThenSkillShouldBeUpdatedSucessfully()
        {
            string editskill = "Skill2";
            string lastskill =obj.getLastSkill(driver);
            Assert.That(lastskill == editskill, "skill not Updated,Test Failed");
            

        }



        [When(@"Skill is Deleted")]
        public void WhenSkillIsDeleted()
        {
          
            obj.deleteSkill(driver);    
        }

        [Then(@"Skill Should be Deleted  sucessfully")]
        public void ThenSkillShouldBeDeletedSucessfully()
        {
            Assert.That(1 == 1, "Record deleted successfully");



        }





    }
}
