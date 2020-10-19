/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 11:38:24
 * Code:               ServiceCollectionExtensions.RabbitMQ.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary> 注册 RabbitMQ 配置服务。 </summary>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <param name="configuration"> 实现了 <see cref="IConfiguration" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="IConfiguration" />
        public static void AddRabbitMQOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDepOptions<RabbitMQOptions>(configuration, RabbitMQOptions.Path);
            services.AddSingletonBroker<RabbitMQOptions, RabbitMQConfigurationBroker>();
        }
    }
}