/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/27 13:29:00
 * Code:               UriMessage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging
{
    /// <summary> 提供了包含了 URI 相关信息的消息。 </summary>
    /// <seealso cref="Message{TData}" />
    [Serializable, XmlRoot(ElementName = "uriContent", Namespace = XmlSerializerNamespaceDefaults.Uri)]
    public class UriMessage : Message<Uri>
    {
        /// <summary> 用于初始化一个 <see cref="UriMessage" /> 类型的对象实例。 </summary>
        public UriMessage()
        {
        }

        /// <summary> 用于初始化一个 <see cref="UriMessage" /> 类型的对象实例。 </summary>
        /// <param name="uri"> URI 地址。 </param>
        public UriMessage(string uri) : this(new Uri(uri))
        {
        }

        /// <summary> 用于初始化一个 <see cref="UriMessage" /> 类型的对象实例。 </summary>
        /// <param name="uri"> <see cref="Uri" /> 类型的对象实例。 </param>
        public UriMessage(Uri uri) : base(uri)
        {
        }

        /// <summary> URI 地址。 </summary>
        /// <value> 设置或获取 <see cref="Uri" /> 类型的对象实例，用于表示 URI 地址。 </value>
        /// <seealso cref="Uri" />
        [XmlAttribute(AttributeName = "uri", Namespace = XmlSerializerNamespaceDefaults.Uri), JsonProperty("uri")]
        public virtual Uri Uri
        {
            get { return Data; }
            set { Data = value; }
        }
    }
}