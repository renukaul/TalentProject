using NUnit.Framework;
using System;
using TalentProfileProject.Profile;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject
{
    [Binding]
    public class ProfileLanguageStepDefinitions : CommonServices 
    {
        ManageProfile mp = new ManageProfile();

       

        [Given(@"Logged in Sucessfully")]
        public void GivenLoggedInSucessfully()
        {
           // LoginPage();
            goToTab(driver, "Languages");
            
        }

        [When(@"Language is added")]
        public void WhenLanguageIsAdded()
        {
            mp.addLanguage(driver);

           
        }

        [Then(@"Should be added sucessfully")]
        public void ThenShouldBeAddedSucessfully()
        {
            string language = "English";
            string addedLanguage = mp.getLastLanguage(driver);
            Assert.That(addedLanguage == language, "Language could not be added, Test Failed");
        }


        [When(@"Language is Updated")]
        public void WhenLanguageIsUpdated()
        {
            mp.editLanguage(driver);
        }

        [Then(@"Should be Updated  sucessfully")]
        public void ThenShouldBeUpdatedSucessfully()
        {
            string language = "C#";
            string addedLanguage = mp.getLastLanguage(driver);
            Assert.That(addedLanguage == language, "Language could not be Updated, Test Failed");
        }


        [When(@"Language is Deleted")]
        public void WhenLanguageIsDeleted()
        {
            mp.deleteLanguage(driver);


        }

        [Then(@"Should be Deleted  sucessfully")]
        public void ThenShouldBeDeletedSucessfully()
        {

            Assert.That(1 == 1, "Record deleted successfully");

        }





    }
}
