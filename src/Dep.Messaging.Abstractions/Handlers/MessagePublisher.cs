/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 10:52:21
 * Code:               MessagePublisher.cs
 * ********************************************************************************************
 */

using System;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers
{
    /// <summary> 提供了发布消息相关的基本方法。 </summary>
    /// <seealso cref="IMessagePublisher" />
    public abstract class MessagePublisher : IMessagePublisher
    {
        /// <summary> 用于初始化一个 <see cref="MessagePublisher" /> 类型的对象实例。 </summary>
        protected MessagePublisher()
        {
        }

        /// <summary> 发布消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        public abstract void Publish(IMessage message);

        /// <summary> (异步的方法) 发布消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了可能的异常信息。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task{TResult}" />
        public virtual async Task<Exception> PublishAsync(IMessage message)
        {
            return await Task.Run(() =>
            {
                try
                {
                    Publish(message);
                    return null;
                }
                catch (Exception error)
                {
                    return error;
                }
            });
        }
    }
}