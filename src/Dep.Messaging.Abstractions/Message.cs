/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/28 14:59:50
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
    /// <summary> 提供了 DEP 消息相关的方法。 </summary>
    /// <seealso cref="IMessage" />
    /// <seealso cref="SerializableObject" />
    [Serializable, XmlRoot(ElementName = XmlRootElementName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class Message : SerializableObject, IMessage
    {
        /// <summary> 默认的消息内容根元素名称。 </summary>
        public const string XmlRootElementName = "messageContent";

        /// <summary> 用于初始化一个 <see cref="Message" /> 类型的对象实例。 </summary>
        public Message()
        {
        }
    }

    /// <summary> 提供了带有数据的 DEP 消息相关的方法。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
    /// <seealso cref="IMessage{TData}" />
    /// <seealso cref="Message" />
    [Serializable, XmlRoot(ElementName = XmlRootElementName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class Message<TData> : Message, IMessage<TData>
    {
        /// <summary> <see cref="MessageData" /> 属性序列化名称。 </summary>
        public const string MessageDataSerializePropertyName = "messageData";

        /// <summary> 用于初始化一个 <see cref="Message{TData}" /> 类型的对象实例。 </summary>
        public Message() : base()
        {
        }

        /// <summary> 用于初始化一个 <see cref="Message{TData}" /> 类型的对象实例。 </summary>
        /// <param name="messageData"> <typeparamref name="TData" /> 类型的消息数据。 </param>
        public Message(TData messageData) : this()
        {
            MessageData = messageData;
        }

        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TData" /> 类型的对象实例或值，用于表示消息数据。 </value>
        [JsonProperty(MessageDataSerializePropertyName), XmlElement(ElementName = MessageDataSerializePropertyName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
        public virtual TData MessageData { get; set; }
    }
}