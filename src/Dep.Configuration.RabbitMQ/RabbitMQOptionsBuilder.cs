/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 13:39:52
 * Code:               RabbitMQOptionsBuilder.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary> 提供了构建 <see cref="RabbitMQOptions" /> 类型的对象实例相关的方法。 </summary>
    /// <seealso cref="IObjectBuilder{T}" />
    public class RabbitMQOptionsBuilder : IObjectBuilder<RabbitMQOptions>
    {
        /// <summary> 默认的 RabbitMQ 服务器配置名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示默认的 RabbitMQ 服务器配置名称。 </value>
        protected virtual string DefaultServer { get; set; }

        /// <summary> RabbitMQ 服务器配置字典集合。 </summary>
        /// <value> 设置或获取 <see cref="IDictionary{TKey, TValue}" /> 类型的对象实例，用于表示 RabbitMQ 服务器配置字典集合。 </value>
        /// <seealso cref="IDictionary{TKey, TValue}" />
        /// <seealso cref="Dictionary{TKey, TValue}" />
        protected IDictionary<string, RabbitMQServerOptions> Servers { get; } = new Dictionary<string, RabbitMQServerOptions>();

        /// <summary> 构建 <see cref="RabbitMQOptions" /> 类型的对象实例。 </summary>
        /// <returns> <seealso cref="RabbitMQOptions" /> 类型的对象实例。 </returns>
        public RabbitMQOptions Build() => new RabbitMQOptions(DefaultServer, Servers.Values);

        /// <summary> 设置默认的 RabbitMQ 服务器配置名称。 </summary>
        /// <param name="defaultServerName"> 默认的 RabbitMQ 服务器配置名称。 </param>
        /// <returns> <see cref="RabbitMQOptionsBuilder" /> 类型的对象实例。 </returns>
        public virtual RabbitMQOptionsBuilder WithDefault(string defaultServerName)
        {
            DefaultServer = defaultServerName;
            return this;
        }

        /// <summary> 设置 RabbitMQ 服务器配置。 </summary>
        /// <param name="server"> RabbitMQ 服务器配置。 </param>
        /// <returns> <see cref="RabbitMQOptionsBuilder" /> 类型的对象实例。 </returns>
        /// <seealso cref="RabbitMQServerOptions" />
        public virtual RabbitMQOptionsBuilder WithServer(RabbitMQServerOptions server)
        {
            Servers[server.Name] = server;
            return this;
        }

        /// <summary> 设置 RabbitMQ 服务器配置。 </summary>
        /// <param name="builder"> 实现了 <see cref="IObjectBuilder{T}" /> 类型接口的对象实例。 </param>
        /// <returns> <see cref="RabbitMQOptionsBuilder" /> 类型的对象实例。 </returns>
        /// <seealso cref="IObjectBuilder{T}" />
        /// <seealso cref="RabbitMQServerOptions" />
        public virtual RabbitMQOptionsBuilder WithServerBuilder(IObjectBuilder<RabbitMQServerOptions> builder) => WithServer(builder.Build());
    }
}