/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 13:28:27
 * Code:               RabbitMQOptions.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;
using System.Linq;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了 RabbitMQ 相关的配置。 </summary>
    /// <seealso cref="IDepOptions" />
    public class RabbitMQOptions : IDepOptions
    {
        /// <summary> 配置路径。 </summary>
        public const string Path = "Dep:RabbitMQ";

        private string m_defaultServerName;

        /// <summary> 用于初始化一个 <see cref="RabbitMQOptions" /> 类型的对象实例。 </summary>
        public RabbitMQOptions()
        {
        }

        /// <summary> 用于初始化一个 <see cref="RabbitMQOptions" /> 类型的对象实例。 </summary>
        /// <param name="defaultServer"> 默认的 RabbitMQ 服务配置名称。 </param>
        /// <param name="servers"> <see cref="RabbitMQServerOptions" /> 类型的对象实例集合。 </param>
        public RabbitMQOptions(string defaultServer, IEnumerable<RabbitMQServerOptions> servers)
        {
            DefaultServer = defaultServer;
            Servers = servers?.ToArray();
        }

        /// <summary> 默认的服务器配置名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示默认的服务器配置名称。 </value>
        /// <exception cref="NetowlsStudio.Dep.Configuration.DepConfigurationException"> </exception>
        public virtual string DefaultServer
        {
            get { return m_defaultServerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DepConfigurationException($"{DepConfigurationException.DefaultMessage}。未提供默认 RabbitMQ 服务器配置 @{nameof(DefaultServer)}");
                m_defaultServerName = value;
            }
        }

        /// <summary> RabbitMQ 服务器配置。 </summary>
        /// <value> 设置或获取 <see cref="RabbitMQServerOptions" /> 类型的对象实例数组，用于表示 RabbitMQ 服务器配置。 </value>
        /// <seealso cref="RabbitMQServerOptions" />
        public virtual RabbitMQServerOptions[] Servers { get; set; }
    }
}