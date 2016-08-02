// Copyright (c) 2015 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.AspNetCore.Responsiveness.DependencyInjection
{
    /// <summary>
    /// An interface for configuring Responsiveness services.
    /// </summary>
    public interface IResponsivenessBuilder
    {
        IServiceCollection Services { get; }
    }
}
