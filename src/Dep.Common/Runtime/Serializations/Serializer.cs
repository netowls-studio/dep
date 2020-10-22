/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 11:55:36
 * Code:               Serializer.cs
 * ********************************************************************************************
 */

using System.IO;
using System.Runtime.Serialization;

namespace NetowlsStudio.Dep.Runtime.Serializations
{
    /// <summary> 提供了 .NET 对象序列化相关的基本方法。 </summary>
    /// <seealso cref="ISerializer" />
    public abstract class Serializer : ISerializer
    {
        /// <summary> 用于初始化一个 <see cref="Serializer" /> 类型的对象实例。 </summary>
        protected Serializer()
        {
        }

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        T ISerializer.Deserialize<T>(Stream deserializationStream) => InternalDeserialize<T>(deserializationStream);

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="data"> 需要序列化的字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        T ISerializer.Deserialize<T>(byte[] data)
        {
            using (var deserializationStream = new MemoryStream(data))
            {
                return InternalDeserialize<T>(deserializationStream);
            }
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="ISerializableObject" />
        byte[] ISerializer.Serialize<T>(T graph)
        {
            using (var serializationStream = new MemoryStream())
            {
                InternalSerialize<T>(graph, serializationStream);

                return serializationStream.ToArray();
            }
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        void ISerializer.Serialize<T>(T graph, Stream serializationStream) => InternalSerialize(graph, serializationStream);

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        protected abstract T InternalDeserialize<T>(Stream deserializationStream) where T : class, ISerializableObject, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        protected abstract void InternalSerialize<T>(T graph, Stream serializationStream) where T : class, ISerializableObject, new();

        /// <summary> 当 <paramref name="graph" /> 不允许被序列化 (即： <see cref="ISerializableObject.CanSerialize" /> 等于 <c> false </c>) 时，将引发一个 <see cref="SerializationException" /> 类型的异常。 </summary>
        /// <param name="graph"> 实现了 <see cref="ISerializableObject" /> 类型接口的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="ISerializableObject.CanSerialize" />
        /// <exception cref="SerializationException"> </exception>
        protected void ThrowIfCannotSerialize(ISerializableObject graph)
        {
            if (!graph.CanSerialize)
                throw new SerializationException(string.Format(DepException.MessageTemplate, $"类型 “{graph.GetType().AssemblyQualifiedName}” 不能被序列化"));
        }
    }
}