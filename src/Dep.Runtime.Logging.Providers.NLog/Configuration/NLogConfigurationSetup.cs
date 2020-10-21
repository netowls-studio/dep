/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 * 
 * 
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 10:26:22
 * Code:               NLogConfigurationSetup.cs
 * ********************************************************************************************
 */

using NLog.Config;

namespace NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration
{
    /// <summary> 提供了初始化 NLog 配置信息相关的基本方法。 </summary>
    /// <seealso cref="INLogConfigurationSetup" />
    public abstract class NLogConfigurationSetup : INLogConfigurationSetup
    {
        /// <summary> 用于初始化一个 <see cref="NLogConfigurationSetup" /> 类型的对象实例。 </summary>
        protected NLogConfigurationSetup()
        {
        }

        /// <summary> 创建 NLog 配置。 </summary>
        /// <returns> <see cref="LoggingConfiguration" /> 类型的对象实例。 </returns>
        /// <seealso cref="LoggingConfiguration" />
        public abstract LoggingConfiguration Get();
    }
}
