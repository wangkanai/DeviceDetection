﻿// Copyright (c) 2018 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using Wangkanai.Detection;

namespace Wangkanai.Responsive
{
    public class UserPerference
    {
        public string Device { get; protected set; }

        public void Change(DeviceType device){
            this.Device = device.ToString();
        }
    }
}
