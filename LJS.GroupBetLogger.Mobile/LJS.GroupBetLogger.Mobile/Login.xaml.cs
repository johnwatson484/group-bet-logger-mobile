using LJS.GroupBetLogger.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LJS.GroupBetLogger.Mobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent();
		}

		private void BtnLogin_Clicked(object sender, EventArgs e)
		{
			string userName = UserName.Text;
			string password = Password.Text;


			LoginService loginService = new LoginService();

			loginService.LoginUser(userName, password);

		}
	}
}