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
            driver.FindElement(By.LinkText("Multiple Windows")).Click();

            driver.FindElement(By.LinkText("Click Here")).Click();

            Thread.Sleep(2000);
            String handle = driver.CurrentWindowHandle;

            foreach (String handle1 in driver.WindowHandles)
            {

                if (handle.Equals(handle1) == false)
                {
                    driver.SwitchTo().Window(handle1);
                }
            }


            driver.Close();
            Thread.Sleep(2000);

            driver.SwitchTo().Window(handle);
        }
    }
}
