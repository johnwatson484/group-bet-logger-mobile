using LJS.GroupBetLogger.Mobile.Validators.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LJS.GroupBetLogger.Mobile.Validators.Implementations
{
    public class ConfirmPasswordValidator: IValidator
    {

        public string Message { get; set; } = "Passwords do no match";

        public string PasswordCheck { get; set; }

        public bool Check(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value == PasswordCheck)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
