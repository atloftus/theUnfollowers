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
            string ChromeDriverRelativePath = (Directory.GetCurrentDirectory().Split(new string[] { "repos" }, StringSplitOptions.None))[0] + @"repos\Hunters\chromedriver_win32";
            ChromeDriver Driver = new ChromeDriver(ChromeDriverRelativePath);
            string url = "https://www.google.com/";
            Driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
            Console.WriteLine("Hello World! Lets see if this works...");
        }
    }
}
