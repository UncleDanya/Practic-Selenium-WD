using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_WD
{
    internal class RandomUser
    {
        public void CreateRandomLogin()
        {
            Random user = new Random();
            String b = "qwertyuiopasdfghjklzxcvbnm";
            int lenght = 6;
            String random = "";

            for (int i = 0; i < lenght; i++)
            {
                int a = user.Next(26);
                random = random + b.ElementAt(a);
            }
            Console.WriteLine(random);
        }

        public void CreateRandomPassword()
        {
            Random res = new Random();

            String str = "abcdefghijklmnopqrstuvwxyz0123456789";
            int size = 8;

            String randomstring = "";

            for (int i = 0; i < size; i++)
            {

                int x = res.Next(str.Length);

                randomstring = randomstring + str[x];
            }

            Console.WriteLine(randomstring);
        }

        public void CreateRandomEmail()
        {
            Random user = new Random();
            String b = "qwertyuiopasdfghjklzxcvbnm";
            int lenght = 6;
            String random = "" + "@gmail.com";

            for (int i = 0; i < lenght; i++)
            {
                int a = user.Next(26);
                random = random + b.ElementAt(a);
            }
            Console.WriteLine(random);
        }
    }
}
