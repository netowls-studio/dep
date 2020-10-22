/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/21 11:45:26
 * Code:               ISerializableObject.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Runtime.Serializations
{
    /// <summary> 定义了可序列化的对象标记接口。 </summary>
    public interface ISerializableObject
    {
        /// <summary> 是否可以序列化或反序列化。 </summary>
        /// <value> 获取一个值，用于表示是否可以序列化或反序列化。 </value>
        bool CanSerialize { get; }
    }
}