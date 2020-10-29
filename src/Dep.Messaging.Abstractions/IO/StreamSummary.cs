/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 13:27:47
 * Code:               StreamSummary.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了 IO 流摘要相关的信息。 </summary>
    [Serializable]
    public class StreamSummary
    {
        /// <summary> 用于初始化一个 <see cref="StreamSummary" /> 类型的对象实例。 </summary>
        public StreamSummary()
        {
        }

        /// <summary> 是否被拆分多个包。 </summary>
        /// <value> 设置或获取一个值，用于表示是否被拆分多个包。 </value>
        [XmlAttribute("isSplitted", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("isSplitted")]
        public virtual bool IsSplitted { get; set; }

        /// <summary> IO 流的总长度。 </summary>
        /// <value> 设置或获取一个值，用于表示 IO 流的总长度。 </value>
        [XmlAttribute("length", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("length")]
        public virtual long Length { get; set; }

        /// <summary> 包数据。 </summary>
        /// <value> 设置或获取 <see cref="StreamPackage" /> 类型的对象实例，用于表示包数据。 </value>
        /// <seealso cref="StreamPackage" />
        [XmlElement("package", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("package")]
        public virtual StreamPackage Package { get; set; }

        /// <summary> 所有分包的统一标识。此字段用于订阅方合包。 </summary>
        /// <value> 设置或获取一个字符串，用于表示所有分包的统一标识。此字段用于订阅方合包。 </value>
        [XmlAttribute("packageId", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("packageId")]
        public virtual string PackageId { get; set; }

        /// <summary> 包的个数。 </summary>
        /// <value> 设置或获取一个值，用于表示包的个数。 </value>
        [XmlAttribute("packagesNumber", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("packagesNumber")]
        public virtual int PackagesNumber { get; set; }
    }
}