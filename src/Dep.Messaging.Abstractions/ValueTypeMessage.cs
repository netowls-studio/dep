/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 9:37:39
 * Code:               ValueTypeMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了包含了值类型数据的消息相关的方法。 </summary>
    /// <typeparam name="T"> 值类型。 </typeparam>
    /// <seealso cref="Message{TData}" />
    [Serializable, XmlRoot(ElementName = XmlRootElementName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class ValueTypeMessage<T> : Message<T>
        where T : struct
    {
        /// <summary> 用于初始化一个 <see cref="ValueTypeMessage{T}" /> 类型的对象实例。 </summary>
        public ValueTypeMessage()
        {
        }

        /// <summary> 用于初始化一个 <see cref="ValueTypeMessage{T}" /> 类型的对象实例。 </summary>
        /// <param name="valueTypeData"> 值类型的消息数据。 </param>
        public ValueTypeMessage(T valueTypeData) : base(valueTypeData)
        {
        }

        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="T" /> 类型的值，用于表示消息数据。 </value>
        [XmlAttribute(AttributeName = MessageDataSerializePropertyName, Namespace = XmlSerializerNamespaceDefaults.Uri), JsonProperty(MessageDataSerializePropertyName)]
        public override T MessageData { get => base.MessageData; set => base.MessageData = value; }
    }
}