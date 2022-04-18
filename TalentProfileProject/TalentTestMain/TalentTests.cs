using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TalentProfileProject.ShareSkill;
using TalentProfileProject.Utilities;

namespace TalentProfileProject
{

    [TestFixture]
    public class TalentTests : CommonServices
    {

        

        ShareSkills objshareskill = new ShareSkills();
       
        ExtentReports rep;
        ExtentTest test;



        [OneTimeSetUp]
        public void Login()
        {
            

            rep =  getInstance();
            driver = new ChromeDriver();
            LoginPage();
            Thread.Sleep(2000);
            objshareskill.takeScreenShot(driver);
           
        }
       
        [Test, Order(1), Description("This will create new records")]
        public void TC001_CreateShareSkill_Test()
        {
            try
            {
                test = rep.CreateTest("ShareSkill Create Application");
                test.Log(Status.Info, "Starting to Create the shareskill");

                objshareskill.addShareSkill(driver);
                string cat = objshareskill.getCategory(driver);
                Assert.That(cat == "Programming & Tech", "Test Fail");
                test.Log(Status.Pass, "Record Added");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Record not added");
            }

        }

        [Test, Order(2) ,Description("This will edit records")]
        public void TC002_EditShareSkill()
        {
            try
            {
                test = rep.CreateTest("ShareSkill Update Application");
                test.Log(Status.Info, "Before unpdating");
                objshareskill.editShareSkill(driver);
                string title = objshareskill.getTitle(driver);
                Assert.That(title == "Application Technology", "Test Fail");
                string des = objshareskill.getDescrition(driver);
                Assert.That(des == "Application Technology Role", "Test Fail");
                test.Log(Status.Pass, "Record Upated");
            }
            catch(Exception e)
            {
                test.Log(Status.Fail, "Record Could not be updated" + e.StackTrace);
            }
            
        }


        [Test, Order(3), Description("This will delete record")]
        public void TC003_DeleteShareSkill()
        {
            try
            {
                test = rep.CreateTest("Shareskill Delete Record");
                test.Log(Status.Info, "Before deleting a record");
                objshareskill.deleteshareskill(driver);
                test.Log(Status.Pass, "Record deleted successfully");
            }
            catch (Exception e)
            {
                test.Log(Status.Fail, "Record not deleted" + e.StackTrace);
            }


        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            rep.Flush();
            driver.Close();
            driver.Quit();
        }


    }
}