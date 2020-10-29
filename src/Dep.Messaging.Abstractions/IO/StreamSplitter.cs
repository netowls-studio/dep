/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 13:53:54
 * Code:               StreamSplitter.cs
 * ********************************************************************************************
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了拆分 IO 流相关的方法。 </summary>
    /// <seealso cref="IStreamSplitter" />
    public class StreamSplitter : IStreamSplitter
    {
        /// <summary> 默认的包大小。 </summary>
        public const int DefaultPackageSize = 0x800;

        /// <summary> 用于初始化一个 <see cref="StreamSplitter" /> 类型的对象实例。 </summary>
        /// <param name="stream"> 需要拆分的 IO 流。 </param>
        public StreamSplitter(Stream stream)
        {
            TargetStream = stream;
        }

        /// <summary> 需要拆分的 IO 流。 </summary>
        /// <value> 获取 <see cref="Stream" /> 类型的对象实例，用于表示需要拆分的 IO 流。 </value>
        /// <seealso cref="Stream" />
        protected Stream TargetStream { get; }

        /// <summary> 对指定的流进行拆包。 </summary>
        /// <returns> <see cref="StreamSummary" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamSummary" />
        public virtual IEnumerable<StreamSummary> Split() => InternalSplit();

        /// <summary> 创建包唯一标识。 </summary>
        /// <param name="totalData"> 流数据。 </param>
        /// <returns> 唯一标识。 </returns>
        /// <exception cref="ObjectDisposedException"> </exception>
        protected virtual string CreatePackageUniqueId(byte[] totalData) => BitConverter.ToString(SHA1.Create().ComputeHash(totalData)).Replace("-", string.Empty);

        /// <summary> 创建包描述信息。 </summary>
        /// <param name="uniqueId"> 包唯一标识。 </param>
        /// <param name="packageData"> 每个包的数据。 </param>
        /// <param name="totalLength"> 流的总长度。 </param>
        /// <param name="packagesNum"> 分包个数。 </param>
        /// <param name="packageIdx"> 包索引数字。 </param>
        /// <returns> <see cref="StreamSummary" /> 类型的对象实例。 </returns>
        /// <seealso cref="StreamSummary" />
        protected virtual StreamSummary CreateSummary(string uniqueId,
                                                      byte[] packageData,
                                                      long totalLength = 1,
                                                      int packagesNum = 0,
                                                      int packageIdx = 0)
        {
            return new StreamSummary()
            {
                IsSplitted = packagesNum > 0,
                Length = totalLength,
                PackageId = uniqueId,
                PackagesNumber = packagesNum,
                Package = new StreamPackage(packageIdx, packageData)
            };
        }

        /// <summary> 对指定的流进行拆包。 </summary>
        /// <returns> <see cref="StreamSummary" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamSummary" />
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ObjectDisposedException"> </exception>
        /// <exception cref="RankException"> </exception>
        /// <exception cref="ArrayTypeMismatchException"> </exception>
        /// <exception cref="InvalidCastException"> </exception>
        protected virtual IEnumerable<StreamSummary> InternalSplit()
        {
            var splitResult = StartSplit();
            var uniqueId = $"DEP-{DateTime.Now.Ticks}-{Guid.NewGuid().ToString().Replace("-", string.Empty)}-{CreatePackageUniqueId(splitResult.Item1)}".ToUpper();
            var packages = new List<StreamSummary>();
            var idx = 0;
            foreach (var item in splitResult.Item2)
            {
                packages.Add(CreateSummary(uniqueId, item, splitResult.Item1.LongLength, splitResult.Item2.Count(), idx));
                idx++;
            }
            return packages;
        }

        /// <summary> 开始拆分。 </summary>
        /// <returns> 包含了所有字节数据、和分包数据的元祖。 </returns>
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="IEnumerable{T}" />
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ObjectDisposedException"> </exception>
        /// <exception cref="RankException"> </exception>
        /// <exception cref="ArrayTypeMismatchException"> </exception>
        /// <exception cref="InvalidCastException"> </exception>
        private Tuple<byte[], IEnumerable<byte[]>> StartSplit()
        {
            var packagesData = new List<byte[]>();
            byte[] buffer = new byte[DefaultPackageSize];
            var readSize = TargetStream.Read(buffer, 0, DefaultPackageSize);
            using (var totalBuffer = new MemoryStream())
            {
                while (readSize > 0)
                {
                    var packageBuffer = new byte[readSize];
                    Array.Copy(buffer, 0, packageBuffer, 0, readSize);
                    totalBuffer.Write(buffer, 0, readSize);
                    packagesData.Add(packageBuffer);
                    readSize = TargetStream.Read(buffer, 0, DefaultPackageSize);
                }
                return new Tuple<byte[], IEnumerable<byte[]>>(totalBuffer.ToArray(), packagesData);
            }
        }
    }
}