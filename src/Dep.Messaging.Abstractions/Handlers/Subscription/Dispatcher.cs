/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 13:20:09
 * Code:               Dispatcher.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.Handlers.Annotations;
using NetowlsStudio.Dep.Runtime.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.Handlers.Subscription
{
    /// <summary> 提供了调配订阅消息相关的基本方法。 </summary>
    /// <seealso cref="IDispatcher" />
    public abstract class Dispatcher : IDispatcher
    {
        /// <summary> 用于初始化一个 <see cref="Dispatcher" /> 类型的对象实例。 </summary>
        /// <param name="logWriter"> 记录运行时日志的方法。 </param>
        protected Dispatcher(ILogWriter logWriter)
        {
            LogWriter = logWriter;
            Processors = new ProcessorCollection();
            AlreadyIndexed = false;
            Dictionary = new Dictionary<string, IEnumerable<IProcessor>>();
        }

        /// <summary> 用于初始化一个 <see cref="Dispatcher" /> 类型的对象实例。 </summary>
        /// <param name="logWriter"> 记录运行时日志的方法。 </param>
        /// <param name="processors"> 实现了 <see cref="IProcessor" /> 类型接口的对象实例集合。 </param>
        protected Dispatcher(ILogWriter logWriter, IEnumerable<IProcessor> processors) : this(logWriter)
        {
            Processors.AddRange(processors);
        }

        /// <summary> 记录运行时日志的程序。 </summary>
        /// <value> 获取 <see cref="ILogWriter" /> 类型的对象实例，用于表示记录运行时日志的程序。 </value>
        /// <seealso cref="ILogWriter" />
        public virtual ILogWriter LogWriter { get; }

        /// <summary> 消息处理程序集合。 </summary>
        /// <value> 获取 <see cref="ProcessorCollection" /> 类型的对象实例，用于表示消息处理程序集合。 </value>
        /// <seealso cref="ProcessorCollection" />
        public virtual ProcessorCollection Processors { get; }

        /// <summary> 是否已经建立了索引。 </summary>
        /// <value> 设置或获取一个值，用于表示是否已经建立了索引。 </value>
        protected virtual bool AlreadyIndexed { get; set; }

        /// <summary> 订阅消息处理程序字典。 </summary>
        /// <value> 获取 <see cref="IDictionary{TKey, TValue}" /> 类型的对象实例，用于表示订阅消息处理程序字典。 </value>
        /// <seealso cref="IDictionary{TKey, TValue}" />
        /// <seealso cref="IProcessor" />
        protected IDictionary<string, IEnumerable<IProcessor>> Dictionary { get; }

        /// <summary> 分发消息给指定的消息处理程序。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        /// <exception cref="TypeLoadException"> </exception>
        public virtual void Dispatch(IMessage message)
        {
            BuildIndex();
            if (!(message is null))
            {
                var groupId = message?.Header.GroupId;
                if (!string.IsNullOrWhiteSpace(groupId))
                {
                    ForeachProcess(message, groupId);
                }
            }
        }

        /// <summary> (异步的方法) 分发消息给指定的消息处理程序。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <returns> <see cref="Task" /> 类型的对象实例。 </returns>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task" />
        public virtual async Task DispatchAsync(IMessage message)
        {
            try
            {
                BuildIndex();
                if (!(message is null))
                {
                    var groupId = message?.Header.GroupId;
                    if (!string.IsNullOrWhiteSpace(groupId))
                    {
                        await ForeachProcessAsync(message, groupId);
                    }
                }
            }
            catch (TypeLoadException error)
            {
                LogWriter.WriteException(GetType(), "尝试重建订阅消息处理程序索引时", error);
            }
        }

        /// <summary> 处理完成后执行的动作。 </summary>
        /// <param name="currentProcessor"> 实现了 <see cref="IProcessor" /> 类型接口的对象实例。 </param>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="error"> 消息处理过程中可能引发的异常。 </param>
        /// <seealso cref="IProcessor" />
        /// <seealso cref="IMessage" />
        protected virtual void AfterProcess(IProcessor currentProcessor, IMessage message, Exception error = null)
        {
            if (error is null)
                LogWriter.WriteInformation(GetType(), $"{currentProcessor.GetType().FullName} 完成了消息处理");
            else
                LogWriter.WriteException(GetType(), $"{currentProcessor.GetType().FullName} 处理消息", error);
        }

        /// <summary> 建立索引。 </summary>
        /// <exception cref="TypeLoadException"> </exception>
        protected virtual void BuildIndex()
        {
            if (!AlreadyIndexed)
            {
                LogWriter.WriteWarning(GetType(), "尝试重建订阅消息处理器索引");
                foreach (var processor in Processors)
                {
                    var attrs = Attribute.GetCustomAttributes(processor.GetType(), typeof(SubscribeGroupIdAttribute), true);
                    if (!(attrs is null))
                    {
                        foreach (var attr in attrs)
                        {
                            var subscribeGpIdAttr = attr as SubscribeGroupIdAttribute;
                            if (subscribeGpIdAttr.Enabled)
                            {
                                if (!Dictionary.ContainsKey(subscribeGpIdAttr.GroupId))
                                    Dictionary[subscribeGpIdAttr.GroupId] = new List<IProcessor>();
                                if (!Dictionary[subscribeGpIdAttr.GroupId].Any(item => item.GetType().FullName == processor.GetType().FullName))
                                    (Dictionary[subscribeGpIdAttr.GroupId] as List<IProcessor>).Add(processor);
                            }
                        }
                    }
                }
                LogWriter.WriteWarning(GetType(), "订阅消息处理器索引已经重建完成");
                AlreadyIndexed = true;
            }
        }

        /// <summary> 循环处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="groupId"> 消息分组标识。 </param>
        /// <seealso cref="IMessage" />
        protected virtual void ForeachProcess(IMessage message, string groupId)
        {
            foreach (var item in Dictionary[groupId])
            {
                try
                {
                    LogWriter.WriteInformation(GetType(), $"尝试将消息交由 {item.GetType().FullName} 处理");
                    Process(message, item);
                    AfterProcess(item, message);
                }
                catch (Exception error)
                {
                    AfterProcess(item, message, error);
                }
            }
        }

        /// <summary> (异步的方法) 循环处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="groupId"> 消息分组标识。 </param>
        /// <remarks> <see cref="Task" /> 类型的对象实例。 </remarks>
        /// <seealso cref="IMessage" />
        /// <seealso cref="Task" />
        protected virtual async Task ForeachProcessAsync(IMessage message, string groupId)
        {
            foreach (var item in Dictionary[groupId])
            {
                try
                {
                    LogWriter.WriteInformation(GetType(), $"尝试将消息交由 {item.GetType().FullName} 处理");
                    Exception error = await ProcessAsync(message, item);
                    AfterProcess(item, message, error);
                }
                catch (Exception error)
                {
                    AfterProcess(item, message, error);
                }
            }
        }

        /// <summary> 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="processor"> 实现了 <see cref="IProcessor" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IMessage" />
        /// <seealso cref="IProcessor" />
        protected void Process(IMessage message, IProcessor processor) => processor.Process(message);

        /// <summary> (异步的方法) 处理消息。 </summary>
        /// <param name="message"> 实现了 <see cref="IMessage" /> 类型接口的对象实例。 </param>
        /// <param name="processor"> 实现了 <see cref="IProcessor" /> 类型接口的对象实例。 </param>
        /// <remarks><see cref="Task{TResult}"/> 类型的对象实例。</remarks>
        /// <seealso cref="IMessage" />
        /// <seealso cref="IProcessor" />
        protected async Task<Exception> ProcessAsync(IMessage message, IProcessor processor) => await processor.ProcessAsync(message);
    }
}
