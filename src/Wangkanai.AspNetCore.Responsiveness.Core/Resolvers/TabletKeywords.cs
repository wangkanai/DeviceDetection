namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class TabletKeywords : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {
            "ipad", "playbook", "hp-tablet", "kindle"
        };
        public KeywordType Type { get; } = KeywordType.Keywords;
    }
}