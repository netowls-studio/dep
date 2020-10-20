/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 13:17:39
 * Code:               LogWriter.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary>
    /// 提供了记录运行时日志相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="ILogWriter" />
    /// <seealso cref="LogWriterBase" />
    /// <seealso cref="LogWriterCollection" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class LogWriter : LogWriterBase
    {
        /// <summary> 默认的日志服务。 </summary>
        public static readonly ILogWriter CurrentWriter = new LogWriter();

        /// <summary> 用于初始化一个 <see cref="LogWriter" /> 类型的对象实例。 </summary>
        public LogWriter()
        {
            Writers = new LogWriterCollection();
        }

        /// <summary> 记录运行时日志的服务集合。 </summary>
        /// <value> 获取 <see cref="LogWriterCollection" /> 类型的对象实例，用于表示记录运行时日志的服务集合。 </value>
        /// <seealso cref="LogWriterCollection" />
        public LogWriterCollection Writers { get; }

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        protected override void InternalWrite(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            foreach (var writer in Writers)
            {
                writer.Write(sourceType, message, exception, type);
            }
        }
    }
}