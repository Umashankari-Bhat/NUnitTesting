using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    internal class TakeScreenShot
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            Screenshot ss = driver.TakeScreenshot();

            string folderPath = @"C:\\Users\\ubhat\\Documents\\New";
            string fileName = "Screenshot_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
            string fullPath = Path.Combine(folderPath, fileName);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            ss.SaveAsFile(fullPath);

            //Screenshot ss = driver.TakeScreenshot();
            //ss.SaveAsFile("C:\\Users\\ubhat\\Downloads\\Ss\\Screenshot 2024-12-18 135434.png");
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
