using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class Alerts
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
        [Test, Category("Sanity")]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement infoalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            infoalert.Click();
            // Handling informtation alerts 
            IAlert alt = driver.SwitchTo().Alert();
            // clicking on OK button
            alt.Accept();
            Thread.Sleep(2000);
            // Handling confirmationl alerts
            IWebElement confalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            confalert.Click();
            // clicking on cancel button
            alt.Dismiss();
            Thread.Sleep(2000);
            // Handling prompt alerts
            IWebElement propalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            propalert.Click();
            // clicking on cancel button
            string alerttext = alt.Text;
            Console.WriteLine(alerttext);
            Thread.Sleep(2000);
            alt.SendKeys("Hello");
            alt.Accept();

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

