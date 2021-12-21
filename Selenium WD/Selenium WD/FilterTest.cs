using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class FilterTest
    {
        private IWebDriver driver;
        private UserService service;
        private ICollection? allAcer;
        private Actions action;

        [SetUp]

        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://ek.ua/");
            driver.Manage().Window.Maximize();
            service = new UserService(driver);
            action = new Actions(driver);
        }

        [Test]
        public void Test1()
        {
            service.EnterComputer();
            //var allacer = driver.FindElements(By.XPath("//a/span[text()[contains(.,'Acer')]]"));
            var nextPageButton = driver.FindElement(By.XPath("//a[@id='pager_next']"));
            do
            {
                var allacer = driver.FindElements(By.XPath("//a/span[text()[contains(.,'Acer')]]"));
                foreach (var oneItemAcer in allacer)
                {
                    /*try
                    {
                        allacer = driver.FindElements(By.XPath("//a/span[text()[contains(.,'Acer')]]"));
                    }
                    catch (Exception ex)
                    {
                        Assert.Fail(ex.Message);
                    }*/
                    var oneItem = oneItemAcer.Text;
                    Assert.IsTrue(oneItem.Contains("Acer"), "Not found");
                    if (nextPageButton.Displayed)
                    {
                        nextPageButton.Click();
                        Thread.Sleep(2000);
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }
            while (nextPageButton.Displayed);
        }

        [TearDown]
        public void Test2()
        {
            //driver.Quit();
            //driver.Dispose();
        }
    }
}
