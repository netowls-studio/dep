/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/20 11:35:08
 * Code:               LogEntryTypes.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Runtime.Logging
{
    /// <summary> 定义了日志项类型枚举类型。 </summary>
    [Serializable, Flags]
    public enum LogEntryTypes
    {
        /// <summary> 追踪日志。 </summary>
        Trace = 1,

        /// <summary> 调试日志。 </summary>
        Debug = 2,

        /// <summary> 信息日志。 </summary>
        Information = 4,

        /// <summary> 警告日志。 </summary>
        Warning = 8,

        /// <summary> 错误日志。 </summary>
        Error = 16,

        /// <summary> 异常日志。 </summary>
        Exceptional = 32
    }
}