using NUnit.Framework;
using OpenQA.Selenium;

namespace Selenium_WD
{
    public class Tests
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
            var actualLogin = driver.FindElement(_acceptLogin).Text;
            RandomUser randomUser = new RandomUser();
            Assert.AreEqual(randomUser.CreateRandomLogin(), actualLogin, "Login is wrong");

            Assert.Pass();
        }

        [TearDown]
        public void Test2()
        {
            // driver.Quit();
            // driver.Dispose();
        }
    }
}