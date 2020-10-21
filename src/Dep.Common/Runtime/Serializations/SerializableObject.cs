/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 11:49:16
 * Code:               SerializableObject.cs
 * ********************************************************************************************
 */

using System;

namespace NetowlsStudio.Dep.Runtime.Serializations
{
    /// <summary> 提供了可序列化的对象相关的基本方法。 </summary>
    /// <seealso cref="ISerializableObject" />
    [Serializable]
    public abstract class SerializableObject : ISerializableObject
    {
        /// <summary> 用于初始化一个 <see cref="SerializableObject" /> 类型的对象实例。 </summary>
        protected SerializableObject()
        {
        }

        /// <summary> 是否可以序列化或反序列化。 </summary>
        /// <value> 获取一个值，用于表示是否可以序列化或反序列化。 </value>
        /// <exception cref="System.Reflection.AmbiguousMatchException"></exception>
        /// <exception cref="TypeLoadException"></exception>
        public virtual bool CanSerialize => HasSerializableAttribute();

        /// <summary> 是否具有 <see cref="SerializableAttribute" /> 特性。 </summary>
        /// <returns> 如果具有 <see cref="SerializableAttribute" /> 特性，则返回 <c> true </c>；否则返回 <c> false </c>。 </returns>
        /// <exception cref="System.Reflection.AmbiguousMatchException"> </exception>
        /// <exception cref="TypeLoadException"> </exception>
        protected bool HasSerializableAttribute()
        {
            var serializableAttr = Attribute.GetCustomAttribute(GetType(), typeof(SerializableAttribute)) as SerializableAttribute;
            return !(serializableAttr is null);
        }
    }
}