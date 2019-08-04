using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using DemoFramework;
using PageOperations;


namespace DemoProject
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public void setup()
        {
            BaseClass.InitializeDriver("Chrome");
        }

        LoginPO objLoginPO = new LoginPO();
        Helper objHelper = new Helper();
        LoginPE objLoginPE = new LoginPE();
        
        [TestMethod]
        public void LoginToApplication()
        {
            
            string applicationUrl = "https://s1.demo.opensourcecms.com/wordpress/wp-login.php";
            objHelper.BrowseApplicationUrl(applicationUrl);
            objLoginPO.LoginToApplication("opensourcecms", "opensourcecms");
            if (objHelper.isElementDisplayed(objLoginPE.welcomePanel, 20))
            {
            }
        }

        

        [ClassCleanup]
        public void cleanup()
        {
        }
    }
}
