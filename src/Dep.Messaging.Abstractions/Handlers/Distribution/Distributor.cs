/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 10:52:21
 * Code:               Distributor.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging;
using System;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers.Distribution
{
    /// <summary> 提供了分发消息相关的基本方法。 </summary>
    /// <seealso cref="IDistributor" />
    public abstract class Distributor : IDistributor
    {
        /// <summary> 用于初始化一个 <see cref="Distributor" /> 类型的对象实例。 </summary>
        /// <param name="logWriter"> 实现了 <see cref="ILogWriter" /> 类型接口的对象实例。 </param>
        /// <seealso cref="ILogWriter" />
        protected Distributor(ILogWriter logWriter)
        {
            LogWriter = logWriter;
        }

        /// <summary> 记录运行时日志的方法。 </summary>
        /// <value> 获取 <see cref="ILogWriter" /> 类型的对象实例，用于表示记录运行时日志的方法。 </value>
        /// <seealso cref="ILogWriter" />
        public virtual ILogWriter LogWriter { get; }

        /// <summary> 分发消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        public virtual void Execute(IMessage message)
        {
            try
            {
                BeginPublish(message);
                InternalPublish(message);
                AfterPublish(message);
            }
            catch (Exception error)
            {
                AfterPublish(message, error);
                throw;
            }
        }

        /// <summary> (异步的方法) 分发消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了可能的异常信息。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task{TResult}" />
        public virtual async Task<Exception> ExecuteAsync(IMessage message)
        {
            return await Task.Run(() =>
            {
                try
                {
                    Execute(message);
                    return null;
                }
                catch (Exception error)
                {
                    return error;
                }
            });
        }

        /// <summary> 消息分发后的动作。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="error"> 消息分发时，引发的未处理异常。 </param>
        protected virtual void AfterPublish(IMessage message, Exception error = null)
        {
            if (error is null)
                LogWriter.WriteInformation(GetType(), "消息分发成功");
            else
                LogWriter.WriteException(GetType(), "尝试分发消息", error);
        }

        /// <summary> 消息分发之前的动作。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        protected virtual void BeginPublish(IMessage message) => LogWriter.WriteInformation(GetType(), "尝试分发消息。");

        /// <summary> 分发消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        /// <exception cref="Exception"> </exception>
        protected abstract void InternalPublish(IMessage message);
    }
}