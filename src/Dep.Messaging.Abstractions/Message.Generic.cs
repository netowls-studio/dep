/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 11:27:25
 * Code:               Message.Generic.cs
 * ********************************************************************************************
 */

using Newtonsoft.Json;
using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了消息信息相关的基本方法。 </summary>
    /// <typeparam name="TBody"> 消息体类型。 </typeparam>
    /// <seealso cref="IMessage{TBody}" />
    /// <seealso cref="Message" />
    [Serializable]
    public abstract class Message<TBody> : Message, IMessage<TBody>
    {
        /// <summary> 用于初始化一个 <see cref="Message" /> 类型的对象实例。 </summary>
        protected Message()
        {
        }

        /// <summary> 用于初始化一个 <see cref="Message{TBody}" /> 类型的对象实例。 </summary>
        /// <param name="header"> </param>
        /// <param name="body"> </param>
        protected Message(IHeader header, object body) : base(header, body)
        {
        }

        /// <summary> 用于初始化一个 <see cref="Message{TBody}" /> 类型的对象实例。 </summary>
        /// <param name="header"> </param>
        protected Message(IHeader header) : base(header)
        {
        }

        /// <summary> 消息体数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TBody" /> 类型的对象实例或值，用于表示消息体数据。 </value>
        [JsonIgnore]
        TBody IMessage<TBody>.Body
        {
            get { return Body; }
            set { Body = value; }
        }

        /// <summary> 消息体数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TBody" /> 类型的对象实例或值，用于表示消息体数据。 </value>
        [JsonProperty("body")]
        public virtual new TBody Body { get; set; }
    }
}