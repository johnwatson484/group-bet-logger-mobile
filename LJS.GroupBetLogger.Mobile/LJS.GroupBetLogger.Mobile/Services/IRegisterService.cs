namespace LJS.GroupBetLogger.Mobile.Services
{
    public interface IRegisterService
    {
        void RegisterUser(string userName, string email, string password, string confirmPassword);
    }
}