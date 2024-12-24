using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    internal class LabAlert
    {
        IWebDriver driver;

        [SetUp]

        public void startBrowser()

        {

            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        [Test]

        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            //locators

            //ID
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            IWebElement infoalert = driver.FindElement(By.XPath("(//input[@id='alertbtn'])[1]"));
            infoalert.Click();
            IAlert alt = driver.SwitchTo().Alert();
            // clicking on OK button
            alt.Accept();
            Thread.Sleep(2000);
            // Handling confirmationl alerts
            IWebElement confalert = driver.FindElement(By.XPath("(//input[@id='confirmbtn'])[1]"));
            confalert.Click();
            alt.Dismiss();
            Thread.Sleep(2000);

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
