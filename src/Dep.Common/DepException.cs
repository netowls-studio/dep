/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/15 11:43:33
 * Code:               DepException.cs
 * ********************************************************************************************
 */

using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace NetowlsStudio.Dep
{
    /// <summary> 提供了 DEP 系统异常信息。 </summary>
    /// <seealso cref="Exception" />
    /// <seealso cref="SerializableAttribute" />
    [Serializable]
    public class DepException : Exception
    {
        /// <summary> 异常信息模板。 </summary>
        public const string MessageTemplate = "DEP 异常：{0}";

        /// <summary> 默认异常信息。 </summary>
        public static readonly string DefaultMessage = string.Format(MessageTemplate, "引发了未处理的异常。");

        /// <summary> 用于初始化一个 <see cref="DepException" /> 类型的对象实例。 </summary>
        public DepException()
            : this(DefaultMessage)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepException" /> 类型的对象实例。 </summary>
        /// <param name="message"> 异常信息。 </param>
        public DepException(string message)
            : this(message, null)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepException" /> 类型的对象实例。 </summary>
        /// <param name="message"> 异常信息。 </param>
        /// <param name="innerException"> 引发此异常的内部异常。 </param>
        /// <seealso cref="Exception" />
        public DepException(string message, Exception innerException)
            : base(GetMessage(message), innerException)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepException" /> 类型的对象实例。 </summary>
        /// <param name="serializationInfo"> <see cref="SerializationInfo" /> 类型的对象实例。 </param>
        /// <param name="streamingContext"> <see cref="StreamingContext" /> </param>
        /// <seealso cref="SerializationInfo" />
        /// <seealso cref="StreamingContext" />
        protected DepException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }

        /// <summary> 获取异常信息。 </summary>
        /// <param name="message"> 异常信息。 </param>
        /// <returns> 异常信息。 </returns>
        /// <exception cref="RegexMatchTimeoutException"> </exception>
        private static string GetMessage(string message)
        {
#if NET35
            if (string.IsNullOrEmpty(message))
                return DefaultMessage;
#else
            if (string.IsNullOrWhiteSpace(message))
                return DefaultMessage;
#endif
            if (IsMatchTemplate(message))
                return message;
            return string.Format(MessageTemplate, message);
        }

        /// <summary> 用于校验异常信息是否满足指定格式。 </summary>
        /// <param name="message"> 异常信息。 </param>
        /// <returns> 如果满足，则返回 <c> true </c>；否则返回 <c> false </c>。 </returns>
        /// <exception cref="RegexMatchTimeoutException"> </exception>
        private static bool IsMatchTemplate(string message)
        {
            const string pattern = @"^[Dd][Ee][Pp]\s异常：";
            return Regex.IsMatch(message, pattern);
        }
    }
}
