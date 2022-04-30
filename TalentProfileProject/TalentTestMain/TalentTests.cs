using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Data;
using System.IO;
using System.Threading;
using TalentShareSkillProject.DataUtility;
using TalentShareSkillProject.ShareSkill;
using TalentShareSkillProject.Utilities;
using System.Collections.Generic;

namespace TalentShareSkillProject
{

    [TestFixture]
    public class TalentTests : CommonServices
    {



        ShareSkills objshareskill; // = new ShareSkills();

        ExcelUtility excelUtility = new ExcelUtility();
       
        ExtentReports rep;
        ExtentTest test;

        //List<DataCollection> data;

        [OneTimeSetUp]
        public void InitiateProcess()
        {
            excelUtility.populateDataCollectionList();
            rep =  getInstance();
            driver = new ChromeDriver();
            objshareskill = new ShareSkills(driver);
            LoginPage();
            objshareskill.takeScreenShot(); // driver);
            
        }
       
        
        [Test, Order(1), Description("This will create new records")]
        public void TC001_CreateShareSkill_Test()
        {
            try
            {
                test = rep.CreateTest("ShareSkill Create Application");
                test.Log(Status.Info, "Starting to Create the shareskill");

               
                for (int i = 0; i < excelUtility.TotalRows; i++)
                {
                    try
                    {
                        test.Log(Status.Info, "Processing data from excel.\n Rownum " + i);
                        
                            objshareskill.AddBtn();
                            objshareskill.InitializeElements();
                        
                        //Title    
                        //objshareskill.Title.SendKeys("Programming Tech");
                        objshareskill.Title.SendKeys(excelUtility.readSingleRowData(i, "TITLE"));

                        //Description   
                        //objshareskill.Description.SendKeys("Test Analyst Role");
                        objshareskill.Description.SendKeys(excelUtility.readSingleRowData(i, "DESCRIPTION"));

                        objshareskill.takeScreenShot();


                        //Category
                        objshareskill.Category.Click();
                        //objshareskill.Category.SendKeys("Graphics & Design");
                        objshareskill.Category.SendKeys(excelUtility.readSingleRowData(i, "CATEGORY"));
                        objshareskill.Category.Click();

                        //Sub Category
                        objshareskill.initializeSubCategory();
                        objshareskill.SubCategory.Click();
                        //objshareskill.SubCategory.SendKeys("Logo Design");
                        objshareskill.SubCategory.SendKeys(excelUtility.readSingleRowData(i, "SUBCATEGORY"));
                        objshareskill.SubCategory.Click();

                        //Service Tag
                        objshareskill.ServiceTag.Click();
                        //objshareskill.ServiceTag.SendKeys("Test Engineer");
                        objshareskill.ServiceTag.SendKeys(excelUtility.readSingleRowData(i, "SERVICETAG"));
                        objshareskill.ServiceTag.SendKeys(Keys.Enter);

                        //Service Type
                        objshareskill.ServiceType.ForEach(e =>
                        {
                            //  if (e.GetAttribute("value").Equals("1"))
                            if (e.GetAttribute("value").Equals(excelUtility.readSingleRowData(i, "SERVICETYPE")))
                            {
                                e.Click();
                            }
                        });

                        objshareskill.takeScreenShot();
                        
                        //Location Type
                        objshareskill.LocationType.ForEach(e =>
                        {
                            // if (e.GetAttribute("value").Equals("1"))
                            if (e.GetAttribute("value").Equals(excelUtility.readSingleRowData(i, "LOCATIONTYPE")))
                            {
                                e.Click();
                            }
                        });

                        //Start and End Date
                        //objshareskill.StartDate.SendKeys("04/17/2023");
                        objshareskill.StartDate.SendKeys(excelUtility.readSingleRowData(i, "STARTDATE"));
                        objshareskill.StartDate.Click();

                        //objshareskill.EndDate.SendKeys("04/27/2023");
                        objshareskill.EndDate.SendKeys(excelUtility.readSingleRowData(i, "ENDDATE"));
                        objshareskill.EndDate.Click();


                        //Skill Exchange
                        objshareskill.SkillTrade.ForEach(e =>
                        {
                            //if (e.GetAttribute("value").Equals("true"))
                            string skilltradevalue = excelUtility.readSingleRowData(i, "SKILLTRADE");
                            if (skilltradevalue == "true")
                            {
                                if (e.GetAttribute("value").Equals("true"))
                                {
                                    e.Click();

                                    Thread.Sleep(2000);
                                    objshareskill.initializeSkillTrade(true);
                                    objshareskill.SkillExchangeTag.Click();
                                    //objshareskill.SkillExchangeTag.SendKeys("Test Engineer & Desgning");
                                    objshareskill.SkillExchangeTag.SendKeys(excelUtility.readSingleRowData(i, "SKILLEXCHANGETAG"));
                                    objshareskill.SkillExchangeTag.SendKeys(Keys.Enter);


                                }
                            }
                            else
                            {
                                if (e.GetAttribute("value").Equals("false"))
                                {
                                    e.Click();
                                    objshareskill.initializeSkillTrade(false);
                                    objshareskill.Credit.Click();
                                    //objshareskill.Credit.SendKeys("9");
                                    objshareskill.Credit.SendKeys(excelUtility.readSingleRowData(i, "CREDIT"));
                                }
                            }
                        });


                        objshareskill.takeScreenShot();

                        objshareskill.WrkSample.Click();
                        objshareskill.uploadFile(excelUtility.readSingleRowData(i,"WRKSAMPLE"));



                        objshareskill.addShareSkill(); // driver);
                        string cat = objshareskill.getCategory(); // driver);
                        
                        Assert.That(cat == excelUtility.readSingleRowData(i,"CATEGORY"), "Test Fail");
                        test.Log(Status.Pass, "Record Added");


                    } // try within loop
                    catch (Exception ex)
                    {
                        test.Log(Status.Fail, "Record Failed --> " + i);
                    }

                }    
                   // string cat = objshareskill.getCategory(); // driver);

                    

                 //   Assert.That(cat == "Programming & Tech", "Test Fail");
                  //  test.Log(Status.Pass, "Record Added");
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
                objshareskill.editShareSkill(); // driver);
                string title = objshareskill.getTitle(); // driver);
                Assert.That(title == "Application Technology", "Test Fail");
                string des = objshareskill.getDescrition(); // driver);
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
                                
                string mesg = objshareskill.deleteshareskill(); // driver);
                
                Assert.That(mesg.Contains("deleted") ,"Record not deleted Test Failed");
              //  test.Log(Status.Pass, "Record deleted successfully");

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