/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 14:21:22
 * Code:               IMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息信息的接口。 </summary>
    /// <typeparam name="TData"> 消息数据类型。 </typeparam>
    /// <seealso cref="ISerializableObject" />
    public interface IMessage<TData> : ISerializableObject
    {
        /// <summary> 消息数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TData" /> 类型的对象实例或值，用于表示消息数据。 </value>
        TData MessageData { get; set; }
    }
}