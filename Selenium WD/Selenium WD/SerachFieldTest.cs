using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class SerachFieldTest
    {
        private IWebDriver driver;
        private UserService service;
        private readonly By _searchItem = By.XPath("//h3[text()=' Смартфон APPLE iPhone 13 Pro 256GB Graphite (MLVE3)']");


        [SetUp]

        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://ek.ua/");
            driver.Manage().Window.Maximize();
            service = new UserService(driver);
        }

        [Test]
        public void Test1()
        {
            service.Search();
            var searchItem = driver.FindElement(_searchItem).Text;
            Assert.AreEqual("Смартфон APPLE iPhone 13 Pro 256GB Graphite (MLVE3)", searchItem, "Search Item not found on page");
            Assert.Pass();
        }

        [TearDown]
        public void Test2()
        {
            //driver.Quit();
            //driver.Dispose();
        }

    }
}
