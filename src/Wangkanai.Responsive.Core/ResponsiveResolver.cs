// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Wangkanai.Browser;
using Wangkanai.Responsive.Abstractions;

namespace Wangkanai.Responsive
{
    public class ResponsiveResolver : IResponsiveResolver
    {        
        private IClientInfo _clientInfo;    

        public ResponsiveResolver(IClientInfo clientInfo)
        {
            if(clientInfo == null) throw new ArgumentNullException(nameof(clientInfo));
            
            _clientInfo = clientInfo;
        }
    }
}