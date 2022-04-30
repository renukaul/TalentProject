using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.Collections;
using TalentShareSkillProject.Utilities;

namespace TalentShareSkillProject.ShareSkill
{

    public class ShareSkills
    {
        AutoItX3 fileUpload = new AutoItX3();

        IWebDriver driver;

        public string parentDir = Directory.GetParent(@"../../../").FullName;


        //  Web Elements Definition
        public IWebElement Title { get; set; }
        public IWebElement Description { get; set; }
        public IWebElement Category { get; set; }

        public IWebElement SubCategory { get; set; }

        public IWebElement ServiceTag { get; set; }
        public List<IWebElement> ServiceType { get; set; }
        public List<IWebElement> LocationType { get; set; }
        public IWebElement StartDate { get; set; }
        public IWebElement EndDate { get; set; }
        public List<IWebElement> SkillTrade { get; set; }
        public IWebElement SkillExchangeTag { get; set; }
        public IWebElement Credit { get; set; }
        public List<IWebElement> Active { get; set; }

        public IWebElement WrkSample { get; set; }

        public IWebElement AddButton { get; set; }  

        public IWebElement PopupMsg { get; set; }



        // Constructor
        public ShareSkills(IWebDriver _driver)
        {
            driver = _driver;
        }

        // Add Btn 
        public void AddBtn()
        {
            AddButton = driver.FindElement(By.XPath("//div/section[1]/div/div[2]/a"));
            AddButton.Click();
        }


        //Web Elements Initialization
        public void InitializeElements()
        {

            //AddButton = driver.FindElement(By.XPath("//div/section[1]/div/div[2]/a"));
            //AddButton.Click();


            // Title = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            Title = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input",2)));

            //Description = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            Description = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath", "//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea",2)));

            //Category = driver.FindElement(By.XPath("//div[2]/div/form/div[3]/div[2]/div/div/select"));
            Category = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div/form/div[3]/div[2]/div/div/select",2)));

            // ServiceTag = driver.FindElement(By.XPath("//div/form/div[4]/div[2]/div/div/div/div/input"));
            ServiceTag = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div/form/div[4]/div[2]/div/div/div/div/input",2)));

            ServiceType = driver.FindElements(By.Name("serviceType")).ToList();
            
            LocationType = driver.FindElements(By.Name("locationType")).ToList();

            //StartDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            StartDate = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input",2)));

            //EndDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            EndDate = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input",2)));

            SkillTrade = driver.FindElements(By.Name("skillTrades")).ToList();
                       

            WrkSample = driver.FindElement(By.XPath("//div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

            Active = driver.FindElements(By.Name("isActive")).ToList();

        }


        public void initializeSubCategory()
        {
            
            SubCategory = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//div/form/div[3]/div[2]/div/div[2]/div[1]/select",2)));
        }

        public void initializeSkillTrade(bool skilltrade)
        {
            if(skilltrade)
            {
                SkillExchangeTag = driver.FindElement(By.XPath("//div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));

               
            }
            else
            {
                Credit = driver.FindElement(By.Name("charge"));
            }

        }


        public void uploadFile(string filename)
        {
            fileUpload.WinActivate("Open");

            string filepath =  parentDir 
                + Path.DirectorySeparatorChar + "FileUpload"
                + Path.DirectorySeparatorChar + filename;

            fileUpload.Send(filepath);
            Thread.Sleep(2000);
            fileUpload.Send("{ENTER}");
        }

        public void addShareSkill() //IWebDriver driver)
        {

            // IWebElement saveBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[11]/div/input[1]"));
            IWebElement saveBtn = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div/form/div[11]/div/input[1]",2)));
            saveBtn.Click();

            takeScreenShot(); // driver);
            
        }


        public string getCategory() //IWebDriver driver)
        {
            IWebElement Category = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]",2)));
            return Category.Text;

        }

        public void editShareSkill() //IWebDriver driver)
        {

            //IWebElement managelisting = driver.FindElement(By.XPath("//section[1]/div/a[3]"));
            IWebElement managelisting = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//section[1]/div/a[3]",2)));
            managelisting.Click();

            //IWebElement editBtn = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            IWebElement editBtn = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i",2)));
            editBtn.Click();

            //IWebElement titletxtbox = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            /*IWebElement titletxtbox = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input",2)));
            titletxtbox.Clear();
            titletxtbox.SendKeys("Application Technology");*/

            Title.Clear();
            Title.SendKeys("Application Technology");


            IWebElement DescTxtArea = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            DescTxtArea.Click();
            DescTxtArea.Clear();
            DescTxtArea.SendKeys("Application Technology Role");

            IWebElement saveBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[11]/div/input[1]"));
            saveBtn.Click();

        }

        public string getTitle() //IWebDriver driver)
        {
            //IWebElement title = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            IWebElement title = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]",2)));
            return title.Text;

        }
        public string getDescrition() //IWebDriver driver)
        {
            IWebElement description = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
            return description.Text;

        }

        public string deleteshareskill() //IWebDriver driver)
        {

            

            // IWebElement managelisting = driver.FindElement(By.XPath("//section[1]/div/a[3]"));
            IWebElement managelisting = driver.FindElement(By.XPath("//section[1]/div/a[3]"));
            managelisting.Click();

            
            // IWebElement delBtn = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]"));
            IWebElement delBtn = driver.FindElement(By.XPath(wait.waitByClick(driver,"xPath","//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]",2)));
            delBtn.Click();

            IWebElement confirmDel = driver.FindElement(By.XPath("//div[2]/div/div[3]/button[2]"));
            confirmDel.Click();

            PopupMsg = driver.FindElement(By.XPath(wait.waittovisibility(driver,"xPath","/html/body/div[1]/div",2)));

            return PopupMsg.Text;

            

          
        }

        public void takeScreenShot() //IWebDriver driver)
        {
           string screenshotFileName = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Screenshot"
                + Path.DirectorySeparatorChar + "Screentshot_" + DateTime.Now.ToString("ddMMyyyy HHmmss") + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Png);
            Thread.Sleep(1000);

        }

    }
}
