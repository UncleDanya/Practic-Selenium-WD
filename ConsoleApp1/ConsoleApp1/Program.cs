namespace Test
{
    public class Program
    {
        static void Main(string[] args)
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
    }
}