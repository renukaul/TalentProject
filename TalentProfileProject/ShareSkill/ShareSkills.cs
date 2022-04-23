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


namespace TalentProfileProject.ShareSkill
{
    public class ShareSkills
    {
        AutoItX3 fileUpload = new AutoItX3();

        IWebDriver driver;

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

        

        public ShareSkills(IWebDriver _driver)
        {
            driver = _driver;
        }

        public void InitializeElements()
        {
            Thread.Sleep(3000);
            IWebElement addbtn = driver.FindElement(By.XPath("//div/section[1]/div/div[2]/a"));
            addbtn.Click();

            Thread.Sleep(2000);
            Title = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));

            Thread.Sleep(2000);
            Description = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));

            Thread.Sleep(2000);
            Category = driver.FindElement(By.XPath("//div[2]/div/form/div[3]/div[2]/div/div/select"));

            
            ServiceTag = driver.FindElement(By.XPath("//div/form/div[4]/div[2]/div/div/div/div/input"));

            ServiceType = driver.FindElements(By.Name("serviceType")).ToList();

            LocationType = driver.FindElements(By.Name("locationType")).ToList();

            Thread.Sleep(2000);
            StartDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            
            Thread.Sleep(2000);
            EndDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));

            SkillTrade = driver.FindElements(By.Name("skillTrades")).ToList();

            

            WrkSample = driver.FindElement(By.XPath("//div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));

            Active = driver.FindElements(By.Name("isActive")).ToList();

        }


        public void initializeSubCategory()
        {
            Thread.Sleep(2000);
            SubCategory = driver.FindElement(By.XPath("//div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
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

        public void addShareSkill() //IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement saveBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[11]/div/input[1]"));
            saveBtn.Click();

            Thread.Sleep(2000);
            takeScreenShot(); // driver);
            Thread.Sleep(1000);

        }


        public string getCategory() //IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement Category = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
            return Category.Text;

        }
        public void editShareSkill() //IWebDriver driver)
        {

            Thread.Sleep(2000);
            IWebElement managelisting = driver.FindElement(By.XPath("//section[1]/div/a[3]"));
            managelisting.Click();

            Thread.Sleep(2000);
            IWebElement editBtn = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            editBtn.Click();

            Thread.Sleep(2000);
            IWebElement titletxtbox = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            /*titletxtbox.Click();*/
            titletxtbox.Clear();
            titletxtbox.SendKeys("Application Technology");

            Thread.Sleep(2000);
            IWebElement DescTxtArea = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            DescTxtArea.Click();
            DescTxtArea.Clear();
            DescTxtArea.SendKeys("Application Technology Role");

            Thread.Sleep(2000);
            IWebElement saveBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[11]/div/input[1]"));
            saveBtn.Click();

        }

        public string getTitle() //IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement title = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            return title.Text;

        }
        public string getDescrition() //IWebDriver driver)
        {
            IWebElement description = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
            return description.Text;

        }

        public void deleteshareskill() //IWebDriver driver)
        {


            Thread.Sleep(2000);
            IWebElement managelisting = driver.FindElement(By.XPath("//section[1]/div/a[3]"));
            managelisting.Click();

            Thread.Sleep(2000);
            IWebElement delBtn = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]"));
            delBtn.Click();

            IWebElement confirmDel = driver.FindElement(By.XPath("//div[2]/div/div[3]/button[2]"));
            confirmDel.Click(); 

          
        }

        public void takeScreenShot() //IWebDriver driver)
        {
           string screenshotFileName = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Screenshot"
                + Path.DirectorySeparatorChar + "Screentshot_" + DateTime.Now.ToString("ddMMyyyy HHmmss") + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Png);
        }

    }
}
