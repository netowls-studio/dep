/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 11:35:45
 * Code:               ISerializer.cs
 * ********************************************************************************************
 */

using System.IO;

namespace NetowlsStudio.Dep.Runtime.Serializations
{
    /// <summary> 定义了序列化的接口。 </summary>
    public interface ISerializer
    {
        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        T Deserialize<T>(Stream deserializationStream) where T : class, ISerializableObject, new();

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="data"> 需要序列化的字节数组。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        T Deserialize<T>(byte[] data) where T : class, ISerializableObject, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <returns> 字节数组。 </returns>
        /// <seealso cref="ISerializableObject" />
        byte[] Serialize<T>(T graph) where T : class, ISerializableObject, new();

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        void Serialize<T>(T graph, Stream serializationStream) where T : class, ISerializableObject, new();
    }
}