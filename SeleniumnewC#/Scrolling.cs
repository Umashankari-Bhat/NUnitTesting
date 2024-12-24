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
    internal class Scrolling
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

            driver.Navigate().GoToUrl("https://www.amazon.in/");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            //saving inside folder.
            ScrollDown();

            // Wait before scrolling back up
            Thread.Sleep(2000);

            // Scroll Up the page
            ScrollUp();
            Thread.Sleep(2000);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
        private void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, 500);");
            Thread.Sleep(2000);// Scroll down 500px
            Console.WriteLine("Scrolled Down.");
        }

        // Method to scroll up
        private void ScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0, -500);"); // Scroll up 500px
            Console.WriteLine("Scrolled Up.");
        }

    }

}

//        IWebDriver driver;
//        [SetUp]
//        public void startBrowser()
//        {
//            //launch chrome browser
//            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
//            //initialize the web driver
//            driver = new FirefoxDriver();
//        }
//        [Test]
//        public void testcase1()
//        {
//            driver.Navigate().GoToUrl("https://transmissions.cristobalbalenciagamuseoa.com/");
//            driver.Manage().Window.Maximize();
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            Thread.Sleep(2000);

//            js.ExecuteScript("window.scrollBy(6000,0)", "");
//            Thread.Sleep(10000);
//            //launch application URL
//            //driver.Navigate().GoToUrl("https://www.amazon.in/");
//            //driver.Manage().Window.Maximize();
//            //Thread.Sleep(2000);
//            //IWebElement amazonscience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));
//            //new OpenQA.Selenium.Interactions.Actions(driver)
//            //    .ScrollToElement(amazonscience)
//            //    .Click(amazonscience)
//            //    .Perform();

//            ////java script execitor for scrolling
//            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

//            ////vertical down scroll
//            ////0-x coordinate
//            ////400 - y coordinates


//            ////down scroll
//            //js.ExecuteScript("window.scrollBy(0, 800)");

//            ////scroll up
//            //js.ExecuteScript("window.scrollBy(0, -500)");

//            ////horizontal down scroll
//            ////600-x coordinate
//            ////0 - y coordinates

//            ////right scroll
//            //// js.ExecuteScript("window.scrollBy(0, 800)");





//        }
//        [TearDown]
//        public void closeBrowser()
//        {
//            driver.Close();
//        }
//    }
//}

