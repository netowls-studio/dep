/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 12:39:40
 * Code:               RabbitMQServerOptions.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了 RabbitMQ 服务器相关的配置。 </summary>
    /// <seealso cref="IDepOptions" />
    public class RabbitMQServerOptions : IDepOptions
    {
        private string m_name;

        /// <summary> 用于初始化一个 <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </summary>
        /// <param name="name"> RabbitMQ 服务器标识名称。 </param>
        /// <param name="hostName"> RabbitMQ 服务器主机名称。 </param>
        /// <param name="userName"> 用户名。 </param>
        /// <param name="password"> 密码。 </param>
        /// <param name="enabled"> 是否启用。 </param>
        public RabbitMQServerOptions(string name, string hostName, string userName, string password, bool enabled = true)
            : this(name, hostName, new BasicCredentialsOptions(userName, password), enabled)
        {
        }

        /// <summary> 用于初始化一个 <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </summary>
        /// <param name="name"> RabbitMQ 服务器标识名称。 </param>
        /// <param name="hostName"> RabbitMQ 服务器主机名称。 </param>
        /// <param name="credentialsBuilder"> 构建 <see cref="BasicCredentialsOptions" /> 类型的对象实例的程序。 </param>
        /// <param name="enabled"> 是否启用。 </param>
        public RabbitMQServerOptions(string name, string hostName, BasicCredentialsOptionsBuilder credentialsBuilder, bool enabled = true)
            : this(name, hostName, credentialsBuilder.Build(), enabled)
        {
        }

        /// <summary> 用于初始化一个 <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </summary>
        /// <param name="name"> RabbitMQ 服务器标识名称。 </param>
        /// <param name="hostName"> RabbitMQ 服务器主机名称。 </param>
        /// <param name="credentials"> RabbitMQ 身份认证凭据。 </param>
        /// <param name="enabled"> 是否启用。 </param>
        public RabbitMQServerOptions(string name, string hostName, BasicCredentialsOptions credentials, bool enabled = true)
        {
            Name = name;
            HostName = hostName;
            Credentials = credentials;
            Enabled = enabled;
        }

        /// <summary> 用于初始化一个 <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </summary>
        public RabbitMQServerOptions()
        {
        }

        /// <summary> RabbitMQ 身份认证凭据。 </summary>
        /// <value>
        /// 设置或获取 ? 类型的对象实例，用于表示 RabbitMQ 身份认证凭据。
        /// <para> <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </para>
        /// </value>
        /// <seealso cref="BasicCredentialsOptions" />
        public virtual BasicCredentialsOptions Credentials { get; set; }

        /// <summary> 此 RabbitMQ 服务器是否启用。 </summary>
        /// <value> 设置或获取一个值，用于表示此 RabbitMQ 服务器是否启用。 </value>
        public virtual bool Enabled { get; set; }

        /// <summary> RabbitMQ 服务器主机名称（连接串：IP 地址 + 端口号）。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 RabbitMQ 服务器主机名称（连接串：IP 地址 + 端口号）。 </value>
        public virtual string HostName { get; set; }

        /// <summary> RabbitMQ 服务器名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 RabbitMQ 服务器名称。 </value>
        /// <exception cref="NetowlsStudio.Dep.Configuration.DepConfigurationException"> </exception>
        public virtual string Name
        {
            get { return m_name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new DepConfigurationException($"{DepConfigurationException.DefaultMessage}。缺少必要的 RabbitMQ 服务器标识名称 @{nameof(Name)}");
                m_name = value;
            }
        }
    }
}
