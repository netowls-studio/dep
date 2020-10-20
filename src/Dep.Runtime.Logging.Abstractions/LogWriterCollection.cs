/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 13:12:55
 * Code:               LogWriterCollection.cs
 * ********************************************************************************************
 */

using System.Collections.Generic;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary>
    /// 提供了 <see cref="ILogWriter" /> 类型的对象实例集合。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="ILogWriter" />
    /// <seealso cref="List{T}" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class LogWriterCollection : List<ILogWriter>
    {
        /// <summary> 用于初始化一个 <see cref="LogWriterCollection" /> 类型的对象实例。 </summary>
        public LogWriterCollection()
        {
        }

        /// <summary> 用于初始化一个 <see cref="LogWriterCollection" /> 类型的对象实例。 </summary>
        /// <param name="collection"> 用于初始化 <see cref="ILogWriter" /> 类型的对象实例集合。 </param>
        public LogWriterCollection(IEnumerable<ILogWriter> collection) : base(collection)
        {
        }
    }
}