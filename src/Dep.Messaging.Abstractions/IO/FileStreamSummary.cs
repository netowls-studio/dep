using NetowlsStudio.Dep.Runtime.Serializations.Providers;
using Newtonsoft.Json;
using System;
using System.Xml.Serialization;

namespace NetowlsStudio.Dep.Messaging.IO
{
    /// <summary>
    /// 提供了文件流相关的摘要信息。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="StreamSummary" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [Serializable]
    public sealed class FileStreamSummary : StreamSummary
    {
        /// <summary> 用于初始化一个 <see cref="FileStreamSummary" /> 类型的对象实例。 </summary>
        public FileStreamSummary()
        {
        }

        /// <summary> 文件扩展名。 </summary>
        /// <value> 设置或获取一个字符串，用于表示文件扩展名。 </value>
        [XmlAttribute("extensions", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        /// <summary> 文件名称。 </summary>
        /// <value> 设置或获取一个字符串，用于表示文件名称。 </value>
        [XmlAttribute("fileName", Namespace = XmlSerializerNamespaceDefaults.Uri)]
        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }
}