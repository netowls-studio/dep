/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 13:32:32
 * Code:               UnityContainerExtensions.cs
 * ********************************************************************************************
 */

using System;
using Unity;
using Unity.Injection;

namespace NetowlsStudio.Dep.Unity
{
    /// <summary> 为 <see cref="IUnityContainer" /> 类型提供的扩展方法。 </summary>
    public static class UnityContainerExtensions
    {
        /// <summary> 注册 DEP 服务。 </summary>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <param name="envName"> DEP 运行环境名称。 </param>
        /// <param name="configure"> 服务注册方法。 </param>
        /// <returns> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="Action{T}" />
        public static IUnityContainer AddDepServices(this IUnityContainer container, string envName, Action<IUnityContainer> configure)
        {
            container.RegisterSingleton<IDepContext, DepContext>(new InjectionConstructor(new RunningEnvironment(envName)));
            configure?.Invoke(container);
            return container;
        }
    }
}