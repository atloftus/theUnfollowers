using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace theUnfollowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ChromeDriverRelativePath = (Directory.GetCurrentDirectory().Split(new string[] { "repos" }, StringSplitOptions.None))[0] + @"repos\Hunters\chromedriver_win32";
            //ChromeDriver Driver = new ChromeDriver(ChromeDriverRelativePath);
            //string url = "https://www.google.com/";
            //Driver.Navigate().GoToUrl(url);
            //Thread.Sleep(2000);

            createLIQueriesTwo();

            Console.WriteLine("Hello World! Lets see if this works...");
        }



        public static List<string> createLIQueriesTwo()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\AlexanderLoftus\Desktop\following.txt");
            List<string> userURLS = new List<string>();
            bool write = false;

            foreach (string line in lines)
            {
                if (write)
                {
                    userURLS.Add(@"https://www.instagram.com/" + line.Trim());
                    string testing = @"https://www.instagram.com/" + line.Trim() + @"/following/?hl=en";
                    write = false;
                }

                if (line.Contains("profile picture"))
                {
                    write = true;
                }
            }

            File.WriteAllLines(@"C:\Users\AlexanderLoftus\Desktop\following_OUTPUT2.txt", userURLS);
            return userURLS;
        }
    }
}
