using Microsoft.AspNetCore.Http;
using System;
using Wangkanai.AspNetCore.Responsiveness.Abstractions.Devices;

namespace Wangkanai.AspNetCore.Responsiveness.Resolvers
{
    internal interface IUserAgent
    {
        bool Interpret(string agent);
        string[] Keywords { get; }
        KeywordType Type { get; }
    }
}