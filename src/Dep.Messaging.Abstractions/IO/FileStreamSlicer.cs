/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 11:55:00
 * Code:               FileStreamSlicer.cs
 * ********************************************************************************************
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary>
    /// 提供了分割文件流数据相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="StreamSlicer" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class FileStreamSlicer : StreamSlicer
    {
        /// <summary> 用于初始化一个 <see cref="FileStreamSlicer" /> 类型的对象实例。 </summary>
        public FileStreamSlicer()
        {
        }

        /// <summary> 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <see cref="StreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="System.ArgumentNullException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="System.ObjectDisposedException"> </exception>
        public override IEnumerable<StreamFragmentInfo> Split(Stream stream) => InternalSplit(stream, null, null);

        /// <summary> 分割文件 <paramref name="file" />。 </summary>
        /// <param name="file">
        /// 需要分割的文件信息。
        /// <para> <see cref="FileInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="FileStreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="FileInfo" />
        /// <seealso cref="FileStreamFragmentInfo" />
        /// <exception cref="FileNotFoundException"> </exception>
        /// <exception cref="UnauthorizedAccessException"> </exception>
        /// <exception cref="DirectoryNotFoundException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ObjectDisposedException"> </exception>
        public IEnumerable<FileStreamFragmentInfo> Split(FileInfo file) => InternalSplit(file);

        /// <summary> (异步的方法) 分割文件 <paramref name="file" />。 </summary>
        /// <param name="file"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> 包含了 <see cref="FileStreamFragmentInfo" /> 类型的对象实例集合和异常信息的 <see cref="Tuple{T1, T2}" />。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="FileStreamFragmentInfo" />
        /// <seealso cref="FileInfo" />
        /// <exception cref="IOException"> </exception>
        public async Task<Tuple<IEnumerable<FileStreamFragmentInfo>, Exception>> SplitAsync(FileInfo file)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var fragments = Split(file);
                    return new Tuple<IEnumerable<FileStreamFragmentInfo>, Exception>(fragments, null);
                }
                catch (Exception error)
                {
                    return new Tuple<IEnumerable<FileStreamFragmentInfo>, Exception>(null, error);
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
        /// <seealso cref="FileStreamFragmentInfo" />
        protected override StreamFragmentInfo CreateFragment(int index, long totalLength, byte[] fragmentData, params object[] additions)
        {
            var fragment = new FileStreamFragmentInfo(index, totalLength, fragmentData);
            if (!(additions is null) && additions.Length >= 2)
            {
                fragment.FileName = (additions[0]?.ToString());
                fragment.Path = (additions[1]?.ToString());
            }
            return fragment;
        }

        /// <summary> 分割文件 <paramref name="file" />。 </summary>
        /// <param name="file">
        /// 需要分割的文件信息。
        /// <para> <see cref="FileInfo" /> 类型的对象实例。 </para>
        /// </param>
        /// <returns> <see cref="FileStreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="FileInfo" />
        /// <seealso cref="FileStreamFragmentInfo" />
        /// <exception cref="FileNotFoundException"> </exception>
        /// <exception cref="UnauthorizedAccessException"> </exception>
        /// <exception cref="DirectoryNotFoundException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ObjectDisposedException"> </exception>
        private IEnumerable<FileStreamFragmentInfo> InternalSplit(FileInfo file)
        {
            if (file is null)
                throw new ArgumentNullException(nameof(file), string.Format(DepException.MessageTemplate, "未提供文件信息"));
            if (!file.Exists)
                throw new FileNotFoundException(string.Format(DepException.MessageTemplate, $"文件 “{file.FullName}” 不存在"), file.FullName);
            using (var fileStream = file.OpenRead())
            {
                return InternalSplit(fileStream, file.Name, file.FullName);
            }
        }

        /// <summary> 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <param name="fileName"> 文件名称。 </param>
        /// <param name="path"> 文件路径。 </param>
        /// <returns> <see cref="StreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="System.ObjectDisposedException"> </exception>
        /// <exception cref="IOException"> </exception>
        private IEnumerable<FileStreamFragmentInfo> InternalSplit(Stream stream, string fileName, string path)
        {
            ThrowIfStreamIsNotSupport(stream);
            ThrowIfStreamCannotRead(stream);
            var fragments = new List<FileStreamFragmentInfo>();
            var buffer = new byte[BufferSize];
            var readSize = stream.Read(buffer, 0, BufferSize);
            while (readSize > 0)
            {
                using (var bufferStream = new MemoryStream(buffer, 0, readSize))
                {
                    fragments.Add(CreateFragment(fragments.Count + 1, stream.Length, bufferStream.ToArray(), fileName, path) as FileStreamFragmentInfo);
                }
                readSize = stream.Read(buffer, 0, BufferSize);
            }
            return fragments;
        }
    }
}