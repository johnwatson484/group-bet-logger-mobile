namespace LJS.GroupBetLogger.Mobile
{
    public static class AppSettings
    {
#if DEVELOPMENT
        public const string ApiEndPoint = "http://localhost:64093/";
#elif TEST
        public const string ApiEndPoint = "http://40.113.79.94/ljs.groupbetlogger.api/";
#elif RELEASE
        public const string ApiEndPoint = "https://lynxmagnus.com/ljs.groupbetlogger.api/";
#endif
    }
}
