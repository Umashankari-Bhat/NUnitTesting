//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;

//namespace TestProjectNunitTraining.SeleniumnewC_
//{
//    [Allure.NUnit.AllureNUnit]
//    internal class FileDownload
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void startBrowser()
//        {
//            //launch chrome browser
//            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
//            //initialize the web driver
//            driver = new FirefoxDriver();
//        }
//        [Test, Category("Regression")]
//        public void testcase1()
//        {
//            //launch application URL
//            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
//            driver.Manage().Window.Maximize();
//            Thread.Sleep(2000);
//            IWebElement browse = driver.FindElement(By.XPath("//a[normalize-space()='1734472065.txt']"));
//            browse.Click();
//            Thread.Sleep(2000);
//            string download = @"C:\Users\ubhat\Downloads\1734472065(2).txt";
//            if (File.Exists(download))
//            {
//                Console.WriteLine("File is downloaded successfully.");
//            }
//            else
//            {
//                Console.WriteLine("File download failed.");
//            }
//        }
//        [TearDown]
//        public void closeBrowser()
//        {
//            driver.Close();
//        }
//    }
//}


