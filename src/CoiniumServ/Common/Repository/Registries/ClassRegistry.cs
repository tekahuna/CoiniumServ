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
using Coinium.Coin.Algorithms;
using Coinium.Coin.Daemon;
using Coinium.Common.Context;
using Coinium.Mining.Pools;
using Coinium.Mining.Pools.Config;

namespace Coinium.Common.Repository.Registries
{
    public class ClassRegistry : IRegistry
    {
        private readonly IApplicationContext _applicationContext;

        public ClassRegistry(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void RegisterInstances()
        {
            _applicationContext.Container.Register<IHashAlgorithm, Scrypt>(AlgorithmNames.Scrypt).AsSingleton();
            _applicationContext.Container.Register<IDaemonClient, DaemonClient>().AsMultiInstance();
            _applicationContext.Container.Register<IPool, Pool>().AsMultiInstance();
            _applicationContext.Container.Register<IPoolConfig, PoolConfig>().AsMultiInstance();
        }
    }
}