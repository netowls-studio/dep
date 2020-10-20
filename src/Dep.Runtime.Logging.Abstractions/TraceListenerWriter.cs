/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 13:26:43
 * Code:               TraceListenerWriter.cs
 * ********************************************************************************************
 */

using System;
using System.Diagnostics;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary>
    /// 提供了基于 .NET <see cref="TraceListener" /> 记录运行时日志相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="LogWriterBase" />
    /// <seealso cref="TraceListener" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class TraceListenerWriter : LogWriterBase
    {
        /// <summary> 用于初始化一个 <see cref="TraceListenerWriter" /> 类型的对象实例。 </summary>
        public TraceListenerWriter()
        {
        }

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        protected override void InternalWrite(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            if (EqualsType(type, LogEntryTypes.Debug))
                Debug.WriteLine(message);
            else
                Trace.WriteLine(message);
        }
    }
}