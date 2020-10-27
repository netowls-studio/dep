/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 13:14:23
 * Code:               Message.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;
using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了消息相关的基本方法。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
    /// <seealso cref="IMessage{TData}" />
    /// <seealso cref="ISerializableObject" />
    /// <seealso cref="SerializableObject" />
    [Serializable, XmlRoot(ElementName = "messageContent", Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class Message<TData> : SerializableObject, IMessage<TData>
    {
        /// <summary> 用于初始化一个 <see cref="Message{TData}" /> 类型的对象实例。 </summary>
        public Message() : this(default)
        {
        }

        /// <summary> 用于初始化一个 <see cref="Message{TData}" /> 类型的对象实例。 </summary>
        /// <param name="data"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        public Message(TData data)
        {
            Data = data;
        }

        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TData" /> 类型的对象实例或值，用于表示消息数据。 </value>
        [XmlElement(ElementName = "body", Namespace = XmlSerializerNamespaceDefaults.Uri), JsonProperty("body")]
        public virtual TData Data { get; set; }
    }
}