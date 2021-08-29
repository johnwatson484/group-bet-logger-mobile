using LJS.GroupBetLogger.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LJS.GroupBetLogger.Mobile.Services
{
    public class UserService
    {
        IRequestService requestService;

        public UserService(IRequestService requestService)
        {
            this.requestService = requestService;
        }

        public async Task<List<User>> GetUserAsync()
        {
            UriBuilder builder = new UriBuilder($"{AppSettings.ApiEndPoint}/api/users");
            var url = builder.ToString();
            return await requestService.GetAsync<List<User>>(url, TokenService.GetTokenAsync()?.Result.AccessToken);
        }
    }
}
