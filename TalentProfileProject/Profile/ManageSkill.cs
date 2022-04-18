using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TalentProfileProject.Profile
{
    public class ManageSkill
    {

        

        public void addSkills(IWebDriver driver)
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            Thread.Sleep(2000);
            IWebElement addSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addSkill.Click();

            Thread.Sleep(2000);
            IWebElement txtBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            txtBox.Click();
            txtBox.SendKeys("Skill1");


            Thread.Sleep(2000);
            IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            dropDown.Click();

            Thread.Sleep(2000);
            IWebElement skillLevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevel.SendKeys("Beginner");
            skillLevel.Click();

            Thread.Sleep(2000);
            IWebElement addSkillBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillBtn.Click();

        }


        public string getLastSkill(IWebDriver driver)
        {

            Thread.Sleep(2000);
            IWebElement lastSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return lastSkill.Text;

        }


        public void editSkill(IWebDriver driver)
        {
            /*Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            IWebElement editSkillbtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editSkillbtn.Click();

            Thread.Sleep(2000);
            IWebElement txtBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
           txtBox.Clear();
            txtBox.Click();

            Thread.Sleep(2000);
            txtBox.SendKeys("Skill2");

            IWebElement updatebtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updatebtn.Click();

        }

       public void deleteSkill(IWebDriver driver)
        {

            /*Thread.Sleep(2000);

            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();*/

            Thread.Sleep(2000);

            IWebElement delBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            delBtn.Click();

            IAlert al = driver.SwitchTo().Alert();
            al.Accept();

            /*IWebElement confirmDel = driver.FindElement(By.XPath("//div[2]/div/div[3]/button[2]"));
            confirmDel.Click();*/
        }


    }
}
