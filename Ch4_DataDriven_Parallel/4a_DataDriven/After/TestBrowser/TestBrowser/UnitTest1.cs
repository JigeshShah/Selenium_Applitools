using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Data;
namespace TestBrowser
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq=C:\\SeleniumDrivers\\data.xlsx;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "data$", DataAccessMethod.Sequential), TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver("C:\\SeleniumDrivers");

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/");


            //Link Text
            driver.FindElement(By.LinkText("Form Authentication")).Click();

            // EnterText and Click
            String name = TestContext.DataRow["Name"].ToString();
            String password = TestContext.DataRow["password"].ToString();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(name);

            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(password);
            driver.FindElement(By.CssSelector("button.radius")).Click();

            driver.Quit();
        }
    }
}
