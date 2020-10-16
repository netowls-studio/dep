/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/16 12:52:10
 * Code:               DepConfigurationException.cs
 * ********************************************************************************************
 */

using System;
using System.Runtime.Serialization;

namespace NetowlsStudio.Dep.Configuration
{
    /// <summary>
    /// 提供了 DEP 配置异常相关的信息。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="DepException" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [Serializable]
    public sealed class DepConfigurationException : DepException
    {
        /// <summary> 默认的异常信息。 </summary>
        new public const string DefaultMessage = "配置信息异常";

        /// <summary> 用于初始化一个 <see cref="DepConfigurationException" /> 类型的对象实例。 </summary>
        public DepConfigurationException() : base(string.Format(DepException.MessageTemplate, DefaultMessage))
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepConfigurationException" /> 类型的对象实例。 </summary>
        /// <param name="message"> 异常信息。 </param>
        public DepConfigurationException(string message) : base(message)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepConfigurationException" /> 类型的对象实例。 </summary>
        /// <param name="message"> 异常信息。 </param>
        /// <param name="innerException"> 引发此异常的内部异常。 </param>
        /// <seealso cref="Exception" />
        public DepConfigurationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary> 用于初始化一个 <see cref="DepConfigurationException" /> 类型的对象实例。 </summary>
        /// <param name="serializationInfo"> <see cref="SerializationInfo" /> 类型的对象实例。 </param>
        /// <param name="streamingContext"> <see cref="StreamingContext" /> </param>
        /// <seealso cref="SerializationInfo" />
        /// <seealso cref="StreamingContext" />
        private DepConfigurationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {
        }
    }
}