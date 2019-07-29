using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PageOperations
{
    public class LoginPE
    {
        public By userName_Txt = By.Id("user_login");
        public By password_Txt = By.Id("user_pass");
        public By logIn_Btn = By.Id("wp-submit");
        public By welcomePanel = By.Id("welcome-panel");

    }
}
