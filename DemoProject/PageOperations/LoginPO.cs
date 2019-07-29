using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoFramework;
using PageOperations;

namespace PageOperations
{
    public class LoginPO : Helper
    {
        LoginPE objLoginPE = new LoginPE();

        public void LoginToApplication(string username, string password)
        {
            ClearAndSetTextToField(objLoginPE.userName_Txt, "opensourcecms");
            ClearAndSetTextToField(objLoginPE.password_Txt, "opensourcecms");
            ClickElement(objLoginPE.logIn_Btn);
        }

    }
}
