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
    internal class ActionsEg
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
            IWebElement primes = driver.FindElement(By.XPath("//a[@id='nav-link-amazonprime']")); //span[normalize-space()='Prime'])[1]
            Thread.Sleep(5000);

            //IWebElement latestmovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));//img[@id='multiasins-img-link']

            new OpenQA.Selenium.Interactions.Actions(driver)
                .MoveToElement(primes)
                .ClickAndHold()
                .Pause(TimeSpan.FromSeconds(1))
                //.MoveToElement(latestmovies)
                //.DragAndDrop(source,Dest)
                //.Click()
                .Perform();
            Thread.Sleep(5000);


        }
        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}

