/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 10:25:29
 * Code:               ServiceCollectionExtensions.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace NetowlsStudio.Dep.DependencyInjection
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary> 注册 DEP 服务。 </summary>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <param name="configuration"> 实现了 <see cref="IConfiguration" /> 类型接口的对象实例。 </param>
        /// <param name="environment"> 实现了 <see cref="IHostEnvironment" /> 类型接口的对象实例。 </param>
        /// <param name="configure"> 配置方法。 </param>
        /// <returns> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="IConfiguration" />
        /// <seealso cref="IHostEnvironment" />
        /// <seealso cref="Action{T1, T2, T3}" />
        public static IServiceCollection AddDepServices(this IServiceCollection services,
                                                        IConfiguration configuration,
                                                        IHostEnvironment environment,
                                                        Action<IServiceCollection, IConfiguration, IHostEnvironment> configure)
        {
            configure?.Invoke(services, configuration, environment);
            return services;
        }
    }
}