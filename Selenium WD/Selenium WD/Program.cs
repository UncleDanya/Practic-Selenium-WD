using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RandomUser rndUser = new RandomUser();
            rndUser.CreateRandomLogin();
            rndUser.CreateRandomPassword();
            rndUser.CreateRandomEmail();
        }
    }
}
