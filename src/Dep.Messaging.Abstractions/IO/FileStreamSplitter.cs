/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/30 11:07:43
 * Code:               FileStreamSplitter.cs
 * ********************************************************************************************
 */

using System.IO;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary>
    /// 提供了拆分文件流相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="FileStreamSplitter" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class FileStreamSplitter : StreamSplitter
    {
        private readonly FileInfo m_file;

        /// <summary> 用于初始化一个 <see cref="FileStreamSplitter" /> 类型的对象实例。 </summary>
        /// <param name="stream"> <see cref="FileStream" /> 类型的对象实例。 </param>
        public FileStreamSplitter(FileStream stream) : base(stream)
        {
        }

        /// <summary> 创建包描述信息。 </summary>
        /// <param name="uniqueId"> 包唯一标识。 </param>
        /// <param name="packageData"> 每个包的数据。 </param>
        /// <param name="totalLength"> 流的总长度。 </param>
        /// <param name="packagesNum"> 分包个数。 </param>
        /// <param name="packageIdx"> 包索引数字。 </param>
        /// <returns> <see cref="StreamSummary" /> 类型的对象实例。 </returns>
        /// <seealso cref="StreamSummary" />
        protected override StreamSummary CreateSummary(string uniqueId,
                                                       byte[] packageData,
                                                       long totalLength = 1,
                                                       int packagesNum = 0,
                                                       int packageIdx = 0)
        {
            return CreateFileSummary(uniqueId,
                                            packageData,
                                            totalLength,
                                            packagesNum,
                                            packageIdx);
        }

        /// <summary> 创建包描述信息。 </summary>
        /// <param name="uniqueId"> 包唯一标识。 </param>
        /// <param name="packageData"> 每个包的数据。 </param>
        /// <param name="totalLength"> 流的总长度。 </param>
        /// <param name="packagesNum"> 分包个数。 </param>
        /// <param name="packageIdx"> 包索引数字。 </param>
        /// <returns> <see cref="FileStreamSummary" /> 类型的对象实例。 </returns>
        /// <seealso cref="StreamSummary" />
        /// <seealso cref="FileStreamSummary" />
        private FileStreamSummary CreateFileSummary(string uniqueId,
                                                    byte[] packageData,
                                                    long totalLength = 1,
                                                    int packagesNum = 0,
                                                    int packageIdx = 0)
        {
            return new FileStreamSummary()
            {
                Extensions = m_file?.Extension,
                FileName = m_file?.Name,
                IsSplitted = packagesNum > 0,
                PackageId = uniqueId,
                Package = new StreamPackage(packageIdx, packageData),
                Length = totalLength,
                PackagesNumber = packagesNum
            };
        }
    }
}