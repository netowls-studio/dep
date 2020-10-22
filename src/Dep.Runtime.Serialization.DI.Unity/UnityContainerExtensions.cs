/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 13:18:52
 * Code:               UnityContainerExtensions.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;
using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Unity;
using Unity.Lifetime;

namespace NetowlsStudio.Dep.Unity
{
    /// <summary> 为 <see cref="IUnityContainer" /> 类型提供的扩展方法。 </summary>
    public static class UnityContainerExtensions
    {
        /// <summary> 注册序列化服务。 </summary>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IUnityContainer" />
        public static void AddSerializers(this IUnityContainer container)
        {
            container.RegisterType<ISerializer, BinarySerializer>(nameof(BinarySerializer), new PerResolveLifetimeManager())
                     .RegisterType<ISerializer, XmlSerializer>(nameof(XmlSerializer), new PerResolveLifetimeManager())
                     .RegisterType<ISerializer, JsonSerializer>(nameof(JsonSerializer), new PerResolveLifetimeManager());
        }
    }
}