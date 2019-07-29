using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DemoFramework
{
    public class BaseClass
    {
        public static IWebDriver driver;

        public static void InitializeDriver(string browser)
        {
            if (browser == "Chrome")
            {
                InitializeChromeDriver("");
            }

            if (browser == "Firefox")
            {
                InitializeFirefoxDriver("");
            }
        }

        private static void InitializeChromeDriver(string path)
        {
            driver = new ChromeDriver();
        }

        private static void InitializeFirefoxDriver(string path)
        {
            driver = new FirefoxDriver();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }
    }
}
