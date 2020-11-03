/*
 * ********************************************************************************************
 * Copyright © 2006 - 2020 Wang Yucai. All rights reserved.
 * Licensed under the MS-PL License See LICENSE in the project root for license information.
 *
 *
 * Author:             Wang Yucai
 * Git Repository Url: https://github.com/netowls-studio/dep
 * Created Time:       2020/11/3 10:30:55
 * Code:               ClusterProviders.cs
 * ********************************************************************************************
 */

namespace NetowlsStudio.Dep.Server
{
    /// <summary> 提供了群集管理程序相关的默认值（静态的）。 </summary>
    public static class ClusterProviders
    {
        /// <summary> 使用 Consul 作为群集管理程序。 </summary>
        public const string Consul = "Consul";

        /// <summary> 单节点程序。 </summary>
        public const string SingleNode = "SingleNode";

        /// <summary> 使用 Apache Zookeeper 作为群集管理程序。 </summary>
        public const string Zookeeper = "Zookeeper";

        /// <summary> <see cref="ClusterProviders" /> 类型的静态构造方法。 </summary>
        static ClusterProviders()
        {
        }
    }
}