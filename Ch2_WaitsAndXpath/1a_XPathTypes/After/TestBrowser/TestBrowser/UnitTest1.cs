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

            driver.FindElement(By.XPath("//input[@name='password' and @id='password']")).Clear();
            driver.FindElement(By.XPath("//input[@name='password' and @id='password']")).SendKeys("a");

            driver.FindElement(By.XPath("//input[@type='text' or @id='password']")).Clear();
            driver.FindElement(By.XPath("//input[@type='text' or @id='password']")).SendKeys("b");

            driver.FindElement(By.XPath("//input[contains(@id,'pass')]")).Clear();
            driver.FindElement(By.XPath("//input[contains(@id,'pass')]")).SendKeys("c");

            driver.FindElement(By.XPath("//input[starts-with(@id,'user')]")).Clear();
            driver.FindElement(By.XPath("//input[starts-with(@id,'user')]")).SendKeys("d");

            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/../div//input")).Clear();
            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/../div//input")).SendKeys("e");

            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/parent::form/div/div/input")).Clear();
            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/parent::form/div/div/input")).SendKeys("f");

            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/preceding::input")).Clear();
            driver.FindElement(By.XPath("//button[starts-with(@type,'sub')]/preceding::input")).SendKeys("g");

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        }
    }
}
