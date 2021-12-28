﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class ViewedProductsTest
    {
        private IWebDriver driver;
        private UserService service;
        private readonly By _acceptLogin = By.XPath("//a[@class='info-nick']");

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
            service.Create();
            
            Thread.Sleep(2000);

            service.SaveInViewedProducts();
        }

        [TearDown]
        public void Test2()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
