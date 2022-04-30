using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AventStack.ExtentReports;
using System.IO;
using AventStack.ExtentReports.Reporter;
using SeleniumExtras.WaitHelpers;

using System.Drawing.Imaging;
using OpenQA.Selenium.Support.UI;

namespace TalentShareSkillProject.Utilities
{
    public class CommonServices 
    {
        ExtentReports extent;
        ExtentTest test;
        ExtentHtmlReporter htmlReporter;

        public static IWebDriver driver;

        public static string screenshotDirectory;

        public void LoginPage()
        {
            //  driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            IWebElement signin = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signin.Click();

            IWebElement emailid = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailid.Click();
            emailid.SendKeys("renukaul955@gmail.com");



            IWebElement pwd = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            pwd.Click();
            pwd.SendKeys("target@123");


            IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            login.Click();


        }

       
        public ExtentReports getInstance()
        {
            string filePath = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "Result"
                + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyyy HHmmss");
           
            htmlReporter = new ExtentHtmlReporter(filePath);
           
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            return extent;
           
        }

            
    }
}
