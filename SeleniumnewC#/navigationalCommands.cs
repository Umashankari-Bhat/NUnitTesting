using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    internal class navigationalCommands
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();

        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            driver.Navigate().Forward();
            Thread.Sleep(3000);
            driver.Navigate().Refresh();
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }


    }
}
