/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 9:46:30
 * Code:               ConfigurationBroker.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了访问 DEP 配置信息相关的基本方法。 </summary>
    /// <typeparam name="TOptions"> 实现了 <see cref="IDepOptions" /> 接口的类型。 </typeparam>
    /// <seealso cref="IConfigurationBroker{TOptions}" />
    /// <seealso cref="IDepOptions" />
    public abstract class ConfigurationBroker<TOptions> : IConfigurationBroker<TOptions>
        where TOptions : class, IDepOptions
    {
        /// <summary> 配置变更事件。 </summary>
        /// <seealso cref="ConfigurationChangedEventHandler" />
        public event ConfigurationChangedEventHandler ConfigurationChanged;

        /// <summary> 获取配置信息。 </summary>
        /// <returns> 实现了 <see cref="IDepOptions" /> 类型接口的对象实例。 </returns>
        TOptions IConfigurationBroker<TOptions>.Get() => Get();

        /// <summary> 获取配置信息。 </summary>
        /// <returns> 实现了 <see cref="IDepOptions" /> 类型接口的对象实例。 </returns>
        public abstract TOptions Get();

        /// <summary> 用于引发 <see cref="ConfigurationChanged" /> 事件。 </summary>
        /// <param name="changedOptions"> 变更的 <see cref="IDepOptions" /> 类型的对象实例。 </param>
        /// <seealso cref="IDepOptions" />
        protected virtual void OnConfigurationChanged(IDepOptions changedOptions)
        {
            ConfigurationChanged?.Invoke(this, new ConfigurationChangedEventArgs(changedOptions));
        }
    }
}