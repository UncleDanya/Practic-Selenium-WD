using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        private readonly By _signInButton = By.XPath("//*[@id='mui_user_login_row']");
        private readonly By _registrationButton = By.XPath("//span[@class='j-wrap orange']");
        private readonly By _nameInputButton = By.XPath("//input[@name='p_[NikName]']");
        private readonly By _emailInputButton = By.XPath("//input[@name='p_[EMail]']");
        private readonly By _passwordInputButton = By.XPath("//input[@name='p_[PW0]']");
        private readonly By _acceptRegistrationButton = By.XPath("//button[@id='gxg47snjfol']");
        WebElement iframe = driver.FindElements(By.XPath(""))

        private const string _registrationName = "User1";
        private const string _registrationEmail = "danya.sydortsov@tech-stack.io";
        private const string _registrationPassword = "Password123";

        public By computer { get return { By.XPath("//a[@class='cancel-click mainmenu-link']")} }

        public void Create()
        {
            var signIn = driver.FindElement(_signInButton);
            signIn.Click();

            var registrationButton = driver.FindElement(_registrationButton);
            registrationButton.Click();

            var inputName = driver.FindElement(_nameInputButton);
            inputName.SendKeys(_registrationName);

            var emailInput = driver.FindElement(_emailInputButton);
            emailInput.SendKeys(_registrationEmail);

            var passwordInput = driver.FindElement(_passwordInputButton);
            passwordInput.SendKeys(_registrationPassword);

            var acceptRegistration = driver.FindElement(_acceptRegistrationButton);
            acceptRegistration.Click();
        }
    }
}
