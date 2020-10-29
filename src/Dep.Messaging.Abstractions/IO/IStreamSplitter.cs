/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 13:50:09
 * Code:               IStreamSplitter.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 定义了 IO 拆包的接口。 </summary>
    public interface IStreamSplitter
    {
        /// <summary> 对指定的流进行拆包。 </summary>
        /// <returns> <see cref="StreamSummary" /> 类型的对象实例集合。 </returns>
        /// <seealso cref="IEnumerable{T}" />
        /// <seealso cref="StreamSummary" />
        IEnumerable<StreamSummary> Split();
    }
}