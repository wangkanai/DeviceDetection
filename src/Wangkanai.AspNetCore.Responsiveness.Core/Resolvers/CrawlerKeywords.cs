namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal class CrawlerKeywords : IUserAgent
    {
        public string[] Keywords { get; } = new string[]
        {

        };

        public KeywordType Type { get; } = KeywordType.Keywords;
    }
}