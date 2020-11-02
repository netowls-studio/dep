/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:56:40
 * Code:               IMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息信息的接口。 </summary>
    /// <seealso cref="ISerializableObject" />
    public interface IMessage : ISerializableObject
    {
        /// <summary> 消息体信息。 </summary>
        /// <value> 设置或获取 <see cref="object" /> 类型的对象实例，用于表示消息体信息。 </value>
        object Body { get; set; }

        /// <summary> 消息头摘要信息。 </summary>
        /// <value> 设置或获取 <see cref="IHeader" /> 类型的对象实例，用于表示消息头摘要信息。 </value>
        /// <seealso cref="IHeader" />
        IHeader Header { get; set; }
    }
}