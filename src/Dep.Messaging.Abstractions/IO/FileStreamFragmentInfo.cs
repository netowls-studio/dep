/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/29 11:42:31
 * Code:               FileStreamFragmentInfo.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary>
    /// 提供了文件流分片信息相关的方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="StreamFragmentInfo" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [Serializable]
    public sealed class FileStreamFragmentInfo : StreamFragmentInfo
    {
        /// <summary> 用于初始化一个 <see cref="FileStreamFragmentInfo" /> 类型的对象实例。 </summary>
        public FileStreamFragmentInfo()
        {
        }

        /// <summary> 用于初始化一个 <see cref="FileStreamFragmentInfo" /> 类型的对象实例。 </summary>
        /// <param name="index"> 当前片段的索引数值。 </param>
        /// <param name="fragmentData"> 当前片段字节数据。 </param>
        public FileStreamFragmentInfo(int index, byte[] fragmentData) : base(index, fragmentData)
        {
        }

        /// <summary> 用于初始化一个 <see cref="FileStreamFragmentInfo" /> 类型的对象实例。 </summary>
        /// <param name="index"> 当前片段的索引数值。 </param>
        /// <param name="totalLength">
        /// 目标流的总长度。
        /// <para> 参见 <see cref="P:System.IO.Stream.Length" />。 </para>
        /// </param>
        /// <param name="fragmentData"> 当前片段字节数据。 </param>
        public FileStreamFragmentInfo(int index, long totalLength, byte[] fragmentData) : base(index, totalLength, fragmentData)
        {
        }

        /// <summary> 文件名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示文件名称。 </value>
        [XmlAttribute(AttributeName = "fileName", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        /// <summary> 文件路径。 </summary>
        /// <value> 设置或获取一个字符串，用于表示文件路径。 </value>
        [XmlAttribute(AttributeName = "path", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}