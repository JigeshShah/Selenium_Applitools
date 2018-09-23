using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestBrowser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new FirefoxDriver("C:\\SeleniumDrivers");

            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.FindElement(By.Name("q")).Clear();
            driver.FindElement(By.Name("q")).SendKeys("test");
            driver.FindElement(By.CssSelector("div.FPdoLc.VlcLAe > center > input[name=\"btnK\"]")).Click();

        }
    }
}
