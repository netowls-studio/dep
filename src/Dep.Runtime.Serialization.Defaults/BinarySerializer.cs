/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 11:14:14
 * Code:               BinarySerializer.cs
 * ********************************************************************************************
 */

using NetowlsStudio.Dep.Annotations;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NetowlsStudio.Dep.Runtime.Serializations.Providers
{
    /// <summary>
    /// 提供了基于 .NET 提供的 <see cref="Implementation" /> 相关的二进制序列化方法。
    /// <para> 密闭的，不可以从此类型派生。 </para>
    /// </summary>
    /// <remarks> 密闭的，不可以从此类型派生。 </remarks>
    /// <seealso cref="Serializer" />
    /// <seealso cref="Implementation" />
    [InjectionName(nameof(Implementation))]
    public sealed class BinarySerializer : Serializer
    {
        /// <summary> 用于初始化一个 <see cref="BinarySerializer" /> 类型的对象实例。 </summary>
        public BinarySerializer()
        {
            Implementation = new BinaryFormatter();
        }

        /// <summary> 二进制序列化程序。 </summary>
        /// <value> 获取 <see cref="BinaryFormatter" /> 类型的对象实例，用于表示二进制序列化程序。 </value>
        /// <seealso cref="BinaryFormatter" />
        public BinaryFormatter Implementation { get; }

        /// <summary> 反序列化 <typeparamref name="T" /> 类型的对象实例。 </summary>
        /// <typeparam name="T"> 目标类型。 </typeparam>
        /// <param name="deserializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        /// <exception cref="System.Runtime.Serialization.SerializationException"> </exception>
        /// <exception cref="System.Security.SecurityException"> </exception>
        protected override T InternalDeserialize<T>(Stream deserializationStream)
        {
            return (T)Implementation.Deserialize(deserializationStream);
        }

        /// <summary> 序列化 <typeparamref name="T" /> 类型的对象实例，并写入流 <paramref name="serializationStream" />。 </summary>
        /// <typeparam name="T"> 需要序列化的类型。 </typeparam>
        /// <param name="graph"> <typeparamref name="T" /> 类型的对象实例。 </param>
        /// <param name="serializationStream"> 派生自 <see cref="Stream" /> 类型的对象实例。 </param>
        /// <seealso cref="ISerializableObject" />
        /// <seealso cref="Stream" />
        /// <exception cref="System.Runtime.Serialization.SerializationException"></exception>
        /// <exception cref="System.Security.SecurityException"></exception>
        protected override void InternalSerialize<T>(T graph, Stream serializationStream)
        {
            ThrowIfCannotSerialize(graph);
            Implementation.Serialize(serializationStream, graph);
        }
    }
}