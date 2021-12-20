using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium_WD
{
    public class Tests
    {
        private IWebDriver driver;
        private UserService service;

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
            Assert.Pass();
        }

        [TearDown]
        public void Test2()
        {

        }
    }
}