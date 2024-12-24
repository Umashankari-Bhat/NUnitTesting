using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    
    internal class Lab4
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(1000);
            IWebElement dropdown = driver.FindElement(By.Id("dropdown"));
            Assert.IsNotNull(dropdown);
            var select = new SelectElement(dropdown);
            //select by  visible text
            Thread.Sleep(1000);
            select.SelectByText("Option 1");
            Thread.Sleep(1000);
            //select by index
            select.SelectByIndex(2);
            //select by value
            Thread.Sleep(2000);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
//        IWebDriver driver;

//        [SetUp]

//        public void startBrowser()

//        {

//            //launch chrome browser

//            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

//            //initialize the web driver

//            driver = new EdgeDriver();

//        }

//        [Test]

//        public void testcase1()

//        {

//            //launch application URL

//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");

//            //locators

//            //ID
//            driver.Manage().Window.Maximize();


//            Thread.Sleep(5000);
//            IWebElement dropdown = driver.FindElement(By.Id("dropdown"));
//            Assert.IsNotNull(dropdown);
//            var select = new SelectElement(dropdown);

//            //select by visible text
//            //Thread.Sleep(1000);
//            //select.SelectByText("Option1");
//            //select by index
//            Thread.Sleep(1000);
//            select.SelectByIndex(2);
//            //select by value option3
//            Thread.Sleep(1000);

//        }
//        [TearDown]
//        public void closeBrowser()
//        {
//            driver.Close();
//        }
//    }
//}
