// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Wangkanai.Responsive
{
    public interface IResponsiveBuilder
    {
        IServiceCollection Services { get; }
    }
}
