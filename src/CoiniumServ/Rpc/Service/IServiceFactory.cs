﻿#region License
// 
//     CoiniumServ - crypto currency pool software - https://github.com/CoiniumServ/CoiniumServ
//     Copyright (C) 2013 - 2014, Coinium Project - http://www.coinium.org
// 
//     This software is dual-licensed: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//    
//     For the terms of this license, see licenses/gpl_v3.txt.
// 
//     Alternatively, you can license this software under a commercial
//     license or white-label it as set out in licenses/commercial.txt.
// 
#endregion
using Coinium.Coin.Daemon;
using Coinium.Mining.Jobs;
using Coinium.Mining.Shares;

namespace Coinium.Rpc.Service
{
    public interface IServiceFactory
    {
        /// <summary>
        /// Gets the specified service name.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="jobManager">The job manager.</param>
        /// <param name="shareManager">The share manager.</param>
        /// <param name="daemonClient">The daemon client.</param>
        /// <returns></returns>
        IRpcService Get(string serviceName, IJobManager jobManager, IShareManager shareManager, IDaemonClient daemonClient);
    }
}
