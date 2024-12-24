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
    internal class KeyBoard
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

            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            //IWebElement email = driver.FindElement(By.Id("email"));
            //Thread.Sleep(5000);

            IWebElement password = driver.FindElement(By.Id("pass"));
            Thread.Sleep(5000);

            new OpenQA.Selenium.Interactions.Actions(driver)
                //.MoveToElement(email)
                .MoveToElement(password)
                .Click()
                .KeyDown(Keys.Shift)
                .SendKeys("ubhat")
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
