/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 12:38:18
 * Code:               ServiceDiscovery.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.DependencyInjection;
using NetowlsStudio.Dep.Annotations;
using System;

namespace NetowlsStudio.Dep.DependencyInjection
{
    /// <summary> 提供了查找依赖注入服务相关的方法。 </summary>
    /// <seealso cref="IServiceDiscovery" />
    public class ServiceDiscovery : IServiceDiscovery
    {
        /// <summary> 用于初始化一个 <see cref="ServiceDiscovery" /> 类型的对象实例。 </summary>
        /// <param name="serviceProvider"> .NET Core 提供的 <see cref="IServiceProvider" /> 类型的对象实例。 </param>
        public ServiceDiscovery(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        /// <summary> .NET Core 提供的 <see cref="IServiceProvider" /> 类型的对象实例。 </summary>
        /// <seealso cref="IServiceProvider" />
        protected virtual IServiceProvider ServiceProvider { get; }

        /// <summary> 查找指定名称的服务。 </summary>
        /// <typeparam name="TService"> 服务类型。 </typeparam>
        /// <param name="name"> 服务注册名称。 </param>
        /// <returns> <typeparamref name="TService" /> 类型的对象实例。 </returns>
        /// <seealso cref="Annotations.InjectionNameAttribute" />
        /// <exception cref="System.Reflection.AmbiguousMatchException"> </exception>
        /// <exception cref="TypeLoadException"> </exception>
        public TService Discover<TService>(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return ServiceProvider.GetService<TService>();
            else
            {
                var services = ServiceProvider.GetServices<TService>();
                TService targetSvc = ServiceProvider.GetService<TService>();
                foreach (var svc in services)
                {
                    var attr = Attribute.GetCustomAttribute(svc.GetType(), typeof(InjectionNameAttribute)) as InjectionNameAttribute;
                    if (!(attr is null)
                        && !string.IsNullOrWhiteSpace(attr.ServiceName)
                        && attr.ServiceName.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                    {
                        targetSvc = (TService)svc;
                        break;
                    }
                }
                return targetSvc;
            }
        }
    }
}