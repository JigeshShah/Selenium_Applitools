﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;
using OpenQA.Selenium.Remote;

namespace TestBrowser
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestMethod1()
        {



            IWebDriver driver;

            ChromeOptions options = new ChromeOptions();

            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options.ToCapabilities());


            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");


            //Link Text
            driver.FindElement(By.LinkText("Form Authentication")).Click();

            // EnterText and Click
            String name = "tdeusd";
            String password = "sajksa";
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(name);

            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.CssSelector("button.radius")).Click();

            driver.Quit();
        }
    }
}
