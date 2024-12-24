﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    internal class WebTableHandling
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            // fetch the table
            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'table1']"));
            // fecth the rows 
            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));
            int rowcount = trrow.Count();
            Console.WriteLine(rowcount);
            Thread.Sleep(3000);
            // fecth the columns 
            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td")));
            int colcount = tdcol.Count();
            Console.WriteLine(colcount);
            Thread.Sleep(3000);
            // cell data text
            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[1]/td[2]"));
            string text = celldata.Text;
            Console.WriteLine(text);
            Assert.AreEqual("John", text);
            Thread.Sleep(3000);

       }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();

        }
    }
}
