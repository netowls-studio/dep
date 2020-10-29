/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 13:17:15
 * Code:               StreamPackage.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了 IO 流分包相关的信息。 </summary>
    [Serializable]
    public class StreamPackage
    {
        /// <summary> 用于初始化一个 <see cref="StreamPackage" /> 类型的对象实例。 </summary>
        public StreamPackage()
        {
        }

        /// <summary> 用于初始化一个 <see cref="StreamPackage" /> 类型的对象实例。 </summary>
        /// <param name="packageData"> 包字节数据。 </param>
        public StreamPackage(byte[] packageData) : this(0, packageData)
        {
        }

        /// <summary> 用于初始化一个 <see cref="StreamPackage" /> 类型的对象实例。 </summary>
        /// <param name="index"> 包索引数字。 </param>
        /// <param name="packageData"> 包字节数据。 </param>
        public StreamPackage(int index, byte[] packageData)
        {
            Index = index;
            Data = packageData ?? throw new ArgumentNullException(nameof(packageData), string.Format(DepException.MessageTemplate, "未知的字节数据包"));
        }

        /// <summary> 包数据。 </summary>
        /// <value> 设置或获取 <see cref="byte" /> 类型的数组，用于表示包数据。 </value>
        [XmlArray(ElementName = "/", Namespace = XmlSerializerNamespaceDefaults.Uri), XmlArrayItem(ElementName = "item", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("packageData")]
        public virtual byte[] Data { get; set; }

        /// <summary> 包索引数字。 </summary>
        /// <value> 设置或获取一个值，用于表示包索引数字。 </value>
        [JsonProperty("index")]
        [XmlAttribute(AttributeName = "index", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        public virtual int Index { get; set; }
    }
}