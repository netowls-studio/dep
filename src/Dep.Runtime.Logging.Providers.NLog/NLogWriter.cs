/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 10:00:11
 * Code:               NLogWriter.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Logging.Providers.Configuration;
using NLog;
using System;

namespace NetowlsStudio.Dep.Runtime.Logging.Providers
{
    /// <summary>
    /// 提供了基于 NLog 记录运行时日志相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="LogWriterBase" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    public sealed class NLogWriter : LogWriterBase
    {
        private readonly ILogger m_nlogger = LogManager.GetCurrentClassLogger();

        /// <summary> 用于初始化一个 <see cref="NLogWriter" /> 类型的对象实例。 </summary>
        public NLogWriter()
        {
        }

        /// <summary> 初始化 NLog 日志服务。 </summary>
        /// <param name="setup"> 实现了 <see cref="INLogConfigurationSetup" /> 类型接口的对象实例。 </param>
        /// <seealso cref="INLogConfigurationSetup" />
        public static void Setup(INLogConfigurationSetup setup)
        {
            LogManager.Configuration = setup.Get();
        }

        /// <summary> 记录日志。 </summary>
        /// <param name="sourceType"> 记录日志的类型。 </param>
        /// <param name="message"> 日志描述信息。 </param>
        /// <param name="exception"> 异常信息。 </param>
        /// <param name="type"> <see cref="LogEntryTypes" /> 类型的值。 </param>
        /// <seealso cref="LogEntryTypes" />
        protected override void InternalWrite(Type sourceType, string message, Exception exception = null, LogEntryTypes type = LogEntryTypes.Information)
        {
            if (EqualsType(type, LogEntryTypes.Trace))
                m_nlogger.Trace(exception, message);
            if (EqualsType(type, LogEntryTypes.Debug))
                m_nlogger.Debug(exception, message);
            if (EqualsType(type, LogEntryTypes.Information))
                m_nlogger.Info(exception, message);
            if (EqualsType(type, LogEntryTypes.Warning))
                m_nlogger.Warn(exception, message);
            if (EqualsType(type, LogEntryTypes.Error))
                m_nlogger.Error(exception, message);
            if (EqualsType(type, LogEntryTypes.Exceptional))
                m_nlogger.Fatal(exception, message);
        }
    }
}