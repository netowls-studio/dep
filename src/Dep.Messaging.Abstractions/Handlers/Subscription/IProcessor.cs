/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 11:24:19
 * Code:               IProcessor.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging;
using System;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers.Subscription
{
    /// <summary> 定义了处理订阅消息的接口。 </summary>
    public interface IProcessor
    {
        /// <summary> 记录运行时日志的方法。 </summary>
        /// <value> 获取 <see cref="ILogWriter" /> 类型的对象实例，用于表示记录运行时日志的方法。 </value>
        /// <seealso cref="ILogWriter" />
        ILogWriter LogWriter { get; }

        /// <summary> 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        void Process(IMessage message);

        /// <summary> (异步的方法) 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了可能的异常信息。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task{TResult}" />
        Task<Exception> ProcessAsync(IMessage message);
    }
}