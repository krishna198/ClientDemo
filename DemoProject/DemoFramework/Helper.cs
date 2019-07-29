using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OpenQA.Selenium.Interactions.Internal;
//using OpenQA.Selenium.Internal;


namespace DemoFramework
{
    public class Helper : BaseClass
    {
        public void BrowseApplicationUrl(string urlToBrowse)
        {
            driver.Navigate().GoToUrl(urlToBrowse);
        }

        public void SetTextToField(By element, string text)
        {
            driver.FindElement(element).SendKeys(text);
        }

        public void ClearAndSetTextToField(By element, string text)
        {
            driver.FindElement(element).Clear();
            driver.FindElement(element).SendKeys(text);
        }

        public void ClickElement(By element)
        {
            driver.FindElement(element).Click();
        }

        public bool isElementDisplayed(By element, int timeOut)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOut));
                return wait.Until(abc => abc.FindElement(element).Displayed);
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

    }
}
