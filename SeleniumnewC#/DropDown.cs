//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;
//using OpenQA.Selenium.Support.UI;

//namespace TestProjectNunitTraining.SeleniumnewC_
//{
//    [Allure.NUnit.AllureNUnit]
//    internal class DropDown:Utilities.Base
//    {
//        public DropDown(IWebDriver driver) : base(driver)
//        {
//        }

       
//        //IWebDriver driver;

//        //[SetUp]

//        //public void startBrowser()

//        //{

//        //    //launch chrome browser

//        //    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

//        //    //initialize the web driver

//        //    driver = new EdgeDriver();

//        //}

//        [Test]

//        public void testcase1()

//        {

//            //launch application URL

//            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

//            //locators

//            //ID
//            driver.Manage().Window.Maximize();
//            IWebElement dropdown = driver.FindElement(By.Id("dropdown-class-example"));
//            Assert.IsNotNull(dropdown);
//            var select = new SelectElement(dropdown);
//            //select by visible text
//            Thread.Sleep(1000);
//            select.SelectByText("Option1");
//            //select by index
//            Thread.Sleep(1000);
//            select.SelectByIndex(2);
//            //select by value option3
//            Thread.Sleep(1000);
//            select.SelectByValue("option3");
//            Thread.Sleep(1000);
//        }
//        //[TearDown]

//        //public void closeBrowser()

//        //{

//        //    driver.Close();

//        //}
//    }
//}


