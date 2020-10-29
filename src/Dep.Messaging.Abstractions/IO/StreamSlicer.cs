/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 11:02:44
 * Code:               StreamSlicer.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了分割流相关的方法。 </summary>
    /// <seealso cref="IStreamSlicer" />
    [InjectionName(nameof(StreamSlicer))]
    public class StreamSlicer : IStreamSlicer
    {
        /// <summary> 每个分片的大小：2048 字节。 </summary>
        public const int BufferSize = 0x800;

        /// <summary> 用于初始化一个 <see cref="StreamSlicer" /> 类型的对象实例。 </summary>
        public StreamSlicer()
        {
        }

        /// <summary> 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <see cref="StreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="ArgumentNullException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ObjectDisposedException"> </exception>
        public virtual IEnumerable<StreamFragmentInfo> Split(Stream stream) => InternalSplit(stream);

        /// <summary> (异步的方法) 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> 包含了 <see cref="StreamFragmentInfo" /> 类型的对象实例集合和异常信息的 <see cref="Tuple{T1, T2}" />。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="IOException"> </exception>
        public async Task<Tuple<IEnumerable<StreamFragmentInfo>, Exception>> SplitAsync(Stream stream)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var fragments = Split(stream);
                    return new Tuple<IEnumerable<StreamFragmentInfo>, Exception>(fragments, null);
                }
                catch (Exception error)
                {
                    return new Tuple<IEnumerable<StreamFragmentInfo>, Exception>(null, error);
                }
            });
        }

        /// <summary> 创建一个分片信息。 </summary>
        /// <param name="index"> 分片索引数字。 </param>
        /// <param name="totalLength"> 流总长度。 </param>
        /// <param name="fragmentData"> 分片数据。 </param>
        /// <param name="additions"> 附加参数。 </param>
        /// <returns> 派生自 <see cref="StreamFragmentInfo" /> 类型的对象实例。 </returns>
        /// <seealso cref="StreamFragmentInfo" />
        protected virtual StreamFragmentInfo CreateFragment(int index,
                                                            long totalLength,
                                                            byte[] fragmentData,
                                                            params object[] additions)
        {
            return new StreamFragmentInfo(index, totalLength, fragmentData);
        }

        /// <summary> 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <see cref="StreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="ObjectDisposedException"> </exception>
        /// <exception cref="IOException"> </exception>
        protected virtual IEnumerable<StreamFragmentInfo> InternalSplit(Stream stream)
        {
            ThrowIfStreamIsNotSupport(stream);
            ThrowIfStreamCannotRead(stream);
            var fragments = new List<StreamFragmentInfo>();
            var buffer = new byte[BufferSize];
            var readSize = stream.Read(buffer, 0, BufferSize);
            while (readSize > 0)
            {
                using (var bufferStream = new MemoryStream(buffer, 0, readSize))
                {
                    fragments.Add(CreateFragment(fragments.Count + 1, stream.Length, bufferStream.ToArray()));
                }
                readSize = stream.Read(buffer, 0, BufferSize);
            }
            return fragments;
        }

        /// <summary> 用于校验流 <paramref name="stream" /> 是否可读。如果不可读，则抛出 <see cref="IOException" /> 类型的异常。 </summary>
        /// <param name="stream">
        /// 需要校验的流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Stream" />
        /// <exception cref="IOException"> </exception>
        protected void ThrowIfStreamCannotRead(Stream stream)
        {
            if (!stream.CanRead)
                throw new IOException(string.Format(DepException.MessageTemplate, $"IO 流 @{nameof(stream)} 不可读"));
        }

        /// <summary> 用于校验流 <paramref name="stream" /> 是否等于 <c> null </c>。如果等于 <c> null </c>，则抛出 <see cref="ArgumentNullException" /> 类型的异常。 </summary>
        /// <param name="stream">
        /// 需要校验的流。
        /// <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
        /// </param>
        /// <seealso cref="Stream" />
        protected void ThrowIfStreamIsNotSupport(Stream stream)
        {
            if (stream is null)
                throw new ArgumentNullException(nameof(stream), string.Format(DepException.MessageTemplate, $"无效的 IO 流 @{nameof(stream)}"));
        }
    }
}