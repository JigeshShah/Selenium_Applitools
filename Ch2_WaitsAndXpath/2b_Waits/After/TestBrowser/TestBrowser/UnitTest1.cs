using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(50);


            driver.FindElement(By.LinkText("Dynamic Controls")).Click();

            driver.FindElement(By.XPath("//button[text()='Remove']")).Click();

            IWebElement element = driver.FindElement(By.XPath("//button[text()='Add']"));
            DefaultWait<IWebElement> dwait = new DefaultWait<IWebElement>(element);
            dwait.Timeout = TimeSpan.FromMinutes(2);
            dwait.PollingInterval = TimeSpan.FromMilliseconds(250);
            Func<IWebElement, bool> waiter = new Func<IWebElement, bool>((IWebElement ele) =>
            {
                if (element.Displayed)
                {
                    return true;
                }
                return false;
            });
            dwait.Until(waiter);
            element.Click();
        }
    }
}