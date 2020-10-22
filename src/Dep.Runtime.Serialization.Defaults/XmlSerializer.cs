/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 10:33:02
 * Code:               XmlSerializer.cs
 * ********************************************************************************************
 */

using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using DotNetSerializer = System.Xml.Serialization.XmlSerializer;

namespace NetowlsStudio.Dep.Runtime.Serializations.Providers
{
    /// <summary> 提供了基于 .NET 默认提供的 <see cref="DotNetSerializer" /> 相关的序列化方法。 </summary>
    /// <seealso cref="Serializer" />
    public class XmlSerializer : Serializer
    {
        /// <summary> 用于初始化一个 <see cref="XmlSerializer" /> 类型的对象实例。 </summary>
        public XmlSerializer() : this(XmlSerializerNamespaceDefaults.Prefix, XmlSerializerNamespaceDefaults.Uri)
        {
        }

        /// <summary> 用于初始化一个 <see cref="XmlSerializer" /> 类型的对象实例。 </summary>
        /// <param name="nsPrefix"> XML 命名空间前缀。 </param>
        /// <param name="nsUri"> XML 命名空间 URI。 </param>
        public XmlSerializer(string nsPrefix, string nsUri)
        {
            NamespacePrefix = nsPrefix;
            NamespaceUri = nsUri;
            XmlNamespaces = new XmlSerializerNamespaces();
            XmlNamespaces.Add(nsPrefix, nsUri);
        }

        /// <summary> XML 命名空间前缀。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 XML 命名空间前缀。 </value>
        public string NamespacePrefix { get; }

        /// <summary> XML 命名空间 URI。 </summary>
        /// <value> 设置或获取一个字符串，用于表示 XML 命名空间 URI。 </value>
        public string NamespaceUri { get; }

        /// <summary> .NET 提供的 XML 序列化命名空间集合。 </summary>
        /// <value> 获取 <see cref="XmlSerializerNamespaces" /> 类型的对象实例，用于表示 .NET 提供的 XML 序列化命名空间集合。 </value>
        /// <seealso cref="XmlSerializerNamespaces" />
        protected XmlSerializerNamespaces XmlNamespaces { get; }

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        protected override T InternalDeserialize<T>(Stream deserializationStream) 
            => (T)new DotNetSerializer(typeof(T)).Deserialize(deserializationStream);

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        /// <exception cref="SerializationException"> </exception>
        protected override void InternalSerialize<T>(T graph, Stream serializationStream)
        {
            ThrowIfCannotSerialize(graph);
            new DotNetSerializer(typeof(T)).Serialize(serializationStream, graph, XmlNamespaces);
        }
    }
}