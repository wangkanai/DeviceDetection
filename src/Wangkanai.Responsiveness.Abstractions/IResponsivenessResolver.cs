// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using Wangkanai.Browser;

namespace Wangkanai.Responsiveness.Abstractions
{
    public interface IResponsivenessResolver
    {
        DeviceInfo DeviceInfo { get; }
    }
}