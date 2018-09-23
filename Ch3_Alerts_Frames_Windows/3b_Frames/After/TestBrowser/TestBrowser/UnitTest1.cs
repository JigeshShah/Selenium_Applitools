using System;
using System.Threading;
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
            driver.FindElement(By.LinkText("Frames")).Click();
            driver.FindElement(By.LinkText("iFrame")).Click();
            Thread.Sleep(5000);
            //Switch To IFrame
            driver.SwitchTo().Frame(0);
           Thread.Sleep(2000);




        }
    }
}
