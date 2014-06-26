#region License
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
using Coinium.Common.Context;
using Serilog;

namespace Coinium.Coin.Algorithms
{
    public class HashAlgorithmFactory : IHashAlgorithmFactory
    {
        /// <summary>
        /// The application context.
        /// </summary>
        private readonly IApplicationContext _applicationContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="HashAlgorithmFactory" /> class.
        /// </summary>
        /// <param name="applicationContext">The application context.</param>
        public HashAlgorithmFactory(IApplicationContext applicationContext)
        {
            Log.Debug("HashAlgorithmFactory() init..");
            _applicationContext = applicationContext;
        }

        /// <summary>
        /// Gets the specified algorithm name.
        /// </summary>
        /// <param name="algorithmName">Name of the algorithm.</param>
        /// <returns></returns>
        public IHashAlgorithm Get(string algorithmName)
        {
            // Default to Scrypt
            if (string.IsNullOrWhiteSpace(algorithmName)) algorithmName = AlgorithmNames.Scrypt;

            return _applicationContext.Container.Resolve<IHashAlgorithm>(algorithmName);
        }
    }
}