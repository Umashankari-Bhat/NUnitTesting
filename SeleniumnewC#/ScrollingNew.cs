using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    internal class ScrollingNew
    {
        IWebDriver driver;

        [SetUp]

        public void startBrowser()

        {

            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //initialize the web driver

            driver = new FirefoxDriver();

        }

        [Test]

        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500);");
            Thread.Sleep(2000);// Scroll down 500px

            IJavaScriptExecutor jsnew = (IJavaScriptExecutor)driver;
            jsnew.ExecuteScript("window.scrollBy(0, -500);"); // Scroll up 500px
            Thread.Sleep(2000);

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
