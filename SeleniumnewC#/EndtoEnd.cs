using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectNunitTraining.SeleniumnewC_
{
    [Allure.NUnit.AllureNUnit]
    internal class EndtoEnd
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); /*EdgeConfig*/ //FirefoxConfig
            //initialize the web driver
            driver = new FirefoxDriver(); /*EdgeDriver()*/  //FirefoxDriver
        }
        [Test, Category("Sanity")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            Thread.Sleep(1000);
            //xpath
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='user-name']"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(1000);
            //password
            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(1000);
            //Link text
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(1000);

            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product_label']"));
            Products.Click();
            Thread.Sleep(1000);

            IWebElement addtocart = driver.FindElement(By.XPath("//button[@class='btn_primary btn_inventory']"));
            addtocart.Click();
            Thread.Sleep(5000);

            IWebElement gotocart = driver.FindElement(By.XPath("//*[name()='path']"));
            gotocart.Click();
            Thread.Sleep(5000);

            IWebElement checkout = driver.FindElement(By.XPath("//a[@class='btn_action checkout_button']"));
            checkout.Click();
            Thread.Sleep(5000);

            IWebElement fname = driver.FindElement(By.XPath("//input[@id='first-name']"));
            fname.SendKeys("Umashankari");
            Thread.Sleep(5000);

            IWebElement lname = driver.FindElement(By.XPath("//input[@id='last-name']"));
            lname.SendKeys("Bhat");
            Thread.Sleep(5000);

            IWebElement pcode = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            pcode.SendKeys("1234");
            Thread.Sleep(5000);

            IWebElement continued = driver.FindElement(By.XPath("//input[@type='submit']"));
            continued.Click();
            Thread.Sleep(5000);

            IWebElement finish = driver.FindElement(By.XPath("//a[@class='btn_action cart_button']"));
            finish.Click();
            Thread.Sleep(5000);
        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();//it will close the opened browser section
           
        }
    }
}
