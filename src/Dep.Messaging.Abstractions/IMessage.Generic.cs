/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 11:00:08
 * Code:               IMessage.Generic.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息信息的接口。 </summary>
    /// <typeparam name="TBody"> 消息体类型。 </typeparam>
    /// <seealso cref="IMessage" />
    public interface IMessage<TBody> : IMessage
    {
        /// <summary> 消息体数据。 </summary>
        /// <value> 设置或获取 <typeparamref name="TBody" /> 类型的对象实例或值，用于表示消息体数据。 </value>
        new TBody Body { get; set; }
    }
}