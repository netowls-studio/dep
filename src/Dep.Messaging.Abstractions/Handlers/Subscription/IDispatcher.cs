﻿/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 12:53:06
 * Code:               IDispatcher.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers.Subscription
{
    /// <summary> 定义了调配订阅消息的接口。 </summary>
    public interface IDispatcher
    {
        /// <summary> 记录运行时日志的程序。 </summary>
        /// <value> 获取 <see cref="ILogWriter" /> 类型的对象实例，用于表示记录运行时日志的程序。 </value>
        /// <seealso cref="ILogWriter" />
        ILogWriter LogWriter { get; }

        /// <summary> 消息处理程序集合。 </summary>
        /// <value> 获取 <see cref="ProcessorCollection" /> 类型的对象实例，用于表示消息处理程序集合。 </value>
        /// <seealso cref="ProcessorCollection" />
        ProcessorCollection Processors { get; }

        /// <summary> 分发消息给指定的消息处理程序。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        void Dispatch(IMessage message);

        /// <summary> (异步的方法) 分发消息给指定的消息处理程序。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task" />
        Task DispatchAsync(IMessage message);
    }
}