﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.NLogIntegration
{
    using BusConfigurators;
    using Logging;
    using MassTransit.Util;
    using NLog;
    using Logger = MassTransit.Logging.Logger;

    /// <summary>
	/// Extensions for configuring NLog with MassTransit
	/// </summary>
    public static class NLogConfiguratorExtensions
    {
		/// <summary>
		/// Specify that you want to use the NLog logging framework with MassTransit.
		/// </summary>
		/// <param name="configurator">Optional service bus configurator</param>
		public static void UseNLog([CanBeNull] this ServiceBusConfigurator configurator)
        {
            Logger.UseLogger(new NLogLogger());
        }

        /// <summary>
        /// Specify that you want to use the NLog logging framework with MassTransit.
        /// </summary>
        /// <param name="configurator">Optional service bus configurator</param>
        /// <param name="factory">NLog factory with which to produce loggers</param>
        public static void UseNLog([CanBeNull] this ServiceBusConfigurator configurator, [NotNull] LogFactory factory)
        {
            Logger.UseLogger(new NLogLogger(factory));
        }
    }
}