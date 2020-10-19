/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/19 11:26:04
 * Code:               ConfigurationChangedEventArgs.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了配置变更相关的事件参数。 </summary>
    /// <seealso cref="EventArgs" />
    public class ConfigurationChangedEventArgs : EventArgs
    {
        private IDepOptions m_changedOptions;

        /// <summary> 用于初始化一个 <see cref="ConfigurationChangedEventArgs" /> 类型的对象实例。 </summary>
        /// <param name="changedOptions"> 变更的配置信息。 </param>
        /// <seealso cref="IDepOptions" />
        public ConfigurationChangedEventArgs(IDepOptions changedOptions)
        {
            m_changedOptions = changedOptions;
        }

        /// <summary> 变更的配置信息。 </summary>
        /// <value> 获取 <see cref="IDepOptions" /> 类型的对象实例，用于表示变更的配置信息。 </value>
        /// <seealso cref="IDepOptions" />
        public virtual IDepOptions ChangedOptions
        {
            get { return m_changedOptions; }
            protected set { m_changedOptions = value; }
        }
    }
}