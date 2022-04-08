using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TalentProfileProject.Profile
{
    public class ManageCertificate
    {

        public void addCertificates(IWebDriver driver)
        {
            
            Thread.Sleep(2000);
            IWebElement addCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addCertificate.Click();

            Thread.Sleep(2000);
            IWebElement txtBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            txtBox.Click();
            txtBox.SendKeys("TESTANALYST");

            Thread.Sleep(2000);
            IWebElement certFrom = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certFrom.Click();
            certFrom.SendKeys("INDUSTRYCONNECT");


            Thread.Sleep(2000);
            IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            dropDown.Click();

            Thread.Sleep(2000);
            IWebElement certYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
            certYear.Click();

            Thread.Sleep(2000);
            IWebElement addCertBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertBtn.Click();

        }


        public string getLastCertificate(IWebDriver driver)
        {

            Thread.Sleep(2000);
            IWebElement lastCertificate = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return lastCertificate.Text;

        }


        public void editCertificate(IWebDriver driver)
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            IWebElement editSkillbtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            editSkillbtn.Click();

            Thread.Sleep(2000);
            IWebElement txtBox = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
           txtBox.Clear();
            txtBox.Click();
            txtBox.SendKeys("ISTQB");

            IWebElement updatebtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatebtn.Click();

        }

       public void deleteCertificate(IWebDriver driver)
        {

            /*Thread.Sleep(2000);

            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            Thread.Sleep(2000);

            IWebElement delBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
            delBtn.Click(); 


        }


    }
}
