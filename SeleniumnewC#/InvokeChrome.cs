using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class InvokeChrome
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();

        }
        [Test, Category("Regression")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();
        }


    }
}
