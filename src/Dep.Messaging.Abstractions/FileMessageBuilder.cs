/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 10:44:26
 * Code:               FileMessageBuilder.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Messaging.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary>
    /// 提供了构建文件型消息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="StreamingMessageBuilder" />
    /// <seealso cref="FileMessage" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class FileMessageBuilder : StreamingMessageBuilder
    {
        private readonly FileInfo m_file;

        /// <summary> 用于初始化一个 <see cref="FileMessageBuilder" /> 类型的对象实例。 </summary>
        /// <param name="file"> 文件信息。 </param>
        /// <seealso cref="FileInfo" />
        public FileMessageBuilder(FileInfo file) : base(new FileStreamSplitter(file))
        {
        }

        /// <summary> 用于初始化一个 <see cref="FileMessageBuilder" /> 类型的对象实例。 </summary>
        /// <param name="file"> 文件信息。 </param>
        /// <param name="handler"> 获取文件流的方法。 </param>
        /// <seealso cref="FileInfo" />
        /// <seealso cref="FileStream" />
        /// <seealso cref="Func{T, TResult}" />
        public FileMessageBuilder(FileInfo file, Func<FileInfo, FileStream> handler) : base(new FileStreamSplitter(file, handler))
        {
            m_file = file;
        }

        /// <summary> 构建 IO 流消息集合。 </summary>
        /// <returns> <see cref="StreamingMessage" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="IStreamSplitter" />
        /// <seealso cref="StreamingMessage" />
        /// <seealso cref="FileMessage" />
        public override IEnumerable<StreamingMessage> Build() => Splitter.Split()
                                                                         .Select(item => new FileMessage() { MessageData = item as FileStreamSummary })
                                                                         .ToArray();
    }
}