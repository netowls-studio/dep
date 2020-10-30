/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:08:10
 * Code:               IStreamingMessageBuilder.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.IO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 定义了构建 IO 流相关消息的接口。 </summary>
    public interface IStreamingMessageBuilder
    {
        /// <summary> 构建 IO 流消息集合。 </summary>
        /// <param name="splitter"> 实现了 <see cref="IStreamSplitter" /> 类型接口的对象实例。 </param>
        /// <returns> <see cref="StreamingMessage" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IStreamSplitter" />
        /// <seealso cref="StreamingMessage" />
        IEnumerable<StreamingMessage> Build(IStreamSplitter splitter);

        /// <summary> (异步的方法) 构建 IO 流消息集合。 </summary>
        /// <param name="splitter"> 实现了 <see cref="IStreamSplitter" /> 类型接口的对象实例。 </param>
        /// <returns> 包含了 <see cref="StreamingMessage" /> 类型的对象实例集合和异常信息的元祖。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IStreamSplitter" />
        /// <seealso cref="Task{TResult}" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="StreamingMessage" />
        Task<Tuple<IEnumerable<StreamingMessage>, Exception>> BuildAsync(IStreamSplitter splitter);
    }
}