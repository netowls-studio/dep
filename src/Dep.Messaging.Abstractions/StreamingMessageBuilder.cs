/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:20:48
 * Code:               StreamingMessageBuilder.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了构建 IO 流相关消息的方法。 </summary>
    /// <seealso cref="IStreamingMessageBuilder" />
    public class StreamingMessageBuilder : IStreamingMessageBuilder
    {
        private IStreamSplitter m_splitter;

        /// <summary> 用于初始化一个 <see cref="StreamingMessageBuilder" /> 类型的对象实例。 </summary>
        public StreamingMessageBuilder()
        {
        }

        /// <summary> 用于初始化一个 <see cref="StreamingMessageBuilder" /> 类型的对象实例。 </summary>
        /// <param name="splitter"> 实现了 <see cref="IStreamSplitter" /> 类型接口的对象实例。 </param>
        /// <seealso cref="IStreamSplitter" />
        public StreamingMessageBuilder(IStreamSplitter splitter)
        {
            m_splitter = splitter;
        }

        /// <summary> IO 分片程序。 </summary>
        /// <value> 获取实现了 <see cref="IStreamSplitter" /> 类型接口的对象实例，用于表示 IO 分片程序。 </value>
        /// <seealso cref="IStreamSplitter" />
        public virtual IStreamSplitter Splitter => m_splitter;

        /// <summary> 构建 IO 流消息集合。 </summary>
        /// <returns> <see cref="StreamingMessage" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IStreamSplitter" />
        /// <seealso cref="StreamingMessage" />
        public virtual IEnumerable<StreamingMessage> Build() => Splitter.Split()
                                                                        .Select(item => new StreamingMessage() { MessageData = item })
                                                                        .ToArray();

        /// <summary> (异步的方法) 构建 IO 流消息集合。 </summary>
        /// <returns> 包含了 <see cref="StreamingMessage" /> 类型的对象实例集合和异常信息的元祖。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IStreamSplitter" />
        /// <seealso cref="Task{TResult}" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="StreamingMessage" />
        public async Task<Tuple<IEnumerable<StreamingMessage>, Exception>> BuildAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    var messages = Build();
                    return new Tuple<IEnumerable<StreamingMessage>, Exception>(messages, null);
                }
                catch (Exception error)
                {
                    return new Tuple<IEnumerable<StreamingMessage>, Exception>(null, error);
                }
            });
        }

        /// <summary> 设置 IO 流分片程序。 </summary>
        /// <param name="splitter"> 实现了 <see cref="IStreamSplitter" /> 类型接口的对象实例。 </param>
        /// <returns> 实现了 <see cref="IStreamingMessageBuilder" /> 类型接口的对象实例。 </returns>
        /// <seealso cref="IStreamingMessageBuilder" />
        /// <seealso cref="IStreamSplitter" />
        public virtual IStreamingMessageBuilder WithSplitter(IStreamSplitter splitter)
        {
            m_splitter = splitter;
            return this;
        }
    }
}