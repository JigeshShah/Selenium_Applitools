using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestBrowser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver("C:\\SeleniumDrivers");

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");


            //Link Text
            driver.FindElement(By.LinkText("Form Authentication")).Click();

            // EnterText and Click
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys("tomsmith");

            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!");
            driver.FindElement(By.CssSelector("button.radius")).Click();

        }
    }
}
