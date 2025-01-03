﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Xml.Linq;
using OpenQA.Selenium.Firefox;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class FramesEg
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
        [Test, Category("Sanity")]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));
            Assert.IsNotNull(frame1);
            driver.SwitchTo().Frame(frame1);
            //driver.SwitchTo().Frame(0);    //index
            // driver.SwitchTo().Frame(name);  
            IWebElement newyork = driver.FindElement(By.XPath("//label[normalize-space()='New York']"));
            Thread.Sleep(3000);
            newyork.Click();



        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
