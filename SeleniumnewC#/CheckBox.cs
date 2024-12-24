//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace TestProjectNunitTraining.SeleniumnewC_
//{
//    internal class CheckBox
//    {
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
//            driver.Manage().Window.Maximize();

//            Thread.Sleep(5000);
//            IReadOnlyList<IWebElement> checkboxlist = driver.FindElements(By.XPath("//form[@id='checkboxes']//input[@type='checkbox']"));

//            // Step 1: Deselect all selected checkboxes
//            foreach (IWebElement checkbox in checkboxlist)
//            {
//                if (checkbox.Selected)
//                {
//                    checkbox.Click(); // Deselect it
//                }
//            }

//            // Step 2: Select all checkboxes
//            foreach (IWebElement checkbox in checkboxlist)
//            {
//                if (!checkbox.Selected) // Check if not already selected
//                {
//                    checkbox.Click(); // Select it
//                }
//            }
//            [TearDown]

//            public void closeBrowser()

//            {

//                driver.Close();

//            }
//        }
//    }
