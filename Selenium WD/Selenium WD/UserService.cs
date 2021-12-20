using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class UserService
    {
        private IWebDriver driver;
        public UserService(IWebDriver driver)
        {
            this.driver = driver;
        }

        IJavaScriptExecutor executor;
        public UserService (IJavaScriptExecutor executor)
        {
            this.executor = executor;
        }

        private UserService service;
        public UserService(UserService service)
        {
            this.service = service;
        }


        private readonly By _signInButton = By.XPath("//span[@jtype='click']");
        private readonly By _registrationButton = By.XPath("//span[@class='j-wrap orange']");
        private readonly By _nameInputButton = By.XPath("//input[@name='p_[NikName]']");
        private readonly By _emailInputButton = By.XPath("//input[@name='p_[EMail]']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='p_[PW0]']");
        private readonly By _acceptRegistrationButton = By.XPath("//button[text()='ЗАРЕГИСТРИРОВАТЬСЯ']");
        private readonly By _searchInputButton = By.XPath("//input[@id='ek-search']");
        private readonly By _searchItemButton = By.XPath("//button[@name='search_but_']");
        private readonly By _acceptButton = By.XPath("//button[text()='Подтвердить']");

        private const string _registrationName = "User1";
        private const string _registrationEmail = "danya.sydortsov@tech-stack.io";
        private const string _registrationPassword = "Password123";
        private const string _searchingItem = "iPhone 13 Pro 256";

        //public By Computer => By.XPath("//a[@class='cancel-click mainmenu-link']");
        RandomUser rndUs = new RandomUser();

        public void Create()
        {
            var signIn = driver.FindElement(_signInButton);
            signIn.Click();

            var registrationButton = driver.FindElement(_registrationButton);
            registrationButton.Click();

            var inputName = driver.FindElement(_nameInputButton);
            inputName.SendKeys(rndUs.CreateRandomLogin());

            var emailInput = driver.FindElement(_emailInputButton);
            emailInput.SendKeys(rndUs.CreateRandomEmail());

            var passwordInput = driver.FindElement(_passwordInputButton);
            passwordInput.SendKeys(rndUs.CreateRandomPassword());

            var acceptRegistration = driver.FindElement(_acceptRegistrationButton);
            acceptRegistration.Click();

            //WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(1000);

            var acceptButton = driver.FindElement(_acceptButton);
            acceptButton.Click();
        }

        public void Search()
        {
            var searchInput = driver.FindElement(_searchInputButton);
            searchInput.SendKeys(_searchingItem);
            var searchButton = driver.FindElement(_searchItemButton);
            searchButton.Click();
        }
    }
}
