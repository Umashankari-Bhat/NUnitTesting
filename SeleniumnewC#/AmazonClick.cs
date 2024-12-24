using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class AmazonClick
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

        [Test, Category("Regression")]

        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            IWebElement todaysDeals = driver.FindElement(By.XPath("//a[text()=\"Today's Deals\"]"));
            Thread.Sleep(1000);
            IWebElement bestsellers = driver.FindElement(By.XPath("//a[normalize-space()='Best Sellers']"));
            Thread.Sleep(1000);
            Actions actions = new Actions(driver);

            new Actions(driver)
                .ContextClick(todaysDeals)
                .Pause(TimeSpan.FromSeconds(5))
                .DoubleClick(bestsellers)
                //.ClickAndHold()
                .Pause(TimeSpan.FromSeconds(5))
               

                .Perform();

            Thread.Sleep(1000);
        }
        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
