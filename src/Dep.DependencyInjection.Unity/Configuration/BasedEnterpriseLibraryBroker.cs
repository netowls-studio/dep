/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 9:46:52
 * Code:               BasedEnterpriseLibraryBroker.cs
 * ********************************************************************************************
 */

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了基于 EnterpriseLibrary 访问配置信息相关的基本方法。 </summary>
    /// <typeparam name="TOptions"> 实现了 <see cref="IDepOptions" /> 接口的类型。 </typeparam>
    /// <seealso cref="IDepOptions" />
    /// <seealso cref="IConfigurationBroker{TOptions}" />
    /// <seealso cref="ConfigurationBroker{TOptions}" />
    public abstract class BasedEnterpriseLibraryBroker<TOptions> : ConfigurationBroker<TOptions>
        where TOptions : class, IDepOptions
    {
        private const int c_defaultRefreshInterval = 5000;

        private IConfigurationSource m_configurationSource;

        /// <summary> 用于初始化一个 <see cref="BasedEnterpriseLibraryBroker{TOptions}" /> 类型的对象实例。 </summary>
        protected BasedEnterpriseLibraryBroker() : this(new SystemConfigurationSource(true, c_defaultRefreshInterval))
        {
        }

        /// <summary> 用于初始化一个 <see cref="BasedEnterpriseLibraryBroker{TOptions}" /> 类型的对象实例。 </summary>
        /// <param name="configFilePath"> 配置文件路径。 </param>
        /// <seealso cref="FileConfigurationSource" />
        protected BasedEnterpriseLibraryBroker(string configFilePath) : this(new FileConfigurationSource(configFilePath, true, c_defaultRefreshInterval))
        {
        }

        /// <summary> 用于初始化一个 <see cref="BasedEnterpriseLibraryBroker{TOptions}" /> 类型的对象实例。 </summary>
        /// <param name="configurationSource">
        /// 配置源信息。
        /// <para> 实现了 <see cref="IConfigurationSource" /> 类型接口的对象实例。 </para>
        /// </param>
        private BasedEnterpriseLibraryBroker(IConfigurationSource configurationSource)
        {
            m_configurationSource = configurationSource;
            m_configurationSource.SourceChanged += ConfigurationSourceChanged;
        }

        /// <summary> 配置源。 </summary>
        /// <value> 设置或获取 <see cref="IConfigurationSource" /> 类型的对象实例，用于表示配置源。 </value>
        /// <seealso cref="IConfigurationSource" />
        protected virtual IConfigurationSource ConfigurationSource
        {
            get { return m_configurationSource; }
            set { m_configurationSource = value; }
        }

        /// <summary> 获取配置信息。 </summary>
        /// <returns> 实现了 <see cref="IDepOptions" /> 类型接口的对象实例。 </returns>
        public override TOptions Get() => InternalGet();

        /// <summary> 配置源变更事件。 </summary>
        /// <param name="sender"> 触发此事件的对象实例。 </param>
        /// <param name="e"> <see cref="ConfigurationSourceChangedEventArgs" /> 类型的对象实例。 </param>
        /// <seealso cref="ConfigurationSourceChangedEventArgs" />
        protected virtual void ConfigurationSourceChanged(object sender, ConfigurationSourceChangedEventArgs e)
        {
            OnConfigurationChanged(Get());
        }

        /// <summary> 获取配置信息。 </summary>
        /// <returns> 实现了 <see cref="IDepOptions" /> 类型接口的对象实例。 </returns>
        protected abstract TOptions InternalGet();
    }
}