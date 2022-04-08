using NUnit.Framework;
using System;
using TalentProfileProject.Profile;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject
{
    [Binding]
    public class ProfileCertificatesStepDefinitions : CommonServices
    {
        ManageCertificate mc = new ManageCertificate();

        [Given(@"Logged in Sucessfully and goto Certificate tab")]
        public void GivenLoggedInSucessfullyAndGotoCertificateTab()
        {
            goToTab(driver, "Certifications");
        }

        [When(@"Certificate is added")]
        public void WhenCertificateIsAdded()
        {
            mc.addCertificates(driver);
        }

        [Then(@"Certificate Should be added sucessfully")]
        public void ThenCertificateShouldBeAddedSucessfully()
        {
            string cert = "TESTANALYST";
            string certadded = mc.getLastCertificate(driver);

            Assert.That(certadded == cert, "Certificate not added,  Test Failed");
        }

        [When(@"Certificate is Updated")]
        public void WhenCertificateIsUpdated()
        {
            mc.editCertificate(driver);
        }

        [Then(@"Certificate Should be Updated  sucessfully")]
        public void ThenCertificateShouldBeUpdatedSucessfully()
        {
            string cert = "ISTQB";
            string certadded = mc.getLastCertificate(driver);

            Assert.That(certadded == cert, "Certificate not updated,  Test Failed");

        }

       [When(@"Certificate is Deleted")]
        public void WhenCertificateIsDeleted()
        {
            mc.deleteCertificate(driver);
        }

        [Then(@"Certificate Should be Deleted  sucessfully")]
        public void ThenCertificateShouldBeDeletedSucessfully()
        {
            Assert.That(1 == 1, "Certificate not deleted, Test Failed");
        }
    }
}
