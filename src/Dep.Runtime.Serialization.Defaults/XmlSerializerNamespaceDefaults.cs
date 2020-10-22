/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/10/22 10:29:55
 * Code:               XmlSerializerNamespaceDefaults.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Runtime.Serializations.Providers
{
    /// <summary> 提供了 XML 序列化命名空间相关的常量定义（静态的）。 </summary>
    public static class XmlSerializerNamespaceDefaults
    {
        /// <summary> XML 命名空间前缀。 </summary>
        public const string Prefix = "dep";

        /// <summary> XML 命名空间 URI。 </summary>
        public const string Uri = "https://github.com/netowls-studio/dep";

        /// <summary> <see cref="XmlSerializerNamespaceDefaults" /> 类型的静态构造方法。 </summary>
        static XmlSerializerNamespaceDefaults()
        {
        }
    }
}