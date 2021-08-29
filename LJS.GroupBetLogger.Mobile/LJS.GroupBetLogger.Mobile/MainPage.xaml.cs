using LJS.GroupBetLogger.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LJS.GroupBetLogger.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void BtnRegister_Clicked(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string email = Email.Text;
            string password = Password.Text;
            string confirmPassword = ConfirmPassword.Text;

            RegisterService regService = new RegisterService();

            regService.RegisterUser(userName, email, password, confirmPassword);


        }

        async void SignIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

    }
}
