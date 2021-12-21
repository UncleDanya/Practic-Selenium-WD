﻿using NUnit.Framework;
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
    internal class CompareTwoItemTest
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
            service.AddTablet();
            //service.AddCompareFirstTablet();
            Thread.Sleep(1000);
            //service.AddCompareSecondTablet();
            service.CompareTest();
        }

        [TearDown]
        public void Test2()
        {
            //driver.Quit();
            //driver.Dispose();
        }

    }
}
