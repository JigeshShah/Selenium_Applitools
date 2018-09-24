using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Drawing;
using Applitools.Selenium;

namespace TestBrowser
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver("C:\\SeleniumDrivers");
            var eyes = new Eyes();
            try
            {
               

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");


            eyes.ApiKey = "";

            eyes.Open(driver, "Demo_Test", "Demo_Test", new Size(800, 600));


            //Link Text
            driver.FindElement(By.LinkText("Form Authentication")).Click();

            // Visual checkpoint #1.
//            eyes.CheckWindow("Login_Test");

            // Visual checkpoint #1.
//            eyes.CheckWindow("Login");

            // EnterText and Click
            String name = "tomsmith";
            String password = "SuperSecretPassword!";

            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(name);

            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(password);
           eyes.CheckWindow("Login");
            driver.FindElement(By.CssSelector("button.radius")).Click();

            eyes.Close();
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // Close the browser.
                driver.Quit();

                // If the test was aborted before eyes.Close was called, ends the test as aborted.
                eyes.AbortIfNotClosed();
            }
        }
    }
}
