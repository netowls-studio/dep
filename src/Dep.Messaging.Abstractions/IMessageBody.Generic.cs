/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/2 10:19:48
 * Code:               IMessageBody.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了消息内容的接口。 </summary>
    /// <typeparam name="TContent"> 消息内容接口。 </typeparam>
    /// <seealso cref="IMessageBody" />
    public interface IMessageBody<TContent> : IMessageBody
    {
        /// <summary> 消息内容。 </summary>
        /// <value> 设置或获取 <typeparamref name="TContent" /> 类型的对象实例或值，用于表示消息内容。 </value>
        new TContent Content { get; set; }
    }
}