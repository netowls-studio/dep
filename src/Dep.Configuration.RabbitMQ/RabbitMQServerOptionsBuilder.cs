/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 12:46:55
 * Code:               RabbitMQServerOptionsBuilder.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了构建 <see cref="RabbitMQServerOptions" /> 类型的对象实例相关的方法。 </summary>
    /// <seealso cref="IObjectBuilder{T}" />
    /// <seealso cref="RabbitMQServerOptions" />
    public class RabbitMQServerOptionsBuilder : IObjectBuilder<RabbitMQServerOptions>
    {
        /// <summary> RabbitMQ 身份认证凭据。 </summary>
        /// <value> 设置或获取 ? 类型的对象实例，用于表示 RabbitMQ 身份认证凭据。 </value>
        /// <seealso cref="BasicCredentialsOptions" />
        protected virtual BasicCredentialsOptions Credentials { get; set; }

        /// <summary> 是否启用。 </summary>
        /// <value> 设置或获取一个值，用于表示是否启用。 </value>
        protected virtual bool Enabled { get; set; } = true;

        /// <summary> RabbitMQ 主机名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 RabbitMQ 主机名称。 </value>
        protected virtual string HostName { get; set; } = "";

        /// <summary> RabbitMQ 服务器命名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 RabbitMQ 服务器命名。 </value>
        protected virtual string Name { get; set; } = "";

        /// <summary> 构建 <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </summary>
        /// <returns> <see cref="RabbitMQServerOptions" /> 类型的对象实例。 </returns>
        public RabbitMQServerOptions Build() => new RabbitMQServerOptions(Name, HostName, Credentials, Enabled);

        /// <summary> 设置 RabbitMQ 身份认证凭据。 </summary>
        /// <param name="credentials">
        /// 身份认证凭据。
        /// <para> <see cref="BasicCredentialsOptions" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        /// <seealso cref="BasicCredentialsOptions" />
        public virtual RabbitMQServerOptionsBuilder WithCredentials(BasicCredentialsOptions credentials)
        {
            Credentials = credentials;
            return this;
        }

        /// <summary> 设置 RabbitMQ 身份认证凭据。 </summary>
        /// <param name="credentialsBuilder">
        /// 构建身份认证凭据的程序。
        /// <para> 实现了 <see cref="IObjectBuilder{T}" /> 类型接口的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        /// <seealso cref="IObjectBuilder{T}" />
        /// <seealso cref="BasicCredentialsOptions" />
        /// <seealso cref="BasicCredentialsOptionsBuilder" />
        public virtual RabbitMQServerOptionsBuilder WithCredentialsBuilder(IObjectBuilder<BasicCredentialsOptions> credentialsBuilder)
            => WithCredentials(credentialsBuilder.Build());

        /// <summary> 设置禁用当前的 RabbitMQ 主机。 </summary>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQServerOptionsBuilder WithDisable() => WithEnabled(false);

        /// <summary> 设置启用当前的 RabbitMQ 主机。 </summary>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQServerOptionsBuilder WithEnable() => WithEnabled();

        /// <summary> 设置是否启用当前的 RabbitMQ 主机。 </summary>
        /// <param name="enabled"> 是否启用当前的 RabbitMQ 主机。 </param>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQServerOptionsBuilder WithEnabled(bool enabled = true)
        {
            Enabled = enabled;
            return this;
        }

        /// <summary> 设置 RabbitMQ 主机名称。 </summary>
        /// <param name="value"> RabbitMQ 主机名称。 </param>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQServerOptionsBuilder WithHostName(string value)
        {
            HostName = value;
            return this;
        }

        /// <summary> 设置 RabbitMQ 服务器标识名称。 </summary>
        /// <param name="name"> RabbitMQ 服务器标识名称。 </param>
        /// <returns> <see cref="RabbitMQServerOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQServerOptionsBuilder WithName(string name)
        {
            Name = name;
            return this;
        }
    }
}