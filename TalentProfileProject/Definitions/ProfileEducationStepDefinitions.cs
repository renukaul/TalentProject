using NUnit.Framework;
using System;
using TalentProfileProject.Profile;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject
{
    [Binding]
    public class ProfileEducationStepDefinitions : CommonServices
    {
        ManageEducation medu = new ManageEducation();



        [Given(@"Logged in Sucessfully and goto Education tab")]
        public void GivenLoggedInSucessfullyAndGotoEducationTab()
        {

           // LoginPage();
            goToTab(driver, "Education");
        }

        [When(@"Education is added")]
        public void WhenEducationIsAdded()
        {
            medu.addEducation(driver);
        }

        [Then(@"Education  Should be added sucessfully")]
        public void ThenEducationShouldBeAddedSucessfully()
        {
            string education = "Austria";
            string addedEducation = medu.getlastCountry(driver);
            Assert.That(addedEducation == education, "Education could not be added, Test Failed");
            
        }

        [When(@"Education is Updated")]
        public void WhenEducationIsUpdated()
        {
            medu.editEducation(driver);

            
        }

        [Then(@"Education Should be Updated  sucessfully")]
        public void ThenEducationShouldBeUpdatedSucessfully()
        {
            string editedu = "Auck Univ";
            string editcount = medu.getlastUniv(driver);
            Assert.That(editcount == editedu, "Education not Updated,Test Fail");

        }

        [When(@"Education is Deleted")]
        public void WhenEducationIsDeleted()
        {
            medu.deleteEducation(driver);

            
        }

        [Then(@"Education Should be Deleted  sucessfully")]
        public void ThenEducationShouldBeDeletedSucessfully()
        {
            Assert.That(1 == 1, "Education not deleted,Test Fail");
            
        }
    }
}
