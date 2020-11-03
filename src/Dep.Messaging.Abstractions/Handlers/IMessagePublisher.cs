/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 10:47:53
 * Code:               IMessagePublisher.cs
 * ********************************************************************************************
 */

using System;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers
{
    /// <summary> 定义了发布消息的接口。 </summary>
    public interface IMessagePublisher
    {
        /// <summary> 发布消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        void Publish(IMessage message);

        /// <summary> (异步的方法) 发布消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了可能的异常信息。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task{TResult}" />
        Task<Exception> PublishAsync(IMessage message);
    }
}