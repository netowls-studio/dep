/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 11:58:37
 * Code:               JsonSerializer.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Annotations;
using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace NetowlsStudio.Dep.Runtime.Serializations.Providers
{
    /// <summary>
    /// 提供了基于 Newtonsoft.Json 相关的序列化方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <seealso cref="Serializer" />
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    [InjectionName(nameof(JsonSerializer))]
    [DisplayName("JSON 序列化 - Newtonsoft.Json")]
    public sealed class JsonSerializer : Serializer
    {
        private const int c_bufferSize = 0x400;

        /// <summary> 用于初始化一个 <see cref="JsonSerializer" /> 类型的对象实例。 </summary>
        public JsonSerializer() : this(JsonSerializerDefaultSettings.Settings)
        {
        }

        /// <summary> 用于初始化一个 <see cref="JsonSerializer" /> 类型的对象实例。 </summary>
        /// <param name="settings"> JSON 序列化设置。 </param>
        public JsonSerializer(JsonSerializerSettings settings) : this(settings, Encoding.UTF8)
        {
        }

        /// <summary> 用于初始化一个 <see cref="JsonSerializer" /> 类型的对象实例。 </summary>
        /// <param name="settings"> JSON 序列化设置。 </param>
        /// <param name="encoding"> 编码器。 </param>
        public JsonSerializer(JsonSerializerSettings settings, Encoding encoding)
        {
            Encoding = encoding;
            Settings = settings;
        }

        /// <summary> 编码器。 </summary>
        /// <value> 获取 <see cref="Encoding" /> 类型的对象实例，用于表示编码器。 </value>
        /// <seealso cref="Encoding" />
        public Encoding Encoding { get; }

        /// <summary> JSON 序列化设置。 </summary>
        /// <value> 获取 <see cref="JsonSerializerSettings" /> 类型的对象实例，用于表示 JSON 序列化设置。 </value>
        /// <seealso cref="JsonSerializerSettings" />
        public JsonSerializerSettings Settings { get; }

        /// <summary> 从 JSON 字符串反序列化得到 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 实现了 <see cref="ISerializableObject" /> 接口的类型。 </typeparam>
        /// <param name="jsonStr"> JSON 文本内容。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        public T Deserialize<T>(string jsonStr)
            where T : class, ISerializableObject, new() => JsonConvert.DeserializeObject<T>(jsonStr, Settings);

        /// <summary> 序列化获取 JSON 字符串。 </summary>
        /// <typeparam name="T"> 实现了 <see cref="ISerializableObject" /> 接口的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns> JSON 字符串。 </returns>
        /// <see cref="ISerializableObject" />
        public string GetJsonString<T>(T graph)
            where T : class, ISerializableObject, new() => JsonConvert.SerializeObject(graph, Settings);

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        /// <exception cref="IOException"> </exception>
        /// <exception cref="System.ObjectDisposedException"> </exception>
        protected override T InternalDeserialize<T>(Stream deserializationStream)
        {
            var buffer = new byte[c_bufferSize];
            var readSize = deserializationStream.Read(buffer, 0, c_bufferSize);
            using (var bufferStream = new MemoryStream())
            {
                while (readSize > 0)
                {
                    bufferStream.Write(buffer, 0, readSize);
                    readSize = deserializationStream.Read(buffer, 0, c_bufferSize);
                }
                return Deserialize<T>(Encoding.GetString(bufferStream.ToArray()));
            }
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        /// <exception cref="IOException"></exception>
        /// <exception cref="System.ObjectDisposedException"></exception>
        protected override void InternalSerialize<T>(T graph, Stream serializationStream)
        {
            var jsonStr = GetJsonString<T>(graph);
            var data = Encoding.GetBytes(jsonStr);
            serializationStream.Write(data, 0, data.Length);
        }
    }
}