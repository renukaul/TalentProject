using OpenQA.Selenium;
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;*/
using System.Threading;
//using System.Threading.Tasks;
//using TalentProfileProject.Utilities;

namespace TalentProfileProject.Profile
{
    public class ManageLanguage

    {
        public void addLanguage(IWebDriver driver)
        {
           /* Thread.Sleep(2000);
             IWebElement language = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            // IWebElement language = driver.FindElement(By.CssSelector("th[textContent='Languages']"));
            language.Click();*/


            IWebElement addNewBtn = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewBtn.Click();

            IWebElement txtBox = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            txtBox.Click();
            txtBox.SendKeys("English");

            IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            dropDown.Click();

            IWebElement dropDownSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            dropDownSelect.SendKeys("Conversational");
            dropDownSelect.Click();


            IWebElement addBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();



        }
        public void editLanguage(IWebDriver driver,string lang,string lvl)
        {

            //Click on pen element to make the row editable

            Thread.Sleep(4000);
            // IWebElement editBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]//child::i[@class='outline write icon']"));
            IWebElement editBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editBtn.Click();

            //This is textbox here
            IWebElement editedLangtxtbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editedLangtxtbox.Clear();
            editedLangtxtbox.SendKeys(lang);

            //Level Text box
            IWebElement lvlTextBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            lvlTextBox.SendKeys(lvl);
            lvlTextBox.Click();

            Thread.Sleep(4000);

            //This is update button which will actually update
            IWebElement updateBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateBtn.Click();

            
        }

        public void deleteLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleBtn.Click();
        }
       
       
        public string getLastLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement lang = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            
            return lang.Text;

        }


        public string getLastLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement lvl = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            return lvl.Text;

        }




    }
}
