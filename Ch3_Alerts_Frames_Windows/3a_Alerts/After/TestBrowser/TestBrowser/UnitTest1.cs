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
            driver.FindElement(By.LinkText("JavaScript Alerts")).Click();


            //Alert
            driver.FindElement(By.XPath("//button[@onclick='jsAlert()']")).Click();
            Thread.Sleep(3000);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            //Confirm
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@onclick='jsConfirm()']")).Click();
            Thread.Sleep(3000);
            IAlert confirmationAlert = driver.SwitchTo().Alert();
            confirmationAlert.Dismiss();


            //Prompt
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@onclick='jsPrompt()']")).Click();
            Thread.Sleep(3000);
            IAlert promptAlert = driver.SwitchTo().Alert();
            Thread.Sleep(4000);
            promptAlert.Dismiss();


        }
    }
}
