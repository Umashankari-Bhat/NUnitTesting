﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium;
//using WebDriverManager.DriverConfigs.Impl;
//using OpenQA.Selenium.Edge;

//namespace TestProjectNunitTraining.SeleniumnewC_
//{
//    internal class Locators
//    {
//        IWebDriver driver;
//        [SetUp]
//        public void startbrowser() 
//        {
//            //launch chrome browser
//            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); /*EdgeConfig*/ //FirefoxConfig
//            //initialize the web driver
//            driver = new FirefoxDriver(); /*EdgeDriver()*/  //FirefoxDriver
//        }
//        [Test]
//        public void testcase1()
//        {
//            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
//            //locaters
//            //Id
//            Thread.Sleep(2000);
//            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
//            FirstName.SendKeys("Umashankari");
//            //name attribute
//            IWebElement LastName = driver.FindElement(By.Id("lastname"));
//            LastName.SendKeys("Bhat");
//            //xpath
//            Thread.Sleep(2000);
//            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='username']"));
//            UserName.SendKeys("Ubhat");
//            //password
//            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
//            Password.SendKeys("ubhat@123");
//            //Link text
//            Thread.Sleep(2000);
//            IWebElement BacktoLogin = driver.FindElement(By.LinkText("Back to Login"));
//            BacktoLogin.Click();
//            //partial link text
//            Thread.Sleep(10000);
//            //IWebElement Register = driver.FindElement(By.XPath("//input[value='Register']"));
//            //Register.Click();
//            //css selector
//            //Thread.Sleep(10000);
//            //IWebElement Elements= driver.FindElement(By.CssSelector("button[data-bs-target='#collapseOne']"));
//            //Elements.Click();
//            ////tag name
//            //Thread.Sleep(10000);
//            //IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
//            //input.SendKeys("Megha1");
//            ////class name
//            //Thread.Sleep(10000);
//            //IWebElement classname = driver.FindElement(By.ClassName("(//input[@class='form-control'])[1]"));
//            //classname.SendKeys("1Megha1");


//        }
//        [TearDown]
//        public void closebrowser()
//        {
//            driver.Close();//it will close the opened browser section
//            //driver.Quite()//will close all the browser section
//        }
//    }
//}
////        IWebDriver driver;
////        [SetUp]
////        public void startbrowser()
////        {
////            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
////            driver = new FirefoxDriver();
////        }
////        [Test]
////        public void testcase1()
////        {
////            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
////            Thread.Sleep(5000);
////            //locators
////            //Id
////            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
////            FirstName.SendKeys("Umashankari");
////            Thread.Sleep(5000);

////            //name
////            IWebElement LastName = driver.FindElement(By.Id("lastname"));
////            LastName.SendKeys("Bhat");
////            Thread.Sleep(5000);

////            IWebElement Username = driver.FindElement(By.XPath("//input[@id='username']"));
////            Username.SendKeys("UBhat");
////            Thread.Sleep(5000);

////            IWebElement Password = driver.FindElement(By.XPath("//input[@id='password']"));
////            Password.SendKeys("UBhat@123");
////            Thread.Sleep(5000);

////            //IWebElement BacktoLogin = driver.FindElement(By.LinkText("Back to login"));
////            //BacktoLogin.Click();
////            //Thread.Sleep(5000);

////            IWebElement BacktoLogin = driver.FindElement(By.LinkText("Back to Login"));
////            BacktoLogin.Click();
////            Thread.Sleep(5000);

////            //IWebElement Register = driver.FindElement(By.PartialLinkText("Back to login"));
////            //Register.Click();
////            //Thread.Sleep(5000);

////            IWebElement elements = driver.FindElement(By.CssSelector("button[data-bs-target='#collapseOne']"));
////            elements.Click();
////            Thread.Sleep(5000);

////            IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
////            input.SendKeys("UBhat@11");
////            Thread.Sleep(5000);

////            IWebElement classname = driver.FindElement(By.ClassName("(//input[@class= 'form-control'])[1]"));
////            classname.SendKeys("UBhat@12345");
////            Thread.Sleep(5000);
////        }

////        [TearDown]
////        public void closebrowser()
////        {
////            driver.Close();
////        }


////    }
////}
