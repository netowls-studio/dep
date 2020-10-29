/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 10:37:24
 * Code:               StreamFragmentInfo.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary> 提供了流分片信息相关的方法。 </summary>
    public class StreamFragmentInfo
    {
        /// <summary> 用于初始化一个 <see cref="StreamFragmentInfo" /> 类型的对象实例。 </summary>
        public StreamFragmentInfo()
        {
        }

        /// <summary> 用于初始化一个 <see cref="StreamFragmentInfo" /> 类型的对象实例。 </summary>
        /// <param name="index"> 当前片段的索引数值。 </param>
        /// <param name="fragmentData"> 当前片段字节数据。 </param>
        public StreamFragmentInfo(int index, byte[] fragmentData) : this(index, fragmentData.LongLength, fragmentData)
        {
        }

        /// <summary> 用于初始化一个 <see cref="StreamFragmentInfo" /> 类型的对象实例。 </summary>
        /// <param name="index"> 当前片段的索引数值。 </param>
        /// <param name="totalLength">
        /// 目标流的总长度。
        /// <para> 参见 <see cref="System.IO.Stream.Length" />。 </para>
        /// </param>
        /// <param name="fragmentData"> 当前片段字节数据。 </param>
        public StreamFragmentInfo(int index, long totalLength, byte[] fragmentData)
        {
            Index = index;
            TotalLength = totalLength;
            FragmentData = fragmentData;
        }

        /// <summary> 当前片段的字节数据。 </summary>
        /// <value> 设置或获取 <see cref="byte" /> 类型的数组，用于表示当前片段的字节数据。 </value>
        [XmlArray(ElementName = "binaries", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [XmlArrayItem(ElementName = "item", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("binaries")]
        public virtual byte[] FragmentData { get; set; }

        /// <summary> 当前片段的索引数值。 </summary>
        /// <value> 设置或获取一个值，用于表示当前片段的索引数值。 </value>
        [XmlAttribute(AttributeName = "id", Namespace = XmlSerializerNamespaceDefaults.Uri), JsonProperty("id")]
        public int Index { get; set; }

        /// <summary> 流的总长度。 </summary>
        /// <value> 设置或获取一个值，用于表示流的总长度。 </value>
        [XmlAttribute(AttributeName = "totalLength", Namespace = XmlSerializerNamespaceDefaults.Uri), JsonProperty("totalLength")]
        public virtual long TotalLength { get; set; }
    }
}