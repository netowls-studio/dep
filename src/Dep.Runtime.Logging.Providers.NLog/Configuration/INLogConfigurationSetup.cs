/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 10:23:54
 * Code:               INLogConfigurationSetup.cs
 * ********************************************************************************************
 */

using NLog.Config;

namespace NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration
{
    /// <summary> 定义了初始化 NLog 配置信息的接口。 </summary>
    public interface INLogConfigurationSetup
    {
        /// <summary> 创建 NLog 配置。 </summary>
        /// <returns> <see cref="LoggingConfiguration" /> 类型的对象实例。 </returns>
        /// <seealso cref="LoggingConfiguration" />
        LoggingConfiguration Get();
    }
}