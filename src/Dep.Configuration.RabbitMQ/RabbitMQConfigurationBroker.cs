/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 11:15:16
 * Code:               RabbitMQConfigurationBroker.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.Options;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了访问 RabbitMQ 配置相关的方法。 </summary>
    /// <seealso cref="IConfigurationBroker{TOptions}" />
    /// <seealso cref="ConfigurationBroker{TOptions}" />
    /// <seealso cref="RabbitMQOptions" />
    public class RabbitMQConfigurationBroker : ConfigurationBroker<RabbitMQOptions>, IConfigurationBroker<RabbitMQOptions>
    {
        /// <summary> 用于初始化一个 <see cref="RabbitMQConfigurationBroker" /> 类型的对象实例。 </summary>
        /// <param name="optionsMonitor"> 实现了 <see cref="IOptionsMonitor{TOptions}" /> 类型接口的对象实例。 </param>
        public RabbitMQConfigurationBroker(IOptionsMonitor<RabbitMQOptions> optionsMonitor)
        {
            RabbitMQOptionsMonitor = optionsMonitor;
            optionsMonitor.OnChange(options => OnConfigurationChanged(options));
        }

        /// <summary> RabbitMQ 配置。 </summary>
        /// <value> 获取 <see cref="RabbitMQOptions" /> 类型的对象实例，用于表示 RabbitMQ 配置。 </value>
        /// <seealso cref="IDepOptions" />
        /// <seealso cref="RabbitMQOptions" />
        public virtual RabbitMQOptions CurrentOptions => RabbitMQOptionsMonitor.CurrentValue;

        /// <summary> 监控 RabbitMQ 配置信息的程序。 </summary>
        /// <value> 设置或获取 <see cref="IOptionsMonitor{TOptions}" /> 类型的对象实例，用于表示监控 RabbitMQ 配置信息的程序。 </value>
        /// <seealso cref="IOptionsMonitor{TOptions}" />
        protected IOptionsMonitor<RabbitMQOptions> RabbitMQOptionsMonitor { get; set; }

        /// <summary> 获取 RabbitMQ 配置信息。 </summary>
        /// <returns> <see cref="RabbitMQOptions" /> 类型的对象实例。 </returns>
        public override RabbitMQOptions Get() => RabbitMQOptionsMonitor.CurrentValue;
    }
}