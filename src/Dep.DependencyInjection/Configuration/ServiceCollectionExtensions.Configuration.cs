/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 10:38:19
 * Code:               ServiceCollectionExtensions.Configuration.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary> 注册 DEP 配置。 </summary>
        /// <typeparam name="TOptions"> 实现了 <see cref="IServiceCollection" /> 接口的类型。 </typeparam>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <param name="configuration"> 实现了 <see cref="IConfiguration" /> 类型接口的对象实例。 </param>
        /// <param name="configPath"> 配置路径。 </param>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="IConfiguration" />
        /// <seealso cref="Action{T1, T2}" />
        public static void AddDepOptions<TOptions>(this IServiceCollection services,
                                                   IConfiguration configuration,
                                                   string configPath = "Dep")
            where TOptions : class, IDepOptions
        {
            services.AddOptions<TOptions>().Configure(options =>
            {
                configuration.Bind(configPath, options);
            });
        }

        /// <summary> 注册一个单例的 DEP 配置访问服务。 </summary>
        /// <typeparam name="TOptions"> 实现了 <see cref="IDepOptions" /> 接口的类型。 </typeparam>
        /// <typeparam name="TBroker"> 实现了 <see cref="IConfigurationBroker{TOptions}" /> 接口的类型。 </typeparam>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <param name="broker"> 实现了 <see cref="IConfigurationBroker{TOptions}" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="IDepOptions" />
        /// <seealso cref="IConfigurationBroker{TOptions}" />
        public static void AddSingletonBroker<TOptions, TBroker>(this IServiceCollection services, TBroker broker)
            where TOptions : class, IDepOptions
            where TBroker : class, IConfigurationBroker<TOptions> => services.AddSingleton(broker);
    }
}