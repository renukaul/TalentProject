using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TalentProfileProject.ShareSkill
{
    public class ShareSkills
    {

        

        public void addShareSkill(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement addbtn = driver.FindElement(By.XPath("//div/section[1]/div/div[2]/a"));
            addbtn.Click();

            takeScreenShot(driver);

            Thread.Sleep(2000);
            IWebElement titletxtbox = driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titletxtbox.SendKeys("Programming Tech");

            Thread.Sleep(2000);
            IWebElement desText = driver.FindElement(By.XPath("//div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            desText.SendKeys("Test Analyst Role");


            Thread.Sleep(2000);
            IWebElement dropDownCat = driver.FindElement(By.XPath("//div[2]/div/form/div[3]/div[2]/div/div/select"));
            dropDownCat.Click();
            dropDownCat.SendKeys("Programming & Tech");
            dropDownCat.Click();

            takeScreenShot(driver);

            Thread.Sleep(2000);
            IWebElement dropDownsubCat = driver.FindElement(By.XPath("//div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            dropDownsubCat.Click();
            dropDownsubCat.SendKeys("QA");
            dropDownsubCat.Click();


            Thread.Sleep(2000);
            IWebElement addNewTag = driver.FindElement(By.XPath("//div/form/div[4]/div[2]/div/div/div/div/input"));
            addNewTag.Click();
            addNewTag.SendKeys("Test Engineer");
            addNewTag.SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            IWebElement serTypeRadiobtn = driver.FindElement(By.XPath("//div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            addNewTag.Click();

            takeScreenShot(driver);

            Thread.Sleep(2000);
            IWebElement locationTypeRadiobtn = driver.FindElement(By.XPath("//div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            locationTypeRadiobtn.Click();

            Thread.Sleep(2000);
            IWebElement avaStartDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            avaStartDate.SendKeys("04/17/2023");
            avaStartDate.Click();

            Thread.Sleep(2000);
            IWebElement avaEndDate = driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            avaEndDate.SendKeys("05/18/2023");
            avaEndDate.Click();

            Thread.Sleep(2000);
            IWebElement skillTradeRadioBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillTradeRadioBtn.Click();

            Thread.Sleep(2000);
            IWebElement skillExchangeTxt = driver.FindElement(By.XPath("//div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            skillExchangeTxt.Click();
            skillExchangeTxt.SendKeys("Test Engineer & Desgning");
            skillExchangeTxt.SendKeys(Keys.Enter);


            /* var allowsDetection = driver as IAllowsFileDetection;
             if (allowsDetection != null)
             {
                 allowsDetection.FileDetector = new LocalFileDetector();
             }*/

           /* IWebElement workSample = driver.FindElement(By.XPath("//*[@id='selectFile']"));
            workSample.SendKeys("C:\\Renu\\Indusconnect\\Issue.docx");*/

            Thread.Sleep(2000);
            IWebElement activeRadiobtn = driver.FindElement(By.XPath("//div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            activeRadiobtn.Click();

            takeScreenShot(driver);

            Thread.Sleep(2000);
            IWebElement saveBtn = driver.FindElement(By.XPath("//div[2]/div/form/div[11]/div/input[1]"));
            saveBtn.Click();

            Thread.Sleep(2000);
            takeScreenShot(driver);
            Thread.Sleep(1000);


        }
        public string getCategory(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement Category = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
                      return Category.Text;

        }
        public void editShareSkill(IWebDriver driver)
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

        public string getTitle(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement title = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            return title.Text;

        }
        public string getDescrition(IWebDriver driver)
        {
            IWebElement description = driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
            return description.Text;

        }

        public void deleteshareskill(IWebDriver driver)
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

        public void takeScreenShot(IWebDriver driver)
        {
           string screenshotFileName = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Screenshot"
                + Path.DirectorySeparatorChar + "Screentshot_" + DateTime.Now.ToString("ddMMyyyy HHmmss") + ".png";

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(screenshotFileName, ScreenshotImageFormat.Png);
        }

    }
}
