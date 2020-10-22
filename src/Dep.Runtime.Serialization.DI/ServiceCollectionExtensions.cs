/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 13:13:17
 * Code:               ServiceCollectionExtensions.cs
 * ********************************************************************************************
 */

using Microsoft.Extensions.DependencyInjection;
using NetowlsStudio.Dep.Runtime.Serializations;
using NetowlsStudio.Dep.Runtime.Serializations.Providers;

namespace NetowlsStudio.Dep.DependencyInjection
{
    /// <summary> 为 <see cref="IServiceCollection" /> 类型提供的扩展方法。 </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary> 添加序列化服务。 </summary>
        /// <param name="services"> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IServiceCollection" />
        public static void AddSerializers(this IServiceCollection services)
        {
            services.AddTransient<ISerializer, BinarySerializer>()
                    .AddTransient<ISerializer, XmlSerializer>()
                    .AddTransient<ISerializer, JsonSerializer>();
        }
    }
}