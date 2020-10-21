/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 11:07:49
 * Code:               UnityContainerExtensions.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging;
using NetowlsStudio.Dep.Runtime.Logging.Providers;
using NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration;
using System;
using Unity;
using Unity.Lifetime;

namespace NetowlsStudio.Dep.Unity
{
    /// <summary> 为 <see cref="IUnityContainer" /> 类型提供的扩展方法。 </summary>
    public static class UnityContainerExtensions
    {
        /// <summary> 添加运行时日志服务。 </summary>
        /// <typeparam name="TWriter"> 实现了 <see cref="ILogWriter" /> 接口的类型。 </typeparam>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="ILogWriter" />
        /// <exception cref="System.Reflection.TargetInvocationException"> </exception>
        /// <exception cref="MethodAccessException"> </exception>
        /// <exception cref="MemberAccessException"> </exception>
        /// <exception cref="System.Runtime.InteropServices.InvalidComObjectException"> </exception>
        /// <exception cref="MissingMethodException"> </exception>
        /// <exception cref="System.Runtime.InteropServices.COMException"> </exception>
        /// <exception cref="TypeLoadException"> </exception>
        public static void AddLogWriter<TWriter>(this IUnityContainer container)
            where TWriter : class, ILogWriter, new()
        {
            container.RegisterType<ILogWriter, TWriter>(new PerResolveLifetimeManager());
            (LogWriter.CurrentWriter as LogWriter).Writers.Add(Activator.CreateInstance(typeof(TWriter)) as ILogWriter);
        }

        /// <summary> 添加默认的单例运行时日志服务。 </summary>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="LogWriter" />
        public static void AddSingletonDefaultWriter(this IUnityContainer container) => container.RegisterInstance((LogWriter.CurrentWriter as LogWriter));

        /// <summary> 配置 NLog 运行时日志服务。 </summary>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <param name="setup"> 实现了 <see cref="INLogConfigurationSetup" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="INLogConfigurationSetup" />
        public static void ConfigureNLog(this IUnityContainer container, INLogConfigurationSetup setup)
        {
            NLogWriter.Setup(setup);
            container.AddLogWriter<NLogWriter>();
        }
    }
}