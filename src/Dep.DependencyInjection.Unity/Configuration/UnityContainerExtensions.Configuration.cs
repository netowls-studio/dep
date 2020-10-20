/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 10:02:57
 * Code:               UnityContainerExtensions.Configuration.cs
 * ********************************************************************************************
 */

using System;
using System.IO;
using Unity;
using Unity.Injection;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 为 <see cref="IUnityContainer" /> 类型提供的扩展方法。 </summary>
    public static class UnityContainerExtensions
    {
        /// <summary> 添加单例的配置访问程序。 </summary>
        /// <typeparam name="TOptions"> 实现了 <see cref="IDepOptions" /> 接口的类型。 </typeparam>
        /// <typeparam name="TBroker"> 派生自 <see cref="BasedEnterpriseLibraryBroker{TOptions}" /> 的类型。 </typeparam>
        /// <param name="container"> 实现了 <see cref="IUnityContainer" /> 类型接口的对象实例。 </param>
        /// <param name="configFileName"> 配置文件路径。 </param>
        /// <seealso cref="IUnityContainer" />
        /// <seealso cref="IDepOptions" />
        /// <seealso cref="BasedEnterpriseLibraryBroker{TOptions}" />
        /// <exception cref="System.Security.SecurityException"> </exception>
        /// <exception cref="UnauthorizedAccessException"> </exception>
        /// <exception cref="PathTooLongException"> </exception>
        /// <exception cref="FileNotFoundException"> </exception>
        public static void AddSingletonConfigurationBroker<TOptions, TBroker>(this IUnityContainer container, string configFileName)
            where TOptions : class, IDepOptions
            where TBroker : BasedEnterpriseLibraryBroker<TOptions>
        {
            if (string.IsNullOrWhiteSpace(configFileName))
                throw new ArgumentNullException(nameof(configFileName),
                                                string.Format(DepException.MessageTemplate, $"未提供有效的配置文件路径 @{nameof(configFileName)}"));
            var configFile = new FileInfo(configFileName);
            if (!configFile.Exists)
                throw new FileNotFoundException(string.Format(DepException.MessageTemplate, $"未找到指定的配置文件 “{configFile.FullName}”"),
                                                configFile.FullName);
            container.RegisterSingleton<TBroker>(new InjectionConstructor(configFile.FullName));
        }
    }
}