/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 9:58:23
 * Code:               UriMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary>
    /// 提供了包含 URI 地址信息的消息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="ReferenceTypeMessage{T}" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [Serializable, XmlRoot(ElementName = XmlRootElementName, Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public sealed class UriMessage : ReferenceTypeMessage<string>
    {
        /// <summary> 用于初始化一个 <see cref="UriMessage" /> 类型的对象实例。 </summary>
        public UriMessage()
        {
        }

        /// <summary> 用于初始化一个 <see cref="UriMessage" /> 类型的对象实例。 </summary>
        /// <param name="uri"> URI 地址。 </param>
        /// <exception cref="ArgumentNullException"> </exception>
        public UriMessage(string uri) : base(uri)
        {
            if (string.IsNullOrWhiteSpace(uri))
                throw new ArgumentNullException(nameof(uri), string.Format(DepException.MessageTemplate, "未提供有效的 URI 地址"));
        }

        /// <summary> URI 地址。 </summary>
        /// <value> 获取一个字符串，用于表示 URI 地址。 </value>
        [XmlIgnore, JsonIgnore]
        public string Uri => base.MessageData;
    }
}