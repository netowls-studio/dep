/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 11:33:13
 * Code:               Processor.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging;
using System;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers.Subscription
{
    /// <summary> 提供了处理订阅消息相关的基本方法。 </summary>
    /// <seealso cref="IProcessor" />
    public abstract class Processor : IProcessor
    {
        /// <summary> 用于初始化一个 <see cref="Processor" /> 类型的对象实例。 </summary>
        /// <param name="logWriter"> 记录运行时日志的方法。 </param>
        /// <seealso cref="ILogWriter" />
        protected Processor(ILogWriter logWriter)
        {
            LogWriter = logWriter;
        }

        /// <summary> 记录运行时日志的方法。 </summary>
        /// <value> 获取 <see cref="ILogWriter" /> 类型的对象实例，用于表示记录运行时日志的方法。 </value>
        /// <seealso cref="ILogWriter" />
        public virtual ILogWriter LogWriter { get; }

        /// <summary> 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        public virtual void Process(IMessage message)
        {
            try
            {
                BeginProcess(message);
                InternalProcess(message);
                AfterProcess(message);
            }
            catch (Exception error)
            {
                AfterProcess(message, error);
                throw;
            }
        }

        /// <summary> (异步的方法) 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了可能的异常信息。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task{TResult}" />
        public virtual async Task<Exception> ProcessAsync(IMessage message)
        {
            return await Task.Run(() =>
            {
                try
                {
                    Process(message);
                    return null;
                }
                catch (Exception error)
                {
                    return error;
                }
            });
        }

        /// <summary> 消息处理后的动作。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="error"> 消息处理过程中，引发的未处理异常。 </param>
        protected virtual void AfterProcess(IMessage message, Exception error = null)
        {
            if (error is null)
                LogWriter.WriteInformation(GetType(), "消息处理完成。");
            else
                LogWriter.WriteException(GetType(),
                                         $"消息处理失败。处理过程中引发了一个 {error.GetType().FullName} 类型的异常：{error.Message}",
                                         error);
        }

        /// <summary> 消息处理之前的动作。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        protected virtual void BeginProcess(IMessage message) => LogWriter.WriteInformation(GetType(), "尝试处理消息。");

        /// <summary> 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        protected abstract void InternalProcess(IMessage message);
    }
}