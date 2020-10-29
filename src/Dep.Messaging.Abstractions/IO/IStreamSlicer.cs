/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 10:59:39
 * Code:               IStreamSlicer.cs
 * ********************************************************************************************
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 定义了流分割的接口。 </summary>
    public interface IStreamSlicer
    {
        /// <summary> 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <see cref="StreamFragmentInfo" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="IOException"> </exception>
        IEnumerable<StreamFragmentInfo> Split(Stream stream);

        /// <summary> (异步的方法) 分割流 <paramref name="stream" />。 </summary>
        /// <param name="stream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> 包含了 <see cref="StreamFragmentInfo" /> 类型的对象实例集合和异常信息的 <see cref="Tuple{T1, T2}" />。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="Tuple{T1, T2}" />
        /// <seealso cref="StreamFragmentInfo" />
        /// <exception cref="IOException"> </exception>
        Task<Tuple<IEnumerable<StreamFragmentInfo>, Exception>> SplitAsync(Stream stream);
    }
}