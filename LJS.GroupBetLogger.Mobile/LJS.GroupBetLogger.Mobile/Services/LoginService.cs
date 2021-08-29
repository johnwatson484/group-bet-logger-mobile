using LJS.GroupBetLogger.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJS.GroupBetLogger.Mobile.Services
{
    public class LoginService : ILoginService
    {

        public void LoginUser(string userName, string password)
        {
            LoginModel loginModel = new LoginModel();

            loginModel.UserName = userName;
            loginModel.Password = password;

            //pass to API after this
        }
    }
}
