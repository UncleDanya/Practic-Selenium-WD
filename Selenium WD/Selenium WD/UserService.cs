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
    }
}
