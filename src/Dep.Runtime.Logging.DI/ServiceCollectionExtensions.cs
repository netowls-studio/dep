/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 10:44:32
 * Code:               ServiceCollectionExtensions.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.DependencyInjection;
using NetowlsStudio.Dep.Runtime.Logging;
using NetowlsStudio.Dep.Runtime.Logging.Providers;
using NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration;
using System;

namespace NetowlsStudio.Dep.DependencyInjection
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary> 添加运行时日志服务。 </summary>
        /// <typeparam name="TWriter"> 实现了 <see cref="ILogWriter" /> 接口的类型。 </typeparam>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="ILogWriter" />
        public static void AddLogWriter<TWriter>(this IServiceCollection services)
            where TWriter : class, ILogWriter, new()
        {
            services.AddTransient<ILogWriter, TWriter>();
            (LogWriter.CurrentWriter as LogWriter).Writers.Add(Activator.CreateInstance<TWriter>());
        }

        /// <summary> 添加默认的运行时日志服务。 </summary>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IServiceCollection" />
        /// <seealso cref="LogWriter" />
        public static void AddSingletonDefaultWriter(this IServiceCollection services)
            => services.AddSingleton((LogWriter.CurrentWriter as LogWriter));

        /// <summary> 配置 NLog 日志服务。 </summary>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <param name="setup"> 实现了 <see cref="INLogConfigurationSetup" /> 类型接口的对象实例。 </param>
        /// <seealso cref="INLogConfigurationSetup" />
        /// <seealso cref="IServiceCollection" />
        public static void ConfigureNLog(this IServiceCollection services, INLogConfigurationSetup setup)
        {
            NLogWriter.Setup(setup);
            services.AddLogWriter<NLogWriter>();
        }
    }
}