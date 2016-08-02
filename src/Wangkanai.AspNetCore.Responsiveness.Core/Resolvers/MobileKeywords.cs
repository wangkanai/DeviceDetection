namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class MobileKeywords : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {
            "blackberry", "webos", "ipod", "lge vx", "midp", "maemo", "mmp", "mobile",
            "netfront", "hiptop", "nintendo DS", "novarra", "openweb", "opera mobi",
            "opera mini", "palm", "psp", "phone", "smartphone", "symbian", "up.browser",
            "up.link", "wap", "windows ce"
        };
        public KeywordType Type { get; } = KeywordType.Keywords;
    }
}