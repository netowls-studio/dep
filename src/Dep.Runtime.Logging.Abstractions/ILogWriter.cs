/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 12:08:39
 * Code:               ILogWriter.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary> 定义了记录运行时日志信息的接口。 </summary>
    public interface ILogWriter
    {
        /// <summary> 当记录日志的服务引发异常时，是否向上抛出。 </summary>
        /// <value> 获取一个值，用于表示当记录日志的服务引发异常时，是否向上抛出。 </value>
        bool ThrowIfInternalError { get; }

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        void Write(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information);

        /// <summary> 记录日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        void Write<TSource>(string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information);

        /// <summary> 记录调试日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Debug" />
        void WriteDebug(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录调试日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Debug" />
        void WriteDebug<TSource>(string message, Exception exception = null);

        /// <summary> 记录错误日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Error" />
        void WriteError(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录错误日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Error" />
        void WriteError<TSource>(string message, Exception exception = null);

        /// <summary> 记录异常日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Exceptional" />
        void WriteException(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录异常日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Exceptional" />
        void WriteException<TSource>(string message, Exception exception = null);

        /// <summary> 记录信息日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Information" />
        void WriteInformation(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录信息日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Information" />
        void WriteInformation<TSource>(string message, Exception exception = null);

        /// <summary> 记录追踪日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Trace" />
        void WriteTrace(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录追踪日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Trace" />
        void WriteTrace<TSource>(string message, Exception exception = null);

        /// <summary> 记录警告日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Warning" />
        void WriteWarning(Type sourceType, string message, Exception exception = null);

        /// <summary> 记录警告日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="LogEntryTypes.Warning" />
        void WriteWarning<TSource>(string message, Exception exception = null);
    }
}