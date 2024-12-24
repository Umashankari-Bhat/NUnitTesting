using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class InvokeFirefox
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
        }

        [Test]
        public void TestCase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            //get the title of the web page
            string title = driver.Title;
            Console.WriteLine(title);
            //get the current url
            string currenturl = driver.Url;
            Console.WriteLine(currenturl);
            //get page source or html code
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            //will close all the browser sessions
            driver.Quit();
        }
    }
}
