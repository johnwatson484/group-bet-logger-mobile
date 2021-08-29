using LJS.GroupBetLogger.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJS.GroupBetLogger.Mobile.Services
{
    public class RegisterService : IRegisterService
    {
        public void RegisterUser(string userName, string email, string password, string confirmPassword)
        {


            RegisterModel regModel = new RegisterModel();

            regModel.UserName = userName;
            regModel.Email = email;
            regModel.Password = password;
            regModel.ConfirmPassword = confirmPassword;

            //pass to API after this

        }

    }
}
