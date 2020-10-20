/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 12:21:38
 * Code:               LogWriterBase.cs
 * ********************************************************************************************
 */

using System;
using System.Diagnostics;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary> 提供了记录运行时日志相关的基本方法。 </summary>
    /// <seealso cref="ILogWriter" />
    public abstract class LogWriterBase : ILogWriter
    {
        private bool m_throwIfInternalError;

        /// <summary> 用于初始化一个 <see cref="LogWriterBase" /> 类型的对象实例。 </summary>
        protected LogWriterBase() : this(false)
        {
        }

        /// <summary> 用于初始化一个 <see cref="LogWriterBase" /> 类型的对象实例。 </summary>
        /// <param name="throwIfInternalError"> 日志服务内部发生异常时，是否向上抛出。 </param>
        protected LogWriterBase(bool throwIfInternalError)
        {
            m_throwIfInternalError = throwIfInternalError;
        }

        /// <summary> 当记录日志的服务引发异常时，是否向上抛出。 </summary>
        /// <value> 获取一个值，用于表示当记录日志的服务引发异常时，是否向上抛出。 </value>
        public virtual bool ThrowIfInternalError => m_throwIfInternalError;

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        public virtual void Write(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            try
            {
                InternalWrite(sourceType, CompleteMessage(sourceType, message, exception, type), exception, type);
            }
            catch
            {
                Trace.TraceError($"DEP：日志组件 “{GetType().FullName}” 引发了未处理的异常。");
                if (ThrowIfInternalError)
                    throw;
            }
        }

        /// <summary> 记录日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        public virtual void Write<TSource>(string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            Write(typeof(TSource), message, exception, type);
        }

        /// <summary> 记录调试日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Debug" />
        public virtual void WriteDebug(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Debug);
        }

        /// <summary> 记录调试日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Debug" />
        public virtual void WriteDebug<TSource>(string message, Exception exception = null)
        {
            WriteDebug(typeof(TSource), message, exception);
        }

        /// <summary> 记录错误日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Error" />
        public virtual void WriteError(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Error | LogEntryTypes.Warning);
        }

        /// <summary> 记录错误日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Error" />
        public virtual void WriteError<TSource>(string message, Exception exception = null)
        {
            WriteError(typeof(TSource), message, exception);
        }

        /// <summary> 记录异常日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Exceptional" />
        public virtual void WriteException(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Exceptional | LogEntryTypes.Error | LogEntryTypes.Warning);
        }

        /// <summary> 记录异常日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Exceptional" />
        public virtual void WriteException<TSource>(string message, Exception exception = null)
        {
            WriteException(typeof(TSource), message, exception);
        }

        /// <summary> 记录信息日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Information" />
        public virtual void WriteInformation(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Information);
        }

        /// <summary> 记录信息日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Information" />
        public virtual void WriteInformation<TSource>(string message, Exception exception = null)
        {
            WriteInformation(typeof(TSource), message, exception);
        }

        /// <summary> 记录追踪日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Trace" />
        public virtual void WriteTrace(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Trace);
        }

        /// <summary> 记录追踪日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Trace" />
        public virtual void WriteTrace<TSource>(string message, Exception exception = null)
        {
            WriteTrace(typeof(TSource), message, exception);
        }

        /// <summary> 记录警告日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Warning" />
        public virtual void WriteWarning(Type sourceType, string message, Exception exception = null)
        {
            Write(sourceType, message, exception, LogEntryTypes.Warning | LogEntryTypes.Information);
        }

        /// <summary> 记录警告日志。 </summary>
        /// <typeparam name="TSource"> 记录日志的类型。 </typeparam>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <seealso cref="LogEntryTypes" />
        /// <seealso cref="F:NetowlsStudio.Dep.Runtime.Logging.LogEntryTypes.Warning" />
        public virtual void WriteWarning<TSource>(string message, Exception exception = null)
        {
            WriteWarning(typeof(TSource), message, exception);
        }

        /// <summary> 完善日志信息。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <returns> 日志信息。 </returns>
        /// <seealso cref="LogEntryTypes" />
        protected string CompleteMessage(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            var typeDescription = "信息";
            switch (type)
            {
                case LogEntryTypes.Trace: typeDescription = "追踪"; break;
                case LogEntryTypes.Debug: typeDescription = "调试"; break;
                case LogEntryTypes.Information: typeDescription = "信息"; break;
                case LogEntryTypes.Warning: typeDescription = "警告"; break;
                case LogEntryTypes.Error: typeDescription = "错误"; break;
                case LogEntryTypes.Exceptional: typeDescription = "异常"; break;
            }
            return exception is null
                ? $"[DEP {typeDescription} - {sourceType.FullName}]: {message}。"
                : $"[DEP {typeDescription} - {sourceType.FullName}]: 当 “{message}” 时，DEP 引发了一个 {exception.GetType().FullName} 类型的异常：“{exception.Message}”。具体信息参见 InnerException 属性。";
        }

        /// <summary> 用于比较 <paramref name="sourceType" /> 是否等于 <paramref name="targetType" />。 </summary>
        /// <param name="sourceType"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <param name="targetType"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <returns> 用于比较 <paramref name="sourceType" /> 是否等于 <paramref name="targetType" />。如果相等返回 <c> true </c>；否则返回 <c> false </c>。 </returns>
        /// <seealso cref="LogEntryTypes" />
        protected bool EqualsType(LogEntryTypes sourceType, LogEntryTypes targetType = LogEntryTypes.Information)
            => (sourceType & targetType) == targetType;

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        protected abstract void InternalWrite(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information);
    }
}