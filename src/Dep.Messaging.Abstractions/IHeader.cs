/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:29:32
 * Code:               IHeader.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;
using System;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息头摘要信息的接口。 </summary>
    /// <seealso cref="ISerializableObject" />
    public interface IHeader : ISerializableObject
    {
        /// <summary> 消息分组标识。 </summary>
        /// <value> 设置或获取一个字符串，用于表示消息分组标识。 </value>
        string GroupId { get; set; }

        /// <summary> 消息类型。 </summary>
        /// <value> 设置或获取一个 <see cref="MessageType" /> 类型的值，用于表示消息类型。 </value>
        /// <seealso cref="MessageType" />
        MessageType MessageType { get; set; }

        /// <summary> 消息类型。 </summary>
        /// <value> 获取一个值，用于表示消息类型。 </value>
        /// <seealso cref="MessageType" />
        int MessageTypeId { get; }

        /// <summary> 消息发布时间。 </summary>
        /// <value> 设置或获取一个 <see cref="DateTime" /> 类型的值，用于表示消息发布时间。 </value>
        DateTime PublishTime { get; set; }
    }
}