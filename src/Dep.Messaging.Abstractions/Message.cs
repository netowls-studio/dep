/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 11:12:53
 * Code:               Message.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;
using Newtonsoft.Json;
using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了消息相关的基本方法。 </summary>
    /// <seealso cref="IMessage" />
    /// <seealso cref="SerializableObject" />
    [Serializable]
    public abstract class Message : SerializableObject, IMessage
    {
        private IHeader m_header;

        /// <summary> 用于初始化一个 <see cref="Message" /> 类型的对象实例。 </summary>
        protected Message()
        {
        }

        /// <summary> 用于初始化一个 <see cref="Message" /> 类型的对象实例。 </summary>
        /// <param name="header"> </param>
        /// <param name="body"> </param>
        protected Message(IHeader header, object body)
        {
            m_header = header;
            Body = body;
        }

        /// <summary> 用于初始化一个 <see cref="Message" /> 类型的对象实例。 </summary>
        /// <param name="header"> </param>
        protected Message(IHeader header) : this(header, null)
        {
        }

        /// <summary> 消息体信息。 </summary>
        /// <value> 设置或获取 <see cref="object" /> 类型的对象实例，用于表示消息体信息。 </value>
        [JsonProperty("data")]
        public virtual object Body { get; set; }

        /// <summary> 消息头摘要信息。 </summary>
        /// <value> 设置或获取 <see cref="IHeader" /> 类型的对象实例，用于表示消息头摘要信息。 </value>
        /// <seealso cref="IHeader" />
        [JsonIgnore]
        IHeader IMessage.Header
        {
            get { return m_header; }
            set { m_header = value; }
        }

        /// <summary> 消息头摘要信息。 </summary>
        /// <value> 设置或获取 <see cref="Header" /> 类型的对象实例，用于表示消息头摘要信息。 </value>
        /// <seealso cref="IHeader" />
        /// <seealso cref="Header" />
        [JsonProperty("header")]
        public virtual Header Header
        {
            get { return m_header as Header; }
            set { m_header = value; }
        }
    }
}