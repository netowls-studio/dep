/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:34:25
 * Code:               Header.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了消息头信息相关的基本方法。 </summary>
    /// <seealso cref="IHeader" />
    /// <seealso cref="SerializableObject" />
    [Serializable]
    public abstract class Header : SerializableObject, IHeader
    {
        /// <summary> 用于初始化一个 <see cref="Header" /> 类型的对象实例。 </summary>
        protected Header()
        {
        }

        /// <summary> 用于初始化一个 <see cref="Header" /> 类型的对象实例。 </summary>
        /// <param name="groupId"> 消息分组标识。 </param>
        protected Header(string groupId) : this(groupId, MessageType.Default)
        {
        }

        /// <summary> 用于初始化一个 <see cref="Header" /> 类型的对象实例。 </summary>
        /// <param name="groupId"> 消息分组标识。 </param>
        /// <param name="messageType"> 消息类型。 </param>
        protected Header(string groupId, MessageType messageType) : this(groupId, messageType, DateTime.Now)
        {
        }

        /// <summary> 用于初始化一个 <see cref="Header" /> 类型的对象实例。 </summary>
        /// <param name="groupId"> 消息分组标识。 </param>
        /// <param name="messageType"> 消息类型。 </param>
        /// <param name="publishTime"> 消息发布时间。 </param>
        protected Header(string groupId, MessageType messageType, DateTime publishTime)
        {
            GroupId = groupId;
            MessageType = messageType == MessageType.Default ? MessageType.Distribution : MessageType;
            PublishTime = publishTime;
        }

        /// <summary> 消息分组标识。 </summary>
        /// <value> 设置或获取一个字符串，用于表示消息分组标识。 </value>
        [JsonProperty("group-id")]
        public string GroupId { get; set; }

        /// <summary> 消息类型。 </summary>
        /// <value> 设置或获取一个 <see cref="T:NetowlsStudio.Dep.Messaging.MessageType" /> 类型的值，用于表示消息类型。 </value>
        /// <seealso cref="T:NetowlsStudio.Dep.Messaging.MessageType" />
        [JsonProperty("message-type"), JsonConverter(typeof(StringEnumConverter))]
        public MessageType MessageType { get; set; }

        /// <summary> 消息类型。 </summary>
        /// <value> 获取一个值，用于表示消息类型。 </value>
        /// <seealso cref="T:NetowlsStudio.Dep.Messaging.MessageType" />
        [JsonProperty("message-typeid")]
        public int MessageTypeId => (int)MessageType;

        /// <summary> 消息发布时间。 </summary>
        /// <value> 设置或获取一个 <see cref="DateTime" /> 类型的值，用于表示消息发布时间。 </value>
        [JsonProperty("publish-time")]
        public DateTime PublishTime { get; set; }
    }
}