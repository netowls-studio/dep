/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 9:45:30
 * Code:               ReferenceTypeMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了包含了引用类型数据消息相关的方法。 </summary>
    /// <seealso cref="Message{TData}" />
    [Serializable, XmlRoot(ElementName = XmlRootElementName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class ReferenceTypeMessage<T> : Message<T>
        where T : class, new()
    {
        /// <summary> 用于初始化一个 <see cref="ReferenceTypeMessage{T}" /> 类型的对象实例。 </summary>
        public ReferenceTypeMessage()
        {
        }

        /// <summary> 用于初始化一个 <see cref="ReferenceTypeMessage{T}" /> 类型的对象实例。 </summary>
        /// <param name="messageData"> <typeparamref name="T" /> 类型的对象实例。 </param>
        public ReferenceTypeMessage(T messageData) : base(messageData)
        {
        }

        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的对象实例，用于表示消息数据。 </value>
        [JsonProperty(MessageDataSerializePropertyName), XmlElement(ElementName = MessageDataSerializePropertyName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
        public override T MessageData { get => base.MessageData; set => base.MessageData = value; }
    }
}