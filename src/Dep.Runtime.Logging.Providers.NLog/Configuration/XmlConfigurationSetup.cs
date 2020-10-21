/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 10:27:28
 * Code:               XmlConfigurationSetup.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Configuration;
using NLog.Config;
using System.IO;

namespace NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration
{
    /// <summary>
    /// 提供了从 XML 配置文件初始化 NLog 配置相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="NLogConfigurationSetup" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class XmlConfigurationSetup : NLogConfigurationSetup
    {
        private readonly string m_envName;

        /// <summary> 用于初始化一个 <see cref="XmlConfigurationSetup" /> 类型的对象实例。 </summary>
        /// <param name="envName"> 当前的运行环境名称。 </param>
        public XmlConfigurationSetup(string envName)
        {
            m_envName = envName;
        }

        /// <summary> 创建 NLog 配置。 </summary>
        /// <returns> <see cref="LoggingConfiguration" /> 类型的对象实例。 </returns>
        /// <seealso cref="LoggingConfiguration" />
        /// <exception cref="System.Security.SecurityException"> </exception>
        /// <exception cref="System.UnauthorizedAccessException"> </exception>
        /// <exception cref="PathTooLongException"> </exception>
        /// <exception cref="FileNotFoundException"> </exception>
        public override LoggingConfiguration Get()
        {
            var configFile = new FileInfo(Path.Combine(ConfigurationDefaults.StoragePath.FullName, $"NLog.{m_envName}.config"));
            if (configFile.Exists)
                return new XmlLoggingConfiguration(configFile.FullName);
            else
            {
                new TraceListenerWriter().WriteWarning<XmlConfigurationSetup>($"未能找到环境相关的配置文件 “{configFile.FullName}”");
                configFile = new FileInfo(Path.Combine(ConfigurationDefaults.StoragePath.FullName, "NLog.config"));
                if (!configFile.Exists)
                    throw new FileNotFoundException(string.Format(DepException.MessageTemplate, "未能找到任何 NLog 配置文件"), configFile.FullName);
                return new XmlLoggingConfiguration(configFile.FullName);
            }
        }
    }
}