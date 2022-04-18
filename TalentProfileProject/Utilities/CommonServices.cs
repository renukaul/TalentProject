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

using System.Drawing.Imaging;

namespace TalentProfileProject.Utilities
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

        public void goToTab(IWebDriver driver,string tabName)
        {
            Thread.Sleep(2000);
            switch (tabName)
            {
                case "Languages":
                    driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
                    break;
                case "Skills":
                    driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();   
                    break;
                case "Education":
                    driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")).Click();
                    break;
                case "Certifications":
                    driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
                    break;


            }
          


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
