using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TalentProfileProject.Profile
{
   public class ManageEducation
    {
        public void addEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement addbtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addbtn.Click();

            Thread.Sleep(2000);
            IWebElement txtbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            txtbox.Click();
            txtbox.SendKeys("Victoria Uni");


            Thread.Sleep(2000);
            IWebElement dropdownplace = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            dropdownplace.Click();
            dropdownplace.SendKeys("Austria");

            Thread.Sleep(2000);
            IWebElement dropDownTitle = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            dropDownTitle.Click();
            dropDownTitle.SendKeys("PHD");

            Thread.Sleep(2000);
            IWebElement txtboxdegree = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            txtboxdegree.Click();
            txtboxdegree.SendKeys("degree");


            Thread.Sleep(2000);
            IWebElement dropDownYear = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            dropDownYear.Click();
            dropDownYear.SendKeys("2013");


            Thread.Sleep(2000);
            IWebElement addBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addBtn.Click();

       }


        public string getlastCountry(IWebDriver driver)
        {
            Thread.Sleep(2000);
           return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;

        }


        public string getlastUniv(IWebDriver driver)
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;

        }


        public void editEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editbtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
            editbtn.Click();


            Thread.Sleep(2000);
            IWebElement txtbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
            txtbox.Click();
            txtbox.Clear();
            txtbox.SendKeys("Auck Univ");

            Thread.Sleep(2000);
            IWebElement updBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updBtn.Click();


        }
        public void deleteEducation(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement delEducation = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            delEducation.Click();

        }


    }
}
